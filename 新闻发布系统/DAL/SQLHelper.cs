/*
 * ������:�϶���
 * ����ʱ��:2010 12-29 15:04
 * ˵�������ݿ�������
 * ��Ȩ���У��϶���
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
        //�����ַ���
        private static readonly string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;


        #region �÷���ִ�д������ɾ��SQL�����ߴ洢����
        /// <summary>
        /// �÷���ִ�д������ɾ��SQL�����ߴ洢����
        /// </summary>
        /// <param name="CmdText">��ɾ��SQL�����ߴ洢����</param>
        /// <param name="ct">��������</param>
        /// <returns>���ظ��µļ�¼��</returns>
        public static int ExecuteNonQuery(string CmdText, CommandType ct)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(CmdText, conn))
                {
                    comm.CommandType = ct;
                    return comm.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region �÷���ִ�д������ɾ�Ĵ�������SQL�����ߴ洢����
        /// <summary>
        /// �÷���ִ�д������ɾ�Ĵ�������SQL�����ߴ洢����
        /// </summary>
        /// <param name="CmdText">��ɾ�Ĵ�������SQL�����ߴ洢����</param>
        /// <param name="paras">��������</param>
        /// <param name="ct">��������</param>
        /// <returns>���ظ��µļ�¼��</returns>
        public static int ExecuteNonQuery(string CmdText, SqlParameter[] paras, CommandType ct)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(CmdText, conn))
                {
                    comm.CommandType = ct;
                    comm.Parameters.AddRange(paras);
                    return comm.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region �÷���ִ�д���Ĳ�ѯSQL�����ߴ洢����
        /// <summary>
        /// �÷���ִ�д���Ĳ�ѯSQL�����ߴ洢����
        /// </summary>
        /// <param name="CmdText">��ѯSQL�����ߴ洢����</param>
        /// <param name="ct">��������</param>
        /// <returns>�������ݱ�</returns>
        public static DataTable ExecuteQuery(string CmdText, CommandType ct)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(CmdText, conn))
                {
                    comm.CommandType = ct;
                    using (SqlDataReader sdr = comm.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        dt.Load(sdr);
                        return dt;
                    }
                }
            }
        }
        #endregion

        #region �÷���ִ�д���������Ĳ�ѯSQL�����ߴ洢����
        /// <summary>
        /// �÷���ִ�д���������Ĳ�ѯSQL�����ߴ洢����
        /// </summary>
        /// <param name="CmdText">��ѯSQL�����ߴ洢����</param>
        /// <param name="paras">��������</param>
        /// <param name="ct">��������</param>
        /// <returns>�������ݱ�</returns>
        public static DataTable ExecuteQuery(string CmdText, SqlParameter[] paras, CommandType ct)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(CmdText, conn))
                {
                    comm.CommandType = ct;
                    comm.Parameters.AddRange(paras);
                    using (SqlDataReader sdr = comm.ExecuteReader(CommandBehavior.CloseConnection))
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
