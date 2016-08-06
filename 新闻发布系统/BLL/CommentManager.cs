/*
 * ������:�϶���
 * ����ʱ��:2010 12-30 17:22
 * ˵�����������۱�ҵ����
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
    public class CommentManager
    {
        #region ��������IDȡ�������ŵ���������
        /// <summary>
        /// ��������IDȡ�������ŵ���������
        /// </summary>
        /// <param name="newsId">����ID</param>
        /// <returns></returns>
        public static DataTable SelectByNewsId(string newsId)
        {
            return CommentService.SelectByNewsId(newsId);
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
            return CommentService.Insert(com);
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
            return CommentService.Delete(id);
        }
        #endregion
    }
}
