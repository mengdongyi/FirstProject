/*
 * ������:�϶���
 * ����ʱ��:2008 12-29 7:31
 * ˵�����������ʵ����
 * ��Ȩ���У��϶���
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class CateGory
    {
        #region ���ID
        private string id;
        /// <summary>
        /// ���ID
        /// </summary>
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        #region �������
        private string name;
        /// <summary>
        /// �������
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion

        #region �޲������췽��
        /// <summary>
        /// �޲������췽��
        /// </summary>
        public CateGory()
        {

        }
        #endregion

        #region ���췽��
        /// <summary>
        /// ���췽��
        /// </summary>
        /// <param name="id">���ID</param>
        /// <param name="name">�������</param>
        public CateGory(string id,string name)
        {
            this.id = id;
            this.name = name;
        }
	    #endregion
    }
}
