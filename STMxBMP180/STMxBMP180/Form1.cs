using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STMxBMP180
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        Timer timer;
        byte currentNode = 0x05;
        private Boolean isConnect = false;
        public Form1(string username, string password, Boolean isUser)
        {
            InitializeComponent();
            // ADD comport
            string[] ports = SerialPort.GetPortNames();
            cbx_comport.Items.AddRange(ports);
            // Add baud list
            int[] baudRates = { 9600, 19200, 38400, 57600, 115200 };
            cbx_baud.Items.Clear();
            foreach (int baud in baudRates)
                cbx_baud.Items.Add(baud);

            // ==== Data bits ====
            cbx_datasize.Items.Add("7");
            cbx_datasize.Items.Add("8");
            cbx_datasize.SelectedIndex = 1; // mặc định 8

            // ==== Parity ====
            cbx_Parity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            cbx_Parity.SelectedItem = "None";
            if(isUser == true)
            {
                lbl_userStatus.Text = "Hello, " + username;
            }
            else
            {
                lbl_userStatus.Text = "Hello, guest";
            }
            lbl_DateAndTime.Text = "Date: " + DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ReadModbus(currentNode);

            // Đổi node cho lần kế tiếp
            currentNode = (currentNode == 0x05) ? (byte)0x06 : (byte)0x05;
        }

        private void ReadModbus(byte slaveAddr)
        {
            // Ví dụ gửi gói Modbus RTU: đọc thanh ghi (Function 03)
            byte funcCode = 0x04;
            byte regAddrHi = 0x00;
            byte regAddrLo = 0x00;

            byte[] frame = new byte[]
            {
                slaveAddr, funcCode,
                regAddrHi, regAddrLo,
            };

            // Tính CRC16 Modbus
            byte[] crc = ModbusCRC(frame, 4);
            byte[] packet = new byte[frame.Length + 2];
            Buffer.BlockCopy(frame, 0, packet, 0, frame.Length);
            packet[packet.Length - 2] = crc[0];
            packet[packet.Length - 1] = crc[1];

            // Gửi đi
            serialPort.Write(packet, 0, packet.Length);

            //MessageBox.Show("Đã gửi gói Modbus!");
        }

        private byte[] ModbusCRC(byte[] data, int length)
        {
            ushort crc = 0xFFFF;

            for (int pos = 0; pos < length; pos++)
            {
                crc ^= data[pos];
                for (int i = 0; i < 8; i++)
                {
                    if ((crc & 0x0001) != 0)
                    {
                        crc >>= 1;
                        crc ^= 0xA001;
                    }
                    else
                    {
                        crc >>= 1;
                    }
                }
            }

            byte[] result = new byte[2];
            result[0] = (byte)(crc & 0xFF);        // CRC Low
            result[1] = (byte)((crc >> 8) & 0xFF); // CRC High
            return result;
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int bytesToRead = serialPort.BytesToRead;
                if (bytesToRead >= 6) // Đợi đủ 6 byte của frame
                {
                    byte[] buffer = new byte[6];
                    serialPort.Read(buffer, 0, 6);

                    // Kiểm tra địa chỉ và function code (nếu cần)
                    byte slaveAddr = buffer[0];
                    byte funcCode = buffer[1];

                    // Ghép 2 byte temp
                    ushort rawValue = (ushort)((buffer[2] << 8) | buffer[3]);

                    // Kiểm tra CRC
                    byte[] crcCalc = ModbusCRC(buffer, 4); // tính CRC từ 4 byte đầu
                    
                    // Nếu crc match
                    if (crcCalc[0] == buffer[4] && crcCalc[1] == buffer[5])
                    {
                        double temp = rawValue / 10.0;

                        this.Invoke(new Action(() =>
                        {
                            if(slaveAddr == 0x06)
                            {
                                lbl_TempNode2.Text = temp.ToString("0.0") + " °C";
                            }    
                            else
                            {
                                lbl_TempNode1.Text = temp.ToString("0.0") + " °C";
                            }
                        }));
                    }
                    else
                    {
                        // CRC sai
                        this.Invoke(new Action(() =>
                        {
                            lbl_TempNode1.Text = "CRC error";
                        }));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc COM: " + ex.Message);
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if(isConnect == true)   // Disconnect
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    timer.Tick -= Timer_Tick;
                    serialPort.Close();
                    btn_connect.Text = "Connect";
                    MessageBox.Show("Disconnected!");
                }
            }    
            else
            {
                try
                {
                    string selectedPort = cbx_comport.SelectedItem.ToString();
                    int selectedBaud = int.Parse(cbx_baud.SelectedItem.ToString());

                    serialPort = new SerialPort(selectedPort, selectedBaud, Parity.None, 8, StopBits.One);
                    serialPort.DataReceived += SerialPort_DataReceived;
                    serialPort.Open();

                    btn_connect.Text = "Disconnect";

                    isConnect = true;

                    MessageBox.Show("Connected to " + selectedPort + " @ " + selectedBaud);

                    // Khởi tạo timer
                    timer = new Timer();
                    timer.Interval = 500; // 1 giây
                    timer.Tick += Timer_Tick;
                    timer.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể mở cổng: " + ex.Message);
                }
            }    
        }

        private void btn_adjust_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ trackbar (giây)
            int seconds = trackbar_SamplingRate.Value;

            // Đổi sang mili giây
            timer.Interval = seconds * 1000;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_showGraph_Click(object sender, EventArgs e)
        {
            graph f2 = new graph();
            f2.ShowDialog();
        }
    }
}
