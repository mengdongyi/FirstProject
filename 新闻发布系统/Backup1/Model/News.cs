/*
 * 创建人:孟冬伊
 * 创建时间:2008 12-29 10:50
 * 说明：新闻实体类
 * 版权所有：孟冬伊
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class News
    {
        #region 新闻ID
        private string id;
        /// <summary>
        /// 新闻ID
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        #region 新闻标题
        private string title;
        /// <summary>
        /// 新闻标题
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        #endregion

        #region 新闻内容
        private string content;
        /// <summary>
        /// 新闻内容
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        #endregion

        #region 新闻创建时间
        private string createTime;
        /// <summary>
        /// 新闻创建时间
        /// </summary>
        public string CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }
        #endregion

        #region 类别ID
        private string caId;
        /// <summary>
        /// 类别ID
        /// </summary>
        public string CaId
        {
            get { return caId; }
            set { caId = value; }
        }
        #endregion

        #region 无参数构造方法
        /// <summary>
        /// 无参数构造方法
        /// </summary>
        public News()
        {

        }
        #endregion

        #region 构造方法
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="title">新闻标题</param>
        /// <param name="content">新闻内容</param>
        /// <param name="caId">类别ID</param>
        public News(string title,string content,string caId)
        {
            this.title = title;
            this.content = content;
            this.caId = caId;
        }
	    #endregion
    }
}
