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

public partial class NewsContent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string newsid = Request.QueryString["newsid"].ToString();

            News news = NewsManager.SelectById(newsid);

            //设置新闻主体
            lblTitle.Text = news.Title;
            lblContent.Text = news.Content;
            lblCreateTIme.Text = news.CreateTime;

            //绑定新闻评论
            rptComment.DataSource = CommentManager.SelectByNewsId(newsid);
            rptComment.DataBind();
        }
    }

    //删除评论
    protected void lbtnDelComment_Click(object sender, EventArgs e)
    {
        LinkButton lb = sender as LinkButton;
        //获得主键id
        string id = lb.CommandArgument;
        //根据id删除评论
        CommentManager.Delete(id);
        //绑定新闻评论
        string newsid = Request.QueryString["newsid"].ToString();
        rptComment.DataSource = CommentManager.SelectByNewsId(newsid);
        rptComment.DataBind();

    }

    //添加新闻评论
    protected void btnSubmit_Click(object sender, EventArgs e)
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
        string com_content = txtComment.Text;
        string newsid = Request.QueryString["newsid"].ToString();
        string userIp = Request.ServerVariables["REMOTE_ADDR"];
        Comment com = new Comment(com_content, userIp, newsid);
        bool b = CommentManager.Insert(com);
        if (b)
        {
            //绑定新闻评论
            rptComment.DataSource = CommentManager.SelectByNewsId(newsid);
            rptComment.DataBind();
        }
    }

    //根据Session的值显示或者隐藏删除评论的按钮
    protected void rptComment_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        //判断是否是项
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType==ListItemType.AlternatingItem)
        {
            if (Session["admin"] != null && Session["admin"].ToString() == "admin")
            {
                (e.Item.FindControl("lbtnDelComment") as LinkButton).Visible=true;
            }
        }
    }
}
