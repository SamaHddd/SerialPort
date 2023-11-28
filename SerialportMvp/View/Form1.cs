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

namespace SerialportMvp.View
{
    public partial class Form1 : Form
    {
         
        
        public EventHandler<EventArgs> CheckCom;
        public EventHandler<EventArgs> Form1Load;
        public EventHandler<EventArgs> OpenCom;
        public EventHandler<EventArgs> SendData;
        public EventHandler<EventArgs> CleanData;
        public EventHandler<SerialDataReceivedEventArgs> SerialDataReceived;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckCom_Click(object sender, EventArgs e)
        {
            CheckCom?.Invoke(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1Load?.Invoke(sender, e);
        }

        public void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            SerialDataReceived?.Invoke(sender, e);
        }

        private void btnOpenCom_Click(object sender, EventArgs e)
        {
            OpenCom?.Invoke(this, e); 
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            SendData?.Invoke(this, e);
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            CleanData?.Invoke(this, e);
        }
    }
}
