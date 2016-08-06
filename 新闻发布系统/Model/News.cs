/*
 * ������:�϶���
 * ����ʱ��:2010 12-29 10:50
 * ˵��������ʵ����
 * ��Ȩ���У��϶���
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class News
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

        #region ���ű���
        private string title;
        /// <summary>
        /// ���ű���
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
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

        #region ���Ŵ���ʱ��
        private string createTime;
        /// <summary>
        /// ���Ŵ���ʱ��
        /// </summary>
        public string CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }
        #endregion

        #region ���ID
        private string caId;
        /// <summary>
        /// ���ID
        /// </summary>
        public string CaId
        {
            get { return caId; }
            set { caId = value; }
        }
        #endregion

        #region �޲������췽��
        /// <summary>
        /// �޲������췽��
        /// </summary>
        public News()
        {

        }
        #endregion

        #region ���췽��
        /// <summary>
        /// ���췽��
        /// </summary>
        /// <param name="title">���ű���</param>
        /// <param name="content">��������</param>
        /// <param name="caId">���ID</param>
        public News(string title,string content,string caId)
        {
            this.title = title;
            this.content = content;
            this.caId = caId;
        }
	    #endregion
    }
}
