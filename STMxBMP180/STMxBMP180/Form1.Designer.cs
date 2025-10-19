
namespace STMxBMP180
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_showGraph = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_Parity = new System.Windows.Forms.ComboBox();
            this.cbx_datasize = new System.Windows.Forms.ComboBox();
            this.cbx_baud = new System.Windows.Forms.ComboBox();
            this.cbx_comport = new System.Windows.Forms.ComboBox();
            this.lbl_userStatus = new System.Windows.Forms.Label();
            this.lbl_DateAndTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_adjust = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_lightIntenseHeader = new System.Windows.Forms.Label();
            this.trackbar_SamplingRate = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_TempNode1 = new System.Windows.Forms.Label();
            this.lbl_PressHeader = new System.Windows.Forms.Label();
            this.lbl_illuHeader = new System.Windows.Forms.Label();
            this.lbl_TempNode2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_SamplingRate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(518, 469);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 457);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(127, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.panel4.Controls.Add(this.btn_about);
            this.panel4.Controls.Add(this.btn_connect);
            this.panel4.Controls.Add(this.btn_showGraph);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cbx_Parity);
            this.panel4.Controls.Add(this.cbx_datasize);
            this.panel4.Controls.Add(this.cbx_baud);
            this.panel4.Controls.Add(this.cbx_comport);
            this.panel4.Location = new System.Drawing.Point(450, 136);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 288);
            this.panel4.TabIndex = 31;
            // 
            // btn_about
            // 
            this.btn_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_about.Location = new System.Drawing.Point(129, 235);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(139, 35);
            this.btn_about.TabIndex = 24;
            this.btn_about.Text = "About the author";
            this.btn_about.UseVisualStyleBackColor = true;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(18, 184);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(250, 36);
            this.btn_connect.TabIndex = 37;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_showGraph
            // 
            this.btn_showGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_showGraph.Location = new System.Drawing.Point(18, 235);
            this.btn_showGraph.Name = "btn_showGraph";
            this.btn_showGraph.Size = new System.Drawing.Size(105, 35);
            this.btn_showGraph.TabIndex = 23;
            this.btn_showGraph.Text = "Show Graph";
            this.btn_showGraph.UseVisualStyleBackColor = true;
            this.btn_showGraph.Click += new System.EventHandler(this.btn_showGraph_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label10.Location = new System.Drawing.Point(18, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 26);
            this.label10.TabIndex = 36;
            this.label10.Text = "Parity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label9.Location = new System.Drawing.Point(18, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 26);
            this.label9.TabIndex = 36;
            this.label9.Text = "Data Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(18, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 26);
            this.label5.TabIndex = 36;
            this.label5.Text = "Baudrate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 35;
            this.label1.Text = "COM Port";
            // 
            // cbx_Parity
            // 
            this.cbx_Parity.FormattingEnabled = true;
            this.cbx_Parity.Location = new System.Drawing.Point(147, 149);
            this.cbx_Parity.Name = "cbx_Parity";
            this.cbx_Parity.Size = new System.Drawing.Size(121, 24);
            this.cbx_Parity.TabIndex = 35;
            // 
            // cbx_datasize
            // 
            this.cbx_datasize.FormattingEnabled = true;
            this.cbx_datasize.Location = new System.Drawing.Point(147, 106);
            this.cbx_datasize.Name = "cbx_datasize";
            this.cbx_datasize.Size = new System.Drawing.Size(121, 24);
            this.cbx_datasize.TabIndex = 35;
            // 
            // cbx_baud
            // 
            this.cbx_baud.FormattingEnabled = true;
            this.cbx_baud.Location = new System.Drawing.Point(147, 59);
            this.cbx_baud.Name = "cbx_baud";
            this.cbx_baud.Size = new System.Drawing.Size(121, 24);
            this.cbx_baud.TabIndex = 35;
            // 
            // cbx_comport
            // 
            this.cbx_comport.FormattingEnabled = true;
            this.cbx_comport.Location = new System.Drawing.Point(147, 15);
            this.cbx_comport.Name = "cbx_comport";
            this.cbx_comport.Size = new System.Drawing.Size(121, 24);
            this.cbx_comport.TabIndex = 35;
            // 
            // lbl_userStatus
            // 
            this.lbl_userStatus.AutoSize = true;
            this.lbl_userStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbl_userStatus.Location = new System.Drawing.Point(82, 469);
            this.lbl_userStatus.Name = "lbl_userStatus";
            this.lbl_userStatus.Size = new System.Drawing.Size(109, 26);
            this.lbl_userStatus.TabIndex = 30;
            this.lbl_userStatus.Text = "Hi, Duong";
            // 
            // lbl_DateAndTime
            // 
            this.lbl_DateAndTime.AutoSize = true;
            this.lbl_DateAndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbl_DateAndTime.Location = new System.Drawing.Point(574, 478);
            this.lbl_DateAndTime.Name = "lbl_DateAndTime";
            this.lbl_DateAndTime.Size = new System.Drawing.Size(148, 26);
            this.lbl_DateAndTime.TabIndex = 28;
            this.lbl_DateAndTime.Text = "Date and time";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_adjust);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbl_lightIntenseHeader);
            this.panel2.Controls.Add(this.trackbar_SamplingRate);
            this.panel2.Location = new System.Drawing.Point(40, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 104);
            this.panel2.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(15, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "1";
            // 
            // btn_adjust
            // 
            this.btn_adjust.Location = new System.Drawing.Point(281, 43);
            this.btn_adjust.Name = "btn_adjust";
            this.btn_adjust.Size = new System.Drawing.Size(103, 40);
            this.btn_adjust.TabIndex = 18;
            this.btn_adjust.Text = "Adjust";
            this.btn_adjust.UseVisualStyleBackColor = true;
            this.btn_adjust.Click += new System.EventHandler(this.btn_adjust_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(201, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "5 (s)";
            // 
            // lbl_lightIntenseHeader
            // 
            this.lbl_lightIntenseHeader.AutoSize = true;
            this.lbl_lightIntenseHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_lightIntenseHeader.Location = new System.Drawing.Point(26, 9);
            this.lbl_lightIntenseHeader.Name = "lbl_lightIntenseHeader";
            this.lbl_lightIntenseHeader.Size = new System.Drawing.Size(180, 29);
            this.lbl_lightIntenseHeader.TabIndex = 9;
            this.lbl_lightIntenseHeader.Text = "Sampling Rate";
            // 
            // trackbar_SamplingRate
            // 
            this.trackbar_SamplingRate.Location = new System.Drawing.Point(31, 51);
            this.trackbar_SamplingRate.Maximum = 5;
            this.trackbar_SamplingRate.Minimum = 1;
            this.trackbar_SamplingRate.Name = "trackbar_SamplingRate";
            this.trackbar_SamplingRate.Size = new System.Drawing.Size(164, 56);
            this.trackbar_SamplingRate.TabIndex = 8;
            this.trackbar_SamplingRate.Value = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_TempNode1);
            this.panel1.Controls.Add(this.lbl_PressHeader);
            this.panel1.Controls.Add(this.lbl_illuHeader);
            this.panel1.Controls.Add(this.lbl_TempNode2);
            this.panel1.Location = new System.Drawing.Point(40, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 159);
            this.panel1.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(241, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 29);
            this.label8.TabIndex = 9;
            this.label8.Text = "NODE 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(49, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "NODE 1";
            // 
            // lbl_TempNode1
            // 
            this.lbl_TempNode1.AutoSize = true;
            this.lbl_TempNode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_TempNode1.Location = new System.Drawing.Point(47, 92);
            this.lbl_TempNode1.Name = "lbl_TempNode1";
            this.lbl_TempNode1.Size = new System.Drawing.Size(55, 39);
            this.lbl_TempNode1.TabIndex = 1;
            this.lbl_TempNode1.Text = "30";
            // 
            // lbl_PressHeader
            // 
            this.lbl_PressHeader.AutoSize = true;
            this.lbl_PressHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_PressHeader.Location = new System.Drawing.Point(15, 54);
            this.lbl_PressHeader.Name = "lbl_PressHeader";
            this.lbl_PressHeader.Size = new System.Drawing.Size(157, 29);
            this.lbl_PressHeader.TabIndex = 5;
            this.lbl_PressHeader.Text = "Temperature";
            // 
            // lbl_illuHeader
            // 
            this.lbl_illuHeader.AutoSize = true;
            this.lbl_illuHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_illuHeader.Location = new System.Drawing.Point(210, 54);
            this.lbl_illuHeader.Name = "lbl_illuHeader";
            this.lbl_illuHeader.Size = new System.Drawing.Size(157, 29);
            this.lbl_illuHeader.TabIndex = 7;
            this.lbl_illuHeader.Text = "Temperature";
            // 
            // lbl_TempNode2
            // 
            this.lbl_TempNode2.AutoSize = true;
            this.lbl_TempNode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_TempNode2.Location = new System.Drawing.Point(246, 92);
            this.lbl_TempNode2.Name = "lbl_TempNode2";
            this.lbl_TempNode2.Size = new System.Drawing.Size(55, 39);
            this.lbl_TempNode2.TabIndex = 3;
            this.lbl_TempNode2.Text = "30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(241, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Temperature Monitoring System";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 528);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lbl_userStatus);
            this.Controls.Add(this.lbl_DateAndTime);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Temp Monitoring System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_SamplingRate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_showGraph;
        private System.Windows.Forms.Label lbl_userStatus;
        private System.Windows.Forms.Label lbl_DateAndTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_lightIntenseHeader;
        private System.Windows.Forms.TrackBar trackbar_SamplingRate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TempNode1;
        private System.Windows.Forms.Label lbl_PressHeader;
        private System.Windows.Forms.Label lbl_illuHeader;
        private System.Windows.Forms.Label lbl_TempNode2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_Parity;
        private System.Windows.Forms.ComboBox cbx_datasize;
        private System.Windows.Forms.ComboBox cbx_baud;
        private System.Windows.Forms.ComboBox cbx_comport;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_adjust;
        private System.Windows.Forms.Label label3;
    }
}

