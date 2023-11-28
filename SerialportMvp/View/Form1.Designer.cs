namespace SerialportMvp.View
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenCom = new System.Windows.Forms.Button();
            this.btnCheckCom = new System.Windows.Forms.Button();
            this.rbnHex = new System.Windows.Forms.RadioButton();
            this.rbnChar = new System.Windows.Forms.RadioButton();
            this.cbxDataBits = new System.Windows.Forms.ComboBox();
            this.cbxParity = new System.Windows.Forms.ComboBox();
            this.cbxStopBits = new System.Windows.Forms.ComboBox();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.cbxComPort = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClearData = new System.Windows.Forms.Button();
            this.btnSendData = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbxSendData = new System.Windows.Forms.TextBox();
            this.filename_test_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.RtbxRecvData = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.btnOpenCom);
            this.groupBox1.Controls.Add(this.btnCheckCom);
            this.groupBox1.Controls.Add(this.rbnHex);
            this.groupBox1.Controls.Add(this.rbnChar);
            this.groupBox1.Controls.Add(this.cbxDataBits);
            this.groupBox1.Controls.Add(this.cbxParity);
            this.groupBox1.Controls.Add(this.cbxStopBits);
            this.groupBox1.Controls.Add(this.cbxBaudRate);
            this.groupBox1.Controls.Add(this.cbxComPort);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 440);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // btnOpenCom
            // 
            this.btnOpenCom.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenCom.Location = new System.Drawing.Point(161, 286);
            this.btnOpenCom.Name = "btnOpenCom";
            this.btnOpenCom.Size = new System.Drawing.Size(124, 40);
            this.btnOpenCom.TabIndex = 13;
            this.btnOpenCom.Text = "打开串口";
            this.btnOpenCom.UseVisualStyleBackColor = true;
            this.btnOpenCom.Click += new System.EventHandler(this.btnOpenCom_Click);
            // 
            // btnCheckCom
            // 
            this.btnCheckCom.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCheckCom.Location = new System.Drawing.Point(14, 286);
            this.btnCheckCom.Name = "btnCheckCom";
            this.btnCheckCom.Size = new System.Drawing.Size(124, 40);
            this.btnCheckCom.TabIndex = 12;
            this.btnCheckCom.Text = "检测串口";
            this.btnCheckCom.UseVisualStyleBackColor = true;
            this.btnCheckCom.Click += new System.EventHandler(this.btnCheckCom_Click);
            // 
            // rbnHex
            // 
            this.rbnHex.AutoSize = true;
            this.rbnHex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbnHex.Location = new System.Drawing.Point(166, 244);
            this.rbnHex.Name = "rbnHex";
            this.rbnHex.Size = new System.Drawing.Size(100, 24);
            this.rbnHex.TabIndex = 11;
            this.rbnHex.TabStop = true;
            this.rbnHex.Text = "HEX显示";
            this.rbnHex.UseVisualStyleBackColor = true;
            // 
            // rbnChar
            // 
            this.rbnChar.AutoSize = true;
            this.rbnChar.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbnChar.Location = new System.Drawing.Point(18, 245);
            this.rbnChar.Name = "rbnChar";
            this.rbnChar.Size = new System.Drawing.Size(110, 24);
            this.rbnChar.TabIndex = 10;
            this.rbnChar.TabStop = true;
            this.rbnChar.Text = "字符显示";
            this.rbnChar.UseVisualStyleBackColor = true;
            // 
            // cbxDataBits
            // 
            this.cbxDataBits.FormattingEnabled = true;
            this.cbxDataBits.Location = new System.Drawing.Point(131, 196);
            this.cbxDataBits.Name = "cbxDataBits";
            this.cbxDataBits.Size = new System.Drawing.Size(121, 23);
            this.cbxDataBits.TabIndex = 9;
            // 
            // cbxParity
            // 
            this.cbxParity.FormattingEnabled = true;
            this.cbxParity.Location = new System.Drawing.Point(131, 154);
            this.cbxParity.Name = "cbxParity";
            this.cbxParity.Size = new System.Drawing.Size(121, 23);
            this.cbxParity.TabIndex = 8;
            // 
            // cbxStopBits
            // 
            this.cbxStopBits.FormattingEnabled = true;
            this.cbxStopBits.Location = new System.Drawing.Point(131, 114);
            this.cbxStopBits.Name = "cbxStopBits";
            this.cbxStopBits.Size = new System.Drawing.Size(121, 23);
            this.cbxStopBits.TabIndex = 7;
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Location = new System.Drawing.Point(130, 76);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(121, 23);
            this.cbxBaudRate.TabIndex = 6;
            // 
            // cbxComPort
            // 
            this.cbxComPort.FormattingEnabled = true;
            this.cbxComPort.Location = new System.Drawing.Point(130, 35);
            this.cbxComPort.Name = "cbxComPort";
            this.cbxComPort.Size = new System.Drawing.Size(121, 23);
            this.cbxComPort.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(28, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "数据位：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(8, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "奇偶校验：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(29, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "停止位：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(30, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口号：";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.RtbxRecvData);
            this.groupBox2.Location = new System.Drawing.Point(324, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 440);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收数据";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.btnClearData);
            this.groupBox3.Controls.Add(this.btnSendData);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.tbxSendData);
            this.groupBox3.Controls.Add(this.filename_test_box);
            this.groupBox3.Location = new System.Drawing.Point(12, 458);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1038, 225);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送数据";
            // 
            // btnClearData
            // 
            this.btnClearData.BackColor = System.Drawing.Color.LightGray;
            this.btnClearData.Location = new System.Drawing.Point(904, 172);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(128, 36);
            this.btnClearData.TabIndex = 5;
            this.btnClearData.Text = "清空数据";
            this.btnClearData.UseVisualStyleBackColor = false;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.BackColor = System.Drawing.Color.LightGray;
            this.btnSendData.Location = new System.Drawing.Point(904, 120);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(128, 36);
            this.btnSendData.TabIndex = 4;
            this.btnSendData.Text = "发送数据";
            this.btnSendData.UseVisualStyleBackColor = false;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(903, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "选择文件";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // tbxSendData
            // 
            this.tbxSendData.Location = new System.Drawing.Point(6, 117);
            this.tbxSendData.Multiline = true;
            this.tbxSendData.Name = "tbxSendData";
            this.tbxSendData.Size = new System.Drawing.Size(892, 102);
            this.tbxSendData.TabIndex = 1;
            // 
            // filename_test_box
            // 
            this.filename_test_box.Location = new System.Drawing.Point(6, 17);
            this.filename_test_box.Multiline = true;
            this.filename_test_box.Name = "filename_test_box";
            this.filename_test_box.Size = new System.Drawing.Size(892, 94);
            this.filename_test_box.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(915, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "发送文件";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // RtbxRecvData
            // 
            this.RtbxRecvData.Location = new System.Drawing.Point(6, 17);
            this.RtbxRecvData.Name = "RtbxRecvData";
            this.RtbxRecvData.Size = new System.Drawing.Size(712, 417);
            this.RtbxRecvData.TabIndex = 1;
            this.RtbxRecvData.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 689);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "串口助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxDataBits;
        private System.Windows.Forms.ComboBox cbxParity;
        private System.Windows.Forms.ComboBox cbxStopBits;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.ComboBox cbxComPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbnHex;
        private System.Windows.Forms.RadioButton rbnChar;
        private System.Windows.Forms.TextBox filename_test_box;
        private System.Windows.Forms.TextBox tbxSendData;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOpenCom;
        private System.Windows.Forms.Button btnCheckCom;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RichTextBox RtbxRecvData;
    }
}