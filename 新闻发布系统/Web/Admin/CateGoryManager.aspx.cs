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

public partial class Admin_CateGoryManager2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断Session里面是否存在管理员
        if (Session["admin"] != null && Session["admin"].ToString() == "admin")
        {
            //已登陆
            if (!IsPostBack)
            {
                //首次加载,绑定类别列表
                DataTable dt = CateGoryManager.SelectAll();
                rptGateGory.DataSource = dt;
                rptGateGory.DataBind();
            }
        }
        else
        {
            //未登陆
            Response.Redirect("Login.aspx");
        }
    }

    //添加类别
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string name = txtCaName.Text.Trim();
        //判断类别名是否已经存在
        if (CateGoryManager.isExists(name))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "", "alert('类别名称已经存在，请重新输入');", true);
        }
        else
        {
            //添加类别
            bool b = CateGoryManager.Insert(name);
            if (b)
            {
                //重新绑定类别
                DataTable dt = CateGoryManager.SelectAll();
                rptGateGory.DataSource = dt;
                rptGateGory.DataBind();
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "alert('类别添加失败，请联系管理员');", true);
            }
        }
    }

    //删除类别
    protected void lbtnDelCa_Click(object sender, EventArgs e)
    {
        LinkButton lb = sender as LinkButton;
        //获得主键id
        string id = lb.CommandArgument;
        //根据id删除类别
        CateGoryManager.Delete(id);
        //重新绑定类别列表
        DataTable dt = CateGoryManager.SelectAll();
        rptGateGory.DataSource = dt;
        rptGateGory.DataBind();
    }
}
