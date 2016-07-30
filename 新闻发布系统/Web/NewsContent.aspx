<%@ Page Language="C#" MasterPageFile="~/common.master" AutoEventWireup="true" CodeFile="NewsContent.aspx.cs" Inherits="NewsContent" Title="新闻内容页" MaintainScrollPositionOnPostback="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
function change() 
        {   
            var imgNode = document.getElementById("vimg");   
            imgNode.src = "Handler/Handler.ashx?t=" + (new Date()).valueOf();  
            // 这里加个时间的参数是为了防止浏览器缓存的问题   
        }   

</script>
<div id="newscontent" class="commonframe">
    <h4><asp:Label ID="lblTitle" runat="server" Text=""></asp:Label></h4>
    <p class="con">
        <asp:Label ID="lblContent" runat="server" Text="Label"></asp:Label>
    </p>
    <p class="con_time">发布时间,<asp:Label ID="lblCreateTIme" runat="server" Text="Label"></asp:Label></p>
    <a href="#com">我要评论</a>
</div>

<div id="newsreplay" class="commonframe">
    <h4>新闻评论</h4>
    <asp:Repeater ID="rptComment" runat="server" OnItemDataBound="rptComment_ItemDataBound">
    <ItemTemplate>
    <div class="replay">
        <p class="con">
        <%# Eval("content") %>
        </p>
        <p class="replayinfo">
            <asp:LinkButton ID="lbtnDelComment" CommandArgument='<%# Eval("id") %>' OnClientClick="return confirm('是否删除该评论')" OnClick="lbtnDelComment_Click" runat="server" CausesValidation="false" Visible="false">删除</asp:LinkButton>
        评论者:<%# Eval("userIp").ToString().Substring(0, Eval("userIp").ToString().LastIndexOf(".")+1)+"*"%> 评论时间:<%# Eval("createTime") %></p>
        <hr />
    </div>
    </ItemTemplate>
    </asp:Repeater>
    
</div>

<div class="addcomment">
    <asp:TextBox ID="txtComment" runat="server" TextMode="MultiLine" Text="请在此输入评论内容" CssClass="comment_con"></asp:TextBox>
    <p>
    验证码：<a name="com">&nbsp</a><img src="Handler/Handler.ashx" id="vimg" alt="验证码" onclick="change();" />
    <asp:TextBox ID="txtCode" runat="server" CssClass="txtcode"></asp:TextBox>&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCode" ErrorMessage="请输入验证码" Text="*"></asp:RequiredFieldValidator>
    <asp:Button ID="btnSubmit" runat="server" Text="提交" CssClass="btnsubmit" OnClick="btnSubmit_Click" />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="true" ShowSummary="false" />
    </p>
    
</div>
</asp:Content>

