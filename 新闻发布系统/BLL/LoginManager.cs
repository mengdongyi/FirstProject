/*
 * 创建人:孟冬伊
 * 创建时间:2011 1-3 22:13
 * 说明：登陆业务类
 * 版权所有：孟冬伊
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class LoginManager
    {
        #region 用户登陆是否成功
        /// <summary>
        /// 用户登陆是否成功
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="pwd">密码</param>
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
