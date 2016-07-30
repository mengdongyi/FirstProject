using System;
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

public partial class Admin_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //登陆按钮
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //判断验证码输入是否正确
        string code = txtCode.Text.Trim().ToUpper();
        string rightCode = Session["Code"].ToString();
        if (code != rightCode)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "alert('验证码输入错误！');", true);
            //ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript' defer>alert('验证码输入错误！');</script>");
            //ClientScript.RegisterClientScriptBlock(this.GetType(), "", "alert('验证码输入错误！');", true);
            return;
        }

        string name = txtUserName.Text.Trim();
        string pwd = txtPwd.Text.Trim();

        bool b = LoginManager.Login(name, pwd);
        if (b)
        {
            //登陆成功
            Session["admin"] = name;
            Response.Redirect("CateGoryManager.aspx");
        }
        else
        {
            //失败
            ClientScript.RegisterStartupScript(this.GetType(), "", "alert('登陆失败！用户名或者密码错误');", true);
        }
    }
}
