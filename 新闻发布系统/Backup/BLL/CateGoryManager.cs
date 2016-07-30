/*
 * ������:�϶���
 * ����ʱ��:2008 12-30 16:57
 * ˵������������ҵ����
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
    public class CateGoryManager
    {
        #region ȡ����ǰ�������ŷ���
        /// <summary>
        /// ȡ����ǰ�������ŷ���
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectAll()
        {
            return CateGoryService.SelectAll();
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
            return CateGoryService.Insert(caName);
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
            return CateGoryService.Update(ca);
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
            return CateGoryService.Delete(id);
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
            return CateGoryService.isExists(caName);
        }
        #endregion
    }
}
