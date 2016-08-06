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

namespace MyChatRoomServer
{
    //定义一个在当前窗体的文本框中显示信息的委托
    public delegate void DgShowMsg(string msg);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //去掉TextBox的跨线程检查,防止跨线程访问出现异常
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            //创建通讯线程
            Thread socketThread = new Thread(ListenClientSocket);
            //设置为后台线程
            socketThread.IsBackground = true;
            //启动线程
            socketThread.Start();
        }


        #region 监听客户端的请求
        /// <summary>
        /// 监听客户端的请求
        /// </summary>
        private void ListenClientSocket()
        {
            //创建服务端负责监听的套接字，使用IP4寻址协议，使用流式连接，使用tcp协议传输数据
            Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //获得IP地址
            IPAddress address = IPAddress.Parse(txtIP.Text.Trim());
            //创建包含ip和port的网络节点对象
            IPEndPoint endPoint = new IPEndPoint(address, Convert.ToInt32(txtPort.Text));
            //将负责监听的套接字绑到唯一的IP和端口上
            socketWatch.Bind(endPoint);
            //设置监听队列的长度
            socketWatch.Listen(10);
            //开始监听客户端请求，注意Accept方法会阻塞当前线程,使用多线程技术解决
            //通过while循环不断的监听客户端的socket请求
            while (true)
            {
                //创建新的数据通信套接字
                Socket socketConn = socketWatch.Accept();
                //创建数据通信类
                DataConnection dataConnection = new DataConnection(socketConn, ShowMessage);
                ShowMessage("客户端连接成功!");
            }
        } 
        #endregion


        private void ShowMessage(string msg)
        {
            txtMessage.AppendText(msg+"\r\n");
        }
    }
}
