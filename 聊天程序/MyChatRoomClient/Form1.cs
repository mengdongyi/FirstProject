using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;


namespace MyChatRoomClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(ReceiveServerSocketMsg);
            thread.IsBackground = true;
            thread.Start();
        }

        private void ReceiveServerSocketMsg()
        {
            IPAddress address = IPAddress.Parse(txtIP.Text.Trim());
            IPEndPoint endPoint = new IPEndPoint(address, Convert.ToInt32(txtPort.Text.Trim()));
            Socket socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socketClient.Connect(endPoint);
            byte[] byteMsg = new byte[1024 * 1024];
            while (true)
            {
                int length = socketClient.Receive(byteMsg);
                string strMsg = Encoding.UTF8.GetString(byteMsg, 0, length);
                txtMsg.AppendText(strMsg + "\r\n");
            }
        }
    }
}
