using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyChatRoomServer
{
    /// <summary>
    /// 请求报文实体类
    /// </summary>
    public class HttpRequestModel
    {
        public HttpRequestModel(string msg)
        {
            string[] strArray = msg.Split('\r', '\n');
            string firstRow = strArray[0];
            Path = firstRow.Split(' ')[1];
        }

        /// <summary>
        /// 请求文件的路径
        /// </summary>
        public string Path { get; set; }
    }

}
