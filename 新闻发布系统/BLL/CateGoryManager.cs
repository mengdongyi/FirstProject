/*
 * 创建人:孟冬伊
 * 创建时间:2010 12-30 16:57
 * 说明：新闻类别表业务类
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
    public class CateGoryManager
    {
        #region 取出当前所有新闻分类
        /// <summary>
        /// 取出当前所有新闻分类
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectAll()
        {
            return CateGoryService.SelectAll();
        }
        #endregion

        #region 增加类别
        /// <summary>
        /// 增加类别
        /// </summary>
        /// <param name="caName"></param>
        /// <returns></returns>
        public static bool Insert(string caName)
        {
            return CateGoryService.Insert(caName);
        }
        #endregion

        #region 修改类别
        /// <summary>
        /// 修改类别
        /// </summary>
        /// <param name="id">类别ID</param>
        /// <param name="caName">类别名称</param>
        /// <returns></returns>
        public static bool Update(CateGory ca)
        {
            return CateGoryService.Update(ca);
        }
        #endregion

        #region 删除类别（连同其下的新闻及新闻评论一起删除）
        /// <summary>
        /// 删除类别（连同其下的新闻及新闻评论一起删除）
        /// </summary>
        /// <param name="id">根据ID删除类别</param>
        /// <returns></returns>
        public static bool Delete(string id)
        {
            return CateGoryService.Delete(id);
        }
        #endregion

        #region 判断类别名称是否已存在
        /// <summary>
        /// 判断类别名称是否已存在
        /// </summary>
        /// <param name="caName">类别名称</param>
        /// <returns>返回是否存在</returns>
        public static bool isExists(string caName)
        {
            return CateGoryService.isExists(caName);
        }
        #endregion
    }
}
