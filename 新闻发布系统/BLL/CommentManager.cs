/*
 * 创建人:孟冬伊
 * 创建时间:2008 12-30 17:22
 * 说明：新闻评论表业务类
 * 版权所有：孟冬伊
 */
using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class CommentManager
    {
        #region 根据新闻ID取出该新闻的所有评论
        /// <summary>
        /// 根据新闻ID取出该新闻的所有评论
        /// </summary>
        /// <param name="newsId">新闻ID</param>
        /// <returns></returns>
        public static DataTable SelectByNewsId(string newsId)
        {
            return CommentService.SelectByNewsId(newsId);
        }
        #endregion

        #region 添加评论
        /// <summary>
        /// 添加评论
        /// </summary>
        /// <param name="com">评论实体类</param>
        /// <returns></returns>
        public static bool Insert(Comment com)
        {
            return CommentService.Insert(com);
        }
        #endregion

        #region 删除评论
        /// <summary>
        /// 删除评论
        /// </summary>
        /// <param name="id">评论ID</param>
        /// <returns></returns>
        public static bool Delete(string id)
        {
            return CommentService.Delete(id);
        }
        #endregion
    }
}
