/*
 * ������:�϶���
 * ����ʱ��:2008 12-29 11:00
 * ˵�������ű������
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
    public class NewsService
    {
        #region ȡ������10�����ţ��������ࡢ���ű��⡢����ʱ�䣩
        /// <summary>
        /// ȡ������10�����ţ��������ࡢ���ű��⡢����ʱ�䣩
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectNewNews()
        {
            return SQLHelper.ExecuteQuery("[procNewsSelectNewNews]", CommandType.StoredProcedure);
        }
        #endregion

        #region ȡ��10���ȵ�����(���ۻظ�����ʮ������)
        /// <summary>
        /// ȡ��10���ȵ�����(���ۻظ�����ʮ������)
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectHotNews()
        {
            //TODO:ȡ��10���ȵ�����
            return SQLHelper.ExecuteQuery("[procNewsSelectHotNews]", CommandType.StoredProcedure);
        }
        #endregion

        #region �������IDȡ��������µ���������
        /// <summary>
        /// �������IDȡ��������µ���������
        /// </summary>
        /// <param name="caId">���ID</param>
        /// <returns></returns>
        public static DataTable SelectByCaId(string caId)
        {
            //TODO:�������IDȡ��������µ���������
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@caId",caId)
            };
            return SQLHelper.ExecuteQuery("[procNewsSelectByCaId]", paras, CommandType.StoredProcedure);
        }
        #endregion

        #region ��������IDȡ������������������
        /// <summary>
        /// ��������IDȡ������������������
        /// </summary>
        /// <param name="id">����ID</param>
        /// <returns></returns>
        public static News SelectById(string id)
        {
            //TODO:��������IDȡ������������������
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

        #region ���ݱ�����������
        /// <summary>
        /// ���ݱ�����������
        /// </summary>
        /// <param name="title">����</param>
        /// <returns></returns>
        public static DataTable SelectByTitle(string title)
        {
            //TODO:���ݱ�����������
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@title",title)
            };
            return SQLHelper.ExecuteQuery("[procNewsSelectByTitle]", paras, CommandType.StoredProcedure);
        }
        #endregion

        #region ����������������
        /// <summary>
        /// ����������������
        /// </summary>
        /// <param name="content">��������</param>
        /// <returns></returns>
        public static DataTable SelectByContent(string content)
        {
            //TODO:������������������
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@content",content)
            };
            return SQLHelper.ExecuteQuery("[procNewsSelectByContent]", paras, CommandType.StoredProcedure);
        }
        #endregion

        #region ��������
        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="news">����ʵ����</param>
        /// <returns></returns>
        public static bool Insert(News news)
        {

            //TODO:��������
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

        #region �޸�����
        /// <summary>
        /// �޸�����
        /// </summary>
        /// <param name="news">����ʵ����</param>
        /// <returns></returns>
        public static bool Update(News news)
        {
            //TODO:�޸�����
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

        #region ɾ�����ţ���ͬ������������һ��ɾ����
        /// <summary>
        /// ɾ�����ţ���ͬ������������һ��ɾ����
        /// </summary>
        /// <param name="id">����ID</param>
        /// <returns></returns>
        public static bool Delete(string id)
        {
            //TODO:ɾ�����ţ���ͬ������������һ��ɾ����
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

        #region ѡ��ȫ������
        /// <summary>
        /// ѡ��ȫ������
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
