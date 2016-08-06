/*
 * 创建人:孟冬伊
 * 创建时间:2010 12-29 9:50
 * 说明：新闻评论实体类
 * 版权所有：孟冬伊
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Comment
    {
        #region 评论ID
        private string id;
        /// <summary>
        /// 评论ID
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        #region 评论内容
        private string content;
        /// <summary>
        /// 评论内容
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        #endregion

        #region 创建时间
        private string createTime;
        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }
        #endregion

        #region 用户IP
        private string userIp;
        /// <summary>
        /// 用户IP
        /// </summary>
        public string UserIp
        {
            get { return userIp; }
            set { userIp = value; }
        }
        #endregion

        #region 新闻ID
        private string newsId;
        /// <summary>
        /// 新闻ID
        /// </summary>
        public string NewsId
        {
            get { return newsId; }
            set { newsId = value; }
        }
        #endregion

        #region 无参数构造方法
        /// <summary>
        /// 无参数构造方法
        /// </summary>
        public Comment()
        {

        }
        #endregion

        #region 构造方法
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="content">评论内容</param>
        /// <param name="userIp">用户IP</param>
        /// <param name="newsId">新闻ID</param>
        public Comment(string content,string userIp,string newsId)
        {
            this.content = content;
            this.userIp = userIp;
            this.newsId = newsId;
        }
	    #endregion
    }
}
