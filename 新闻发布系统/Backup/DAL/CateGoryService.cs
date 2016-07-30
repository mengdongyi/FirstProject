/*
 * 创建人:孟冬伊
 * 创建时间:2008 12-29 15:31
 * 说明：新闻类别表操作类
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
    public class CateGoryService
    {
        #region 取出当前所有新闻分类
        /// <summary>
        /// 取出当前所有新闻分类
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectAll()
        {
            string sql = "select * from category";
            DataTable dt = SQLHelper.ExecuteQuery(sql,CommandType.Text);
            return dt;
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
            bool flag = false;
            //使用参数化SQL防止SQL注入攻击
            string sql = "insert into category(name) values(@name)";
            SqlParameter[] paras=new SqlParameter[]
            {
                new SqlParameter("@name",caName)
            };
            int result = SQLHelper.ExecuteNonQuery(sql, paras,CommandType.Text);
            if (result > 0)
            {
                flag = true;
            }
            return flag;
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
            bool flag = false;
            //使用参数化SQL防止SQL注入攻击
            string sql = "update category set [name]=@name where id=@id";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@name",ca.Name),
                new SqlParameter("@id",ca.ID)
            };
            int result = SQLHelper.ExecuteNonQuery(sql, paras,CommandType.Text);
            if (result > 0)
            {
                flag = true;
            }
            return flag;
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
            bool flag = false;
            //使用参数化SQL防止SQL注入攻击
            string sql = "delete from category where id=@id";
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

        #region 判断类别名称是否已存在
        /// <summary>
        /// 判断类别名称是否已存在
        /// </summary>
        /// <param name="caName">类别名称</param>
        /// <returns>返回是否存在</returns>
        public static bool isExists(string caName)
        {
            bool flag = false;
            string sql = "select * from category where [name]='" + caName + "'";
            DataTable dt = SQLHelper.ExecuteQuery(sql,CommandType.Text);
            if (dt.Rows.Count > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion
    }
}
