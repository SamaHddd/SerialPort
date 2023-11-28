using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialportMvp.View;

namespace SerialportMvp.Presenter
{
    internal class SerialportPersenter
    {

        bool isHex = false;
        bool isOpen = false;
        bool isSetProperty = false;
        bool isfiletranfers = false;
        SerialPort serialportcom = null;
        public Form1 _form1;
       
        public SerialportPersenter(Form1 form1)
        {
            _form1=form1;

            form1.CheckCom += new EventHandler<EventArgs>(OnCheckCom);
            form1.Form1Load += new EventHandler<EventArgs>(OnForm1Loda);
            form1.OpenCom+= new EventHandler<EventArgs>(OnOpenCom);
            form1.SendData += new EventHandler<EventArgs>(OnSendData);
            form1.CleanData += new EventHandler<EventArgs>(OnCleanData);
            form1.SerialDataReceived += new EventHandler<SerialDataReceivedEventArgs>(OnSerialDataReceived);


        }

        private void OnSerialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RichTextBox RtbxRecvData = (RichTextBox)(this._form1.Controls.Find("RtbxRecvData", true)[0]);
            System.Threading.Thread.Sleep(100); //延时100ms，等待接收完数据
            //MessageBox.Show("收到数据");
            _form1.BeginInvoke((EventHandler)(delegate    //this.Invoke是跨线程访问ui的方法，也是文本的范例
            {
                try
                {
                    if (isHex == false)
                    {
                        RtbxRecvData.Text += "正在接收数据...." + "\r\n";
                        byte[] a = new byte[serialportcom.BytesToRead];//创建一个缓冲区数据大小的字节空间
                        serialportcom.Read(a, 0, a.Length);    //读取缓冲区的数据，并将其写入a的空间中
                        string recvstring = Encoding.Default.GetString(a);//解码出a中的字符信息
                        RtbxRecvData.Text += recvstring + "\r\n";
                    }
                    else
                    {
                        Byte[] ReceivedData = new Byte[serialportcom.BytesToRead];    //定义并初始化字符数组，sp.ByteToRead串口读字符串长度
                        serialportcom.Read(ReceivedData, 0, ReceivedData.Length);    //字符数组读取串口数据
                        String RecvDataText = null;    //定义字符串
                        for (int i = 0; i < ReceivedData.Length; i++)
                        {
                            RecvDataText += ("0X" + ReceivedData[i].ToString("X2") + " ");    //串口接收字符数组，字符依次转换为字符串，0Xxx
                                                                                   
                        }
                        RtbxRecvData.Text += RecvDataText;     //转换后的字符串显示到tbxRecvData上面
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("数据接受失败");
                }

                serialportcom.DiscardInBuffer();    //清除串口接收缓冲区数据
            }));

        }

        private void OnCleanData(object sender, EventArgs e)
        {
            RichTextBox RtbxRecvData = (RichTextBox)(this._form1.Controls.Find("RtbxRecvData", true)[0]);
            TextBox tbxSendData = (TextBox)(this._form1.Controls.Find("tbxSendData", true)[0]);
            RtbxRecvData.Text = "";
            tbxSendData.Text = "";
        }

        private void OnSendData(object sender, EventArgs e)
        {
            RichTextBox RtbxRecvData = (RichTextBox)(this._form1.Controls.Find("RtbxRecvData", true)[0]);
            TextBox tbxSendData = (TextBox)(this._form1.Controls.Find("tbxSendData", true)[0]);
            if (isOpen)    //串口打开状态
            {
                try
                {
                    Encoding sendData = System.Text.Encoding.GetEncoding(936);//使用合适字符编码，936表示GB2312
                    byte[] bytesSD = Encoding.Default.GetBytes(tbxSendData.Text + "\r\n");//创建字节空间，并写入待传输数据
                    RtbxRecvData.Text += tbxSendData.Text + "\r\n";
                    serialportcom.Write(bytesSD, 0, bytesSD.Length);    //串口发送数据
                    RtbxRecvData.Text += "发送成功" + "\r\n";
                }
                catch
                {
                    MessageBox.Show("发送数据时发生错误！", "错误提示");
                    return;
                }
            }
            else
            {
                MessageBox.Show("串口未打开", "错误提示");
            }
            if (!CheckSendData())
            {
                MessageBox.Show("请输入要发送的数据", "错误提示");
            }

        }

        private void OnOpenCom(object sender, EventArgs e)
        {
            ComboBox cbxParity = (ComboBox)(this._form1.Controls.Find("cbxParity", true)[0]);
            ComboBox cbxBaudRate = (ComboBox)(this._form1.Controls.Find("cbxBaudRate", true)[0]);
            ComboBox cbxStopBits = (ComboBox)(this._form1.Controls.Find("cbxStopBits", true)[0]);
            ComboBox cbxDataBits = (ComboBox)(this._form1.Controls.Find("cbxDataBits", true)[0]);
            RadioButton rbnChar = (RadioButton)(this._form1.Controls.Find("rbnChar", true)[0]);
            ComboBox cbxComPort = (ComboBox)(this._form1.Controls.Find("cbxComPort", true)[0]);
            RadioButton rbnHex = (RadioButton)(this._form1.Controls.Find("rbnHex", true)[0]);
            Button btnOpenCom = (Button)(this._form1.Controls.Find("btnOpenCom", true)[0]);
            Button btnCheckCom = (Button)(this._form1.Controls.Find("btnCheckCom", true)[0]);
            if (isOpen == false)
            {
                if (!checkPortSetting())//检测串口设置
                {
                    MessageBox.Show("串口未设置", "错误提示");
                    return;
                }
                if (!isSetProperty)
                {
                    SetPortProperty();
                    isSetProperty = true;
                }
                try
                {
                    serialportcom.Open();
                    isOpen = true;
                    btnOpenCom.Text = "关闭串口";
                    //串口打开后，相关的串口设置按钮不再可用
                    cbxComPort.Enabled = false;
                    cbxBaudRate.Enabled = false;
                    cbxDataBits.Enabled = false;
                    cbxStopBits.Enabled = false;
                    cbxParity.Enabled = false;
                    rbnChar.Enabled = false;
                    rbnHex.Enabled = false;
                    btnCheckCom.Enabled = false;
                }
                catch (Exception)
                {
                    isSetProperty = false;//串口设置标志位设置为false
                    isOpen = false; //串口打开标志位设置为false
                    MessageBox.Show("串口无效或被占用", "错误提示");//打开失败提示消息框
                }
            }
            else//之前串口是打开的，则执行else语句块
            {
                try
                {
                    serialportcom.Close();//关闭串口
                    isOpen = false;    //串口打开标志位设置为false
                    btnOpenCom.Text = "打开串口";    //btnOpenCom的文本设置为“打开串口”
                    cbxComPort.Enabled = true;    //串口号使能
                    cbxBaudRate.Enabled = true;    //波特率
                    cbxDataBits.Enabled = true;    //数据位
                    cbxStopBits.Enabled = true;    //停止位
                    cbxParity.Enabled = true;    //校验
                    rbnChar.Enabled = true;    //字符型
                    rbnHex.Enabled = true;    //Hex型
                    btnCheckCom.Enabled = true;//检测串口
                }
                catch (Exception)
                {
                    MessageBox.Show("关闭串口时发生错误", "错误提示");    //关闭失败提示消息框

                }
            }
        }

        private void OnForm1Loda(object sender, EventArgs e)
        {
            ComboBox cbxParity = (ComboBox)(this._form1.Controls.Find("cbxParity", true)[0]);
            ComboBox cbxBaudRate = (ComboBox)(this._form1.Controls.Find("cbxBaudRate", true)[0]);
            ComboBox cbxStopBits = (ComboBox)(this._form1.Controls.Find("cbxStopBits", true)[0]);
            ComboBox cbxDataBits = (ComboBox)(this._form1.Controls.Find("cbxDataBits", true)[0]);
            RadioButton rbnChar = (RadioButton)(this._form1.Controls.Find("rbnChar", true)[0]);
            _form1.MaximizeBox = true;
            _form1.MaximumSize = _form1.Size;
            _form1.MinimumSize = _form1.Size;

            cbxBaudRate.Items.Add("1200");
            cbxBaudRate.Items.Add("2400");
            cbxBaudRate.Items.Add("4800");
            cbxBaudRate.Items.Add("9600");
            cbxBaudRate.Items.Add("19200");
            cbxBaudRate.Items.Add("38400");
            cbxBaudRate.Items.Add("115200");
            cbxBaudRate.SelectedIndex = 3;
            //列出停止位
            cbxStopBits.Items.Add("0");
            cbxStopBits.Items.Add("1");
            cbxStopBits.Items.Add("1.5");
            cbxStopBits.Items.Add("2");
            cbxStopBits.SelectedIndex = 1;
            //列出数据位
            cbxDataBits.Items.Add("8");
            cbxDataBits.Items.Add("7");
            cbxDataBits.Items.Add("6");
            cbxDataBits.Items.Add("5");
            cbxDataBits.SelectedIndex = 0;
            //列出奇偶检验
            cbxParity.Items.Add("无");
            cbxParity.Items.Add("奇校验");
            cbxParity.Items.Add("偶校验");
            cbxParity.SelectedIndex = 0;
            
            rbnChar.Checked = true;
        }

        private void OnCheckCom(object sender, EventArgs e)
        {
            bool comExistence=false;
            ComboBox cbxComPort = (ComboBox)(this._form1.Controls.Find("cbxComPort", true)[0]);
            cbxComPort.Items.Clear();
            foreach (string sPortName in SerialPort.GetPortNames())
            {
                try
                {
                    cbxComPort.Items.Add(sPortName);
                    comExistence = true;
                }
                catch (Exception)
                {
                    continue;
                }
            }
            if (comExistence)
            { 
                cbxComPort.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("没有找到可用的串口！", "错误提示");
            }
        }
        private bool checkPortSetting()
        {
            ComboBox cbxParity = (ComboBox)(this._form1.Controls.Find("cbxParity", true)[0]);
            ComboBox cbxBaudRate = (ComboBox)(this._form1.Controls.Find("cbxBaudRate", true)[0]);
            ComboBox cbxStopBits = (ComboBox)(this._form1.Controls.Find("cbxStopBits", true)[0]);
            ComboBox cbxDataBits = (ComboBox)(this._form1.Controls.Find("cbxDataBits", true)[0]);
            ComboBox cbxComPort = (ComboBox)(this._form1.Controls.Find("cbxComPort", true)[0]);
            if (cbxComPort.Text.Trim()=="")
            {
                return false;
            }
            if (cbxParity.Text.Trim() == "")
            {
                return false;
            }
            if (cbxBaudRate.Text.Trim() == "")
            {
                return false;
            }
            if (cbxStopBits.Text.Trim() == "")
            {
                return false;
            }
            if (cbxDataBits.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }
        private bool CheckSendData()
        {
            TextBox tbxSendData = (TextBox)(this._form1.Controls.Find("tbxSendData", true)[0]);
            if (tbxSendData.Text.Trim()=="")
            {
                return false;
            }
            return true;
        }
        private bool CheckFileSendData()
        {
            TextBox filename_test_box = (TextBox)(this._form1.Controls.Find("filename_test_box", true)[0]);
            if (filename_test_box.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }
        private void SetPortProperty()//设置串口的属性
        {
            ComboBox cbxParity = (ComboBox)(this._form1.Controls.Find("cbxParity", true)[0]);
            ComboBox cbxBaudRate = (ComboBox)(this._form1.Controls.Find("cbxBaudRate", true)[0]);
            ComboBox cbxStopBits = (ComboBox)(this._form1.Controls.Find("cbxStopBits", true)[0]);
            ComboBox cbxDataBits = (ComboBox)(this._form1.Controls.Find("cbxDataBits", true)[0]);
            ComboBox cbxComPort = (ComboBox)(this._form1.Controls.Find("cbxComPort", true)[0]);
            RadioButton rbnChar = (RadioButton)(this._form1.Controls.Find("rbnChar", true)[0]);
            RadioButton rbnHex = (RadioButton)(this._form1.Controls.Find("rbnHex", true)[0]);
            //创建串口
            serialportcom=new SerialPort();
            //设置串口名
            serialportcom.PortName = cbxComPort.Text.Trim();
            //设置串口波特率
            serialportcom.BaudRate = Convert.ToInt32(cbxBaudRate.Text.Trim());
            //设置串口数据位
            serialportcom.DataBits = Convert.ToInt32(cbxDataBits.Text.Trim());
            //设置串口停止位
            if (cbxStopBits.Text.Trim() == "0")
            {
                serialportcom.StopBits = StopBits.None;
            }
            if (cbxStopBits.Text.Trim() == "1")
            {
                serialportcom.StopBits = StopBits.One;
            }
            if (cbxStopBits.Text.Trim() == "1.5")
            {
                serialportcom.StopBits = StopBits.OnePointFive;
            }
            if (cbxStopBits.Text.Trim() == "2")
            {
                serialportcom.StopBits = StopBits.Two;
            }
            //设置校验
            if (cbxParity.Text.Trim() == "无")
            {
                serialportcom.Parity = Parity.None;
            }
            if (cbxParity.Text.Trim() == "奇校验")
            {
                serialportcom.Parity = Parity.Odd;
            }
            if (cbxParity.Text.Trim() == "偶校验")
            {
                serialportcom.Parity = Parity.Even;
            }
            serialportcom.ReadTimeout = 100000;//设置超时读取时间
            serialportcom.RtsEnable = true;
            serialportcom.DataReceived += new SerialDataReceivedEventHandler(_form1.serialPort1_DataReceived);

            if (rbnHex.Checked)
            {
                isHex = true;
            }
            else
            {
                isHex = false;
            }
        }

        
    }

   
}
