using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyChatRoomServer
{
    /// <summary>
    /// 响应报文实体类
    /// </summary>
    public class HttpResponseModel
    {
        byte[] arrFile = null;
        public HttpResponseModel(byte[] arrFile, string extensionPath)
        {
            this.arrFile = arrFile;
            switch (extensionPath)
            {
                case ".htm":
                    ContentType = "text/html";
                    break;
                case ".jpeg":
                case ".jpg":
                    ContentType = "image/jpeg";
                    break;
            }
        }
        /// <summary>
        /// 响应内容的类型
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// 获取响应报文头信息
        /// </summary>
        /// <returns></returns>
        public byte[] GetResponseHeader()
        {
            string responseHeader = "HTTP/1.1 200 OK\r\nContent-Type:"+ContentType+"\r\n";
            responseHeader += "Content-Length:"+arrFile.Length+"\r\n\r\n";
            byte[] byteResHeader = Encoding.UTF8.GetBytes(responseHeader);
            return byteResHeader;
        }
    }
}
