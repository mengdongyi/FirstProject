/*
 * 创建人:孟冬伊
 * 创建时间:2010 12-30 17:13
 * 说明：新闻表业务类
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
    public class NewsManager
    {
        #region 取出最新10条新闻（所属分类、新闻标题、发布时间）
        /// <summary>
        /// 取出最新10条新闻（所属分类、新闻标题、发布时间）
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectNewNews()
        {
            return NewsService.SelectNewNews();
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
            return NewsService.SelectHotNews();
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
            return NewsService.SelectByCaId(caId);
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
            return NewsService.SelectById(id);
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
            return NewsService.SelectByTitle(title);
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
            return NewsService.SelectByContent(content);
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
            return NewsService.Insert(news);
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
            return NewsService.Update(news);
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
            return NewsService.Delete(id);
        }
        #endregion

        #region 选择全部新闻
        /// <summary>
        /// 选择全部新闻
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectAll()
        {
            return NewsService.SelectAll();
        }
        #endregion
    }
}
