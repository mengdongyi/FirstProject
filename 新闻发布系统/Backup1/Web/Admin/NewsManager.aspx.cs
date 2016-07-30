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
using System.Data.SqlClient;

public partial class Admin_NewsManager2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断Session里面是否存在管理员
        if (Session["admin"] != null && Session["admin"].ToString() == "admin")
        {
            //已登陆
            if (!IsPostBack)
            {
                //首次加载,绑定新闻列表
                BindNews();
            }
        }
        else
        {
            //未登陆
            Response.Redirect("Login.aspx");
        }
    }

    //绑定新闻列表
    private void BindNews()
    {
        rptNews.DataSource = NewsManager.SelectAll();
        rptNews.DataBind();
    }

    protected void lbtnDel_Click(object sender, EventArgs e)
    {
        LinkButton lb = sender as LinkButton;
        //获得新闻id
        string id = lb.CommandArgument;
        //根据新闻id删除新闻
        NewsManager.Delete(id);
        //重新绑定新闻列表
        BindNews();
    }
}
