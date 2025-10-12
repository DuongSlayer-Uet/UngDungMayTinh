from machine import Pin, I2C, UART
import time
import ustruct

# Khởi tạo I2C (ESP32: SDA=21, SCL=22)
i2c = I2C(0, scl=Pin(22), sda=Pin(21), freq=100000)

# Khởi tạo UART
uart2 = UART(2, baudrate=9600, tx=Pin(17), rx=Pin(16))

# Khởi tạo chân điều khiển MAX485
RE = Pin(15, Pin.OUT)
DE = Pin(2, Pin.OUT)

# Ban đầu đặt ở chế độ nhận
RE.value(0)
DE.value(0)

# READ raw temp
def read_raw_temp(i2c, addr=0x77):
    # Request
    i2c.writeto_mem(addr, 0xF4, bytes([0x2E]))
    
    # wait 4.5ms
    time.sleep_ms(5)
    
    # read 2 byte
    data = i2c.readfrom_mem(addr, 0xF6, 2)
    
    # combine
    raw_temp = (data[0] << 8) | data[1]
    return raw_temp

# READ calib value
def read_signed16bit(reg):
    data = i2c.readfrom_mem(0x77, reg, 2)
    return ustruct.unpack('>h', data)[0]		# > là big edian (theo bmp180) và h là signed data

def read_unsigned16bit(reg):
    data = i2c.readfrom_mem(0x77, reg, 2)
    return ustruct.unpack('>H', data)[0]		# > là big edian (theo bmp180) và H là unsigned data
# READ from eeprom
AC1 = read_signed16bit(0xAA)
AC2 = read_signed16bit(0xAC)
AC3 = read_signed16bit(0xAE)
AC4 = read_unsigned16bit(0xB0)
AC5 = read_unsigned16bit(0xB2)
AC6 = read_unsigned16bit(0xB4)
B1  = read_signed16bit(0xB6)
B2  = read_signed16bit(0xB8)
MB  = read_signed16bit(0xBA)
MC  = read_signed16bit(0xBC)
MD  = read_signed16bit(0xBE)

def read_temperature():
    UT = read_raw_temp(i2c)
    X1 = ((UT - AC6) * AC5) >> 15
    X2 = (MC << 11) // (X1 + MD)
    B5 = X1 + X2
    T = (B5 + 8) >> 4
    return T   # °C

def modbus_crc(data, length=None):
    crc = 0xFFFF
    if length is None:
        length = len(data)

    for pos in range(length):
        crc ^= data[pos]
        for i in range(8):
            if crc & 0x0001:
                crc >>= 1
                crc ^= 0xA001
            else:
                crc >>= 1

    # Kết quả: [CRC Low, CRC High]
    crc_low = crc & 0xFF
    crc_high = (crc >> 8) & 0xFF
    return bytes([crc_low, crc_high])

rx_buf = bytearray()
rx_buf_index = 0
temperature = 0

def process_modbus_data(frame):
    global temperature
    # Nếu func là read registers
    if frame[1] == 0x04:
        slave_id = 0x06
        func_code = 0x04
        temp_val = int(temperature)  # ví dụ: 253 = 0x00FD
        temp_high = (temp_val >> 8) & 0xFF
        temp_low  = temp_val & 0xFF
        tx_frame = bytes([slave_id, func_code, temp_high, temp_low])
        # Tính CRC cho gói 4 byte đầu
        crc = modbus_crc(tx_frame)
        # Ghép lại frame hoàn chỉnh
        tx_frame += crc
        # Chế độ gửi
        RE.value(1)
        DE.value(1)
        # Gửi qua UART
        uart2.write(tx_frame)
        time.sleep(0.08)
        # Receive mode
        RE.value(0)
        DE.value(0)

def rx_callback(rx):
    global rx_buf, rx_buf_index
    if rx.any():
        data = rx.read()
        rx_buf.extend(data)
        rx_buf_index += len(data)   # tăng theo số byte thực sự nhận

        if rx_buf_index >= 6:
            frame = bytes(rx_buf[:6])
            crc_val = modbus_crc(frame[0:4])
            # CRC cal
            if frame[4] == crc_val[0] and frame[5] == crc_val[1]:
                if frame[0] == 0x06:
                    process_modbus_data(frame)
                rx_buf = rx_buf[6:]
                rx_buf_index -= 6


# Gán callback
uart2.irq(handler=rx_callback, trigger=UART.IRQ_RX)		# IRQ_RX flag trigger IRQ sau mỗi character nhận về

print("Raw temperature:", read_temperature())

while True:
    temperature = read_temperature()
    time.sleep(0.1)