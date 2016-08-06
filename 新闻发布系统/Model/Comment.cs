/*
 * ������:�϶���
 * ����ʱ��:2010 12-29 9:50
 * ˵������������ʵ����
 * ��Ȩ���У��϶���
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Comment
    {
        #region ����ID
        private string id;
        /// <summary>
        /// ����ID
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        #region ��������
        private string content;
        /// <summary>
        /// ��������
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        #endregion

        #region ����ʱ��
        private string createTime;
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public string CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }
        #endregion

        #region �û�IP
        private string userIp;
        /// <summary>
        /// �û�IP
        /// </summary>
        public string UserIp
        {
            get { return userIp; }
            set { userIp = value; }
        }
        #endregion

        #region ����ID
        private string newsId;
        /// <summary>
        /// ����ID
        /// </summary>
        public string NewsId
        {
            get { return newsId; }
            set { newsId = value; }
        }
        #endregion

        #region �޲������췽��
        /// <summary>
        /// �޲������췽��
        /// </summary>
        public Comment()
        {

        }
        #endregion

        #region ���췽��
        /// <summary>
        /// ���췽��
        /// </summary>
        /// <param name="content">��������</param>
        /// <param name="userIp">�û�IP</param>
        /// <param name="newsId">����ID</param>
        public Comment(string content,string userIp,string newsId)
        {
            this.content = content;
            this.userIp = userIp;
            this.newsId = newsId;
        }
	    #endregion
    }
}
