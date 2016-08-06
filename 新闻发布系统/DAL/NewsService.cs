/*
 * 创建人:孟冬伊
 * 创建时间:2010 12-29 11:00
 * 说明：新闻表操作类
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
    public class NewsService
    {
        #region 取出最新10条新闻（所属分类、新闻标题、发布时间）
        /// <summary>
        /// 取出最新10条新闻（所属分类、新闻标题、发布时间）
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectNewNews()
        {
            return SQLHelper.ExecuteQuery("[procNewsSelectNewNews]", CommandType.StoredProcedure);
        }
        #endregion

        #region 取出10条热点新闻(评论回复最多的十条新闻)
        /// <summary>
        /// 取出10条热点新闻(评论回复最多的十条新闻)
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectHotNews()
        {
            //TODO:取出10条热点新闻
            return SQLHelper.ExecuteQuery("[procNewsSelectHotNews]", CommandType.StoredProcedure);
        }
        #endregion

        #region 根据类别ID取出该类别下的所有新闻
        /// <summary>
        /// 根据类别ID取出该类别下的所有新闻
        /// </summary>
        /// <param name="caId">类别ID</param>
        /// <returns></returns>
        public static DataTable SelectByCaId(string caId)
        {
            //TODO:根据类别ID取出该类别下的所有新闻
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@caId",caId)
            };
            return SQLHelper.ExecuteQuery("[procNewsSelectByCaId]", paras, CommandType.StoredProcedure);
        }
        #endregion

        #region 根据新闻ID取出该条新闻主体内容
        /// <summary>
        /// 根据新闻ID取出该条新闻主体内容
        /// </summary>
        /// <param name="id">新闻ID</param>
        /// <returns></returns>
        public static News SelectById(string id)
        {
            //TODO:根据新闻ID取出该条新闻主体内容
            News news = new News();
            DataTable dt = new DataTable();
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@Id",id)
            };
            dt = SQLHelper.ExecuteQuery("[procNewsSelectById]", paras, CommandType.StoredProcedure);
            news.Id = id;
            news.Title = dt.Rows[0]["title"].ToString();
            news.Content = dt.Rows[0]["content"].ToString();
            news.CreateTime = dt.Rows[0]["createTime"].ToString();
            news.CaId = dt.Rows[0]["caId"].ToString();
            return news;
        }
        #endregion

        #region 根据标题搜索新闻
        /// <summary>
        /// 根据标题搜索新闻
        /// </summary>
        /// <param name="title">标题</param>
        /// <returns></returns>
        public static DataTable SelectByTitle(string title)
        {
            //TODO:根据标题搜索新闻
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@title",title)
            };
            return SQLHelper.ExecuteQuery("[procNewsSelectByTitle]", paras, CommandType.StoredProcedure);
        }
        #endregion

        #region 根据内容搜索新闻
        /// <summary>
        /// 根据内容搜索新闻
        /// </summary>
        /// <param name="content">新闻内容</param>
        /// <returns></returns>
        public static DataTable SelectByContent(string content)
        {
            //TODO:根根据内容搜索新闻
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@content",content)
            };
            return SQLHelper.ExecuteQuery("[procNewsSelectByContent]", paras, CommandType.StoredProcedure);
        }
        #endregion

        #region 增加新闻
        /// <summary>
        /// 增加新闻
        /// </summary>
        /// <param name="news">新闻实体类</param>
        /// <returns></returns>
        public static bool Insert(News news)
        {

            //TODO:增加新闻
            bool flag = false;
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@title",news.Title),
                new SqlParameter("@content",news.Content),
                new SqlParameter("@caId",news.CaId)
            };
            int result = SQLHelper.ExecuteNonQuery("[procNewsInsert]", paras, CommandType.StoredProcedure);
            if (result > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 修改新闻
        /// <summary>
        /// 修改新闻
        /// </summary>
        /// <param name="news">新闻实体类</param>
        /// <returns></returns>
        public static bool Update(News news)
        {
            //TODO:修改新闻
            bool flag = false;
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@id",news.Id),
                new SqlParameter("@title",news.Title),
                new SqlParameter("@content",news.Content),
                new SqlParameter("@caId",news.CaId)
            };
            int result = SQLHelper.ExecuteNonQuery("[procNewsUpdate]", paras, CommandType.StoredProcedure);
            if (result > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 删除新闻（连同其下新闻评论一起删除）
        /// <summary>
        /// 删除新闻（连同其下新闻评论一起删除）
        /// </summary>
        /// <param name="id">新闻ID</param>
        /// <returns></returns>
        public static bool Delete(string id)
        {
            //TODO:删除新闻（连同其下新闻评论一起删除）
            bool flag = false;
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@id",id)
            };
            int result = SQLHelper.ExecuteNonQuery("[procNewsDelete]", paras, CommandType.StoredProcedure);
            if (result > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 选择全部新闻
        /// <summary>
        /// 选择全部新闻
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            string sql = "select * from news";
            dt = SQLHelper.ExecuteQuery(sql, CommandType.Text);
            return dt;
        }
        #endregion
    }
}
