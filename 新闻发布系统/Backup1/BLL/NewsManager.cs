/*
 * ������:�϶���
 * ����ʱ��:2008 12-30 17:13
 * ˵�������ű�ҵ����
 * ��Ȩ���У��϶���
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
        #region ȡ������10�����ţ��������ࡢ���ű��⡢����ʱ�䣩
        /// <summary>
        /// ȡ������10�����ţ��������ࡢ���ű��⡢����ʱ�䣩
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectNewNews()
        {
            return NewsService.SelectNewNews();
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
            return NewsService.SelectHotNews();
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
            return NewsService.SelectByCaId(caId);
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
            return NewsService.SelectById(id);
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
            return NewsService.SelectByTitle(title);
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
            return NewsService.SelectByContent(content);
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
            return NewsService.Insert(news);
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
            return NewsService.Update(news);
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
            return NewsService.Delete(id);
        }
        #endregion

        #region ѡ��ȫ������
        /// <summary>
        /// ѡ��ȫ������
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectAll()
        {
            return NewsService.SelectAll();
        }
        #endregion
    }
}
