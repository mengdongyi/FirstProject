/*
 * ������:�϶���
 * ����ʱ��:2009 1-3 22:13
 * ˵������½ҵ����
 * ��Ȩ���У��϶���
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class LoginManager
    {
        #region �û���½�Ƿ�ɹ�
        /// <summary>
        /// �û���½�Ƿ�ɹ�
        /// </summary>
        /// <param name="userName">�û���</param>
        /// <param name="pwd">����</param>
        /// <returns></returns>
        public static bool Login(string userName, string pwd)
        {
            bool flag = false;
            if ("admin" == userName && "admin" == pwd)
            {
                flag = true;
            }
            return flag;
        }
        #endregion
    }
}
