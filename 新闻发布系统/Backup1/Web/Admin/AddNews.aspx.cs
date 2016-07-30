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

public partial class Admin_AddNews2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断Session里面是否存在管理员
        if (Session["admin"] != null && Session["admin"].ToString() == "admin")
        {
            //已登陆
            if (!IsPostBack)
            {
                DataTable dt = CateGoryManager.SelectAll();
                ddlCateGory.DataSource = dt;
                ddlCateGory.DataTextField = "name";
                ddlCateGory.DataValueField = "id";
                ddlCateGory.DataBind();
            }
        }
        else
        {
            //未登陆
            Response.Redirect("Login.aspx");
        }
    }

    //添加新闻按钮
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string title = txtTitle.Text;
        string content = txtContent.Text;
        string caid = ddlCateGory.SelectedValue;
        News news = new News(title, content, caid);
        bool b = NewsManager.Insert(news);
        if (b)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "alert('新闻添加成功');", true);
        }
    }
}
