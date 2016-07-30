/*
 * 创建人:孟冬伊
 * 创建时间:2008 12-29 7:31
 * 说明：新闻类别实体类
 * 版权所有：孟冬伊
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class CateGory
    {
        #region 类别ID
        private string id;
        /// <summary>
        /// 类别ID
        /// </summary>
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        #region 类别名称
        private string name;
        /// <summary>
        /// 类别名称
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion

        #region 无参数构造方法
        /// <summary>
        /// 无参数构造方法
        /// </summary>
        public CateGory()
        {

        }
        #endregion

        #region 构造方法
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="id">类别ID</param>
        /// <param name="name">类别名称</param>
        public CateGory(string id,string name)
        {
            this.id = id;
            this.name = name;
        }
	    #endregion
    }
}
