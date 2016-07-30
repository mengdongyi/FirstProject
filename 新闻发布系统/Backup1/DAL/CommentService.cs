/*
 * ������:�϶���
 * ����ʱ��:2008 12-29 22:00
 * ˵�����������۱������
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
    public class CommentService
    {
        #region ��������IDȡ�������ŵ���������
        /// <summary>
        /// ��������IDȡ�������ŵ���������
        /// </summary>
        /// <param name="newsId">����ID</param>
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

        #region �������
        /// <summary>
        /// �������
        /// </summary>
        /// <param name="com">����ʵ����</param>
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

        #region ɾ������
        /// <summary>
        /// ɾ������
        /// </summary>
        /// <param name="id">����ID</param>
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
