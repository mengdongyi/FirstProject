/*
 * 创建人:孟冬伊
 * 创建时间:2008 12-29 15:04
 * 说明：数据库助手类
 * 版权所有：孟冬伊
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class SQLHelper
    {
        //连接字符串
        private static readonly string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        //连接对象
        private static SqlConnection conn = null;
        //命令对象
        private static SqlCommand comm = null;
        //数据读取对象
        private static SqlDataReader sdr = null;


        #region 该方法执行传入的增删改SQL语句或者存储过程
        /// <summary>
        /// 该方法执行传入的增删改SQL语句或者存储过程
        /// </summary>
        /// <param name="CmdText">增删改SQL语句或者存储过程</param>
        /// <param name="ct">命令类型</param>
        /// <returns>返回更新的记录数</returns>
        public static int ExecuteNonQuery(string CmdText, CommandType ct)
        {
            using (conn = new SqlConnection(connString))
            {
                conn.Open();
                using (comm = new SqlCommand(CmdText, conn))
                {
                    comm.CommandType = ct;
                    return comm.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region 该方法执行传入的增删改带参数的SQL语句或者存储过程
        /// <summary>
        /// 该方法执行传入的增删改带参数的SQL语句或者存储过程
        /// </summary>
        /// <param name="CmdText">增删改带参数的SQL语句或者存储过程</param>
        /// <param name="paras">参数集合</param>
        /// <param name="ct">命令类型</param>
        /// <returns>返回更新的记录数</returns>
        public static int ExecuteNonQuery(string CmdText, SqlParameter[] paras, CommandType ct)
        {
            using (conn = new SqlConnection(connString))
            {
                conn.Open();
                using (comm = new SqlCommand(CmdText, conn))
                {
                    comm.CommandType = ct;
                    comm.Parameters.AddRange(paras);
                    return comm.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region 该方法执行传入的查询SQL语句或者存储过程
        /// <summary>
        /// 该方法执行传入的查询SQL语句或者存储过程
        /// </summary>
        /// <param name="CmdText">查询SQL语句或者存储过程</param>
        /// <param name="ct">命令类型</param>
        /// <returns>返回数据表</returns>
        public static DataTable ExecuteQuery(string CmdText, CommandType ct)
        {
            DataTable dt = new DataTable();
            using (conn = new SqlConnection(connString))
            {
                conn.Open();
                using (comm = new SqlCommand(CmdText, conn))
                {
                    comm.CommandType = ct;
                    using (sdr = comm.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        dt.Load(sdr);
                        return dt;
                    }
                }
            }
        }
        #endregion

        #region 该方法执行传入带参数的查询SQL语句或者存储过程
        /// <summary>
        /// 该方法执行传入带参数的查询SQL语句或者存储过程
        /// </summary>
        /// <param name="CmdText">查询SQL语句或者存储过程</param>
        /// <param name="paras">参数集合</param>
        /// <param name="ct">命令类型</param>
        /// <returns>返回数据表</returns>
        public static DataTable ExecuteQuery(string CmdText, SqlParameter[] paras, CommandType ct)
        {
            DataTable dt = new DataTable();
            using (conn = new SqlConnection(connString))
            {
                conn.Open();
                using (comm = new SqlCommand(CmdText, conn))
                {
                    comm.CommandType = ct;
                    comm.Parameters.AddRange(paras);
                    using (sdr = comm.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        dt.Load(sdr);
                        return dt;
                    }
                }
            }
        }
        #endregion
    }
}
