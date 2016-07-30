﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BLL;
using Model;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //首次加载

            //绑定最新新闻
            gvNewNews.DataSource = NewsManager.SelectNewNews();
            gvNewNews.DataBind();

            //绑定热点新闻
            gvHotNews.DataSource = NewsManager.SelectHotNews();
            gvHotNews.DataBind();
        }
    }

    ///   <summary>    
    ///   将指定字符串按指定长度进行剪切，    
    ///   </summary>    
    ///   <param   name= "oldStr "> 需要截断的字符串 </param>    
    ///   <param   name= "maxLength "> 字符串的最大长度 </param>    
    ///   <param   name= "endWith "> 超过长度的后缀 </param>    
    ///   <returns> 如果超过长度，返回截断后的新字符串加上后缀，否则，返回原字符串 </returns>    
    public static string StringTruncat(string oldStr, int maxLength, string endWith)
    {
        if (string.IsNullOrEmpty(oldStr))
            //   throw   new   NullReferenceException( "原字符串不能为空 ");    
            return oldStr + endWith;
        if (maxLength < 1)
            throw new Exception("返回的字符串长度必须大于[0] ");
        if (oldStr.Length > maxLength)
        {
            string strTmp = oldStr.Substring(0, maxLength);
            if (string.IsNullOrEmpty(endWith))
                return strTmp;
            else
                return strTmp + endWith;
        }
        return oldStr;
    }   

}
