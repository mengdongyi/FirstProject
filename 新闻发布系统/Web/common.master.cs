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

public partial class common : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            radTitle.Checked = true;
            txtKey.Text = Request.QueryString["key"];
            string action = Request.QueryString["action"];
            if (action=="bycontent")
            {
                radContent.Checked = true;
            }
        }
    }

    //搜索按钮
    protected void ibtnSearch_Click(object sender, ImageClickEventArgs e)
    {
        //搜索的文字
        string key = txtKey.Text.Trim();
        //根据标题还是内容进行搜索
        string action = radTitle.Checked ? "bytitle" : "bycontent";
        Response.Redirect("~/SearchResult.aspx?key="+Server.UrlEncode(key)+"&action="+action);
    }
}
