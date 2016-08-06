/*
 * ������:�϶���
 * ����ʱ��:2010 12-29 15:31
 * ˵�����������������
 * ��Ȩ���У��϶���
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
        #region ȡ����ǰ�������ŷ���
        /// <summary>
        /// ȡ����ǰ�������ŷ���
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectAll()
        {
            string sql = "select * from category";
            DataTable dt = SQLHelper.ExecuteQuery(sql, CommandType.Text);
            return dt;
        }
        #endregion

        #region �������
        /// <summary>
        /// �������
        /// </summary>
        /// <param name="caName"></param>
        /// <returns></returns>
        public static bool Insert(string caName)
        {
            bool flag = false;
            //ʹ�ò�����SQL��ֹSQLע�빥��
            string sql = "insert into category(name) values(@name)";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@name",caName)
            };
            int result = SQLHelper.ExecuteNonQuery(sql, paras, CommandType.Text);
            if (result > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region �޸����
        /// <summary>
        /// �޸����
        /// </summary>
        /// <param name="id">���ID</param>
        /// <param name="caName">�������</param>
        /// <returns></returns>
        public static bool Update(CateGory ca)
        {
            bool flag = false;
            //ʹ�ò�����SQL��ֹSQLע�빥��
            string sql = "update category set [name]=@name where id=@id";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@name",ca.Name),
                new SqlParameter("@id",ca.ID)
            };
            int result = SQLHelper.ExecuteNonQuery(sql, paras, CommandType.Text);
            if (result > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region ɾ�������ͬ���µ����ż���������һ��ɾ����
        /// <summary>
        /// ɾ�������ͬ���µ����ż���������һ��ɾ����
        /// </summary>
        /// <param name="id">����IDɾ�����</param>
        /// <returns></returns>
        public static bool Delete(string id)
        {
            bool flag = false;
            //ʹ�ò�����SQL��ֹSQLע�빥��
            string sql = "delete from category where id=@id";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@id",id)
            };
            int result = SQLHelper.ExecuteNonQuery(sql, paras, CommandType.Text);
            if (result > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region �ж���������Ƿ��Ѵ���
        /// <summary>
        /// �ж���������Ƿ��Ѵ���
        /// </summary>
        /// <param name="caName">�������</param>
        /// <returns>�����Ƿ����</returns>
        public static bool isExists(string caName)
        {
            bool flag = false;
            string sql = "select * from category where [name]='" + caName + "'";
            DataTable dt = SQLHelper.ExecuteQuery(sql, CommandType.Text);
            if (dt != null && dt.Rows.Count > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion
    }
}
