/*
 * 创建人:孟冬伊
 * 创建时间:2008 12-29 22:00
 * 说明：新闻评论表操作类
 * 版权所有：孟冬伊
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model;
namespace DAL
{
    public class CommentService
    {
        #region 根据新闻ID取出该新闻的所有评论
        /// <summary>
        /// 根据新闻ID取出该新闻的所有评论
        /// </summary>
        /// <param name="newsId">新闻ID</param>
        /// <returns></returns>
        public static DataTable SelectByNewsId(string newsId)
        {
            string sql = "select * from comment where newsId=@newsId order by createTime desc";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@newsId",newsId)
            };
            DataTable dt = SQLHelper.ExecuteQuery(sql, paras,CommandType.Text);
            return dt;
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
            bool flag = false;
            string sql = "insert into comment([content],userIp,newsId) values(@content,@userIp,@newsId)";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@content",com.Content),
                new SqlParameter("@userIp",com.UserIp),
                new SqlParameter("@newsId",com.NewsId)
            };
            int result = SQLHelper.ExecuteNonQuery(sql, paras,CommandType.Text);
            if (result > 0)
            {
                flag = true;
            }
            return flag;
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
            bool flag = false;
            string sql = "delete comment where id=@id";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@id",id)
            };
            int result = SQLHelper.ExecuteNonQuery(sql, paras,CommandType.Text);
            if (result > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion
    }
}
