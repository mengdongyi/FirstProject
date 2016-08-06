using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace MyChatRoomServer
{
    /// <summary>
    /// 数据通信类
    /// </summary>
    public class DataConnection
    {
        Socket socketConn = null;
        DgShowMsg dgShowMsg = null;
        public DataConnection(Socket socketConn,DgShowMsg dgShowMsg)
        {
            //初始化成员变量
            this.socketConn = socketConn;
            this.dgShowMsg = dgShowMsg;

            //创建用于接受浏览器请求的线程
            Thread thread = new Thread(ReceiveClientSocket);
            thread.IsBackground = true;
            thread.Start();
        }

        #region 接受浏览器发送的http请求报文信息
        /// <summary>
        /// 接受浏览器发送的http请求报文信息
        /// </summary>
        public void ReceiveClientSocket()
        {
            //创建一个1M缓冲区用来存放浏览器的请求报文信息
            byte[] byteMsg = new byte[1024 * 1024];
            //将浏览器的请求报文信息填充到缓冲区红
            int length = socketConn.Receive(byteMsg);
            //将缓冲区的数据转换成字符串
            string msg = Encoding.UTF8.GetString(byteMsg, 0, length);
            //创建请求报文实体类
            HttpRequestModel model = new HttpRequestModel(msg);
            OperExtension(model);
            dgShowMsg(msg);
        } 
        #endregion

        #region 操作请求文件的后缀名
        /// <summary>
        /// 操作请求文件的后缀名
        /// </summary>
        /// <param name="model"></param>
        public void OperExtension(HttpRequestModel model)
        {
            //获取当前应用程序与的目录
            string dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"\bin\Debug\") || dataDir.EndsWith(@"\bin\Release\"))
            {
                dataDir = Directory.GetParent(dataDir).Parent.Parent.FullName;
            }
            string fileDir = dataDir + model.Path;
            //获取请求的后缀名
            string extenionName = Path.GetExtension(model.Path);
            switch (extenionName)
            {
                case ".htm":
                case ".jpg":
                case ".jpeg":
                case ".png":
                case ".gif":
                    ProcessStaticPage(fileDir);
                    break;
            }
        } 
        #endregion

        #region 处理静态页面
        /// <summary>
        /// 处理静态页面
        /// </summary>
        /// <param name="fileDir"></param>
        private void ProcessStaticPage(string fileDir)
        {
            byte[] arrFile = null;
            using (FileStream fs = new FileStream(fileDir, FileMode.Open))
            {
                arrFile = new byte[fs.Length];
                fs.Read(arrFile, 0, arrFile.Length);
            }
            //构造响应报文实体类
            HttpResponseModel model = new HttpResponseModel(arrFile, Path.GetExtension(fileDir));
            //服务器响应报文头信息
            socketConn.Send(model.GetResponseHeader());
            //服务器响应报文体信息
            socketConn.Send(arrFile);
        } 
        #endregion
    }
}
