<%@ Page Language="C#" MasterPageFile="~/common.master" AutoEventWireup="true" CodeFile="AddNews.aspx.cs" Inherits="Admin_AddNews2" Title="添加新闻页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/manager_common.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="m_category" class="round2">
    <h3>管理中心</h3>
    <div class="con">
        <p><a href="CateGoryManager.aspx">类别管理</a></p>
        <p><a href="NewsManager.aspx">新闻管理</a></p>
        <p><a href="AddNews.aspx">添加新闻</a></p>
    </div>
    <div class="footer">
        <p>&nbsp</p>
    </div>
</div>

<div id="addnews" class="round2">
    <h3>添加新闻</h3>
    <div class="con">
        <p>新闻分类：<asp:DropDownList ID="ddlCateGory" runat="server"></asp:DropDownList></p>
        <p>新闻标题：<asp:TextBox ID="txtTitle" runat="server" CssClass="newstitle" BorderWidth="1px"></asp:TextBox></p>
        <p>新闻内容：<asp:TextBox ID="txtContent" runat="server" TextMode="MultiLine" CssClass="newscontent" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox></p>
        <p><asp:Button ID="btnAdd" runat="server" Text="添加新闻" BorderWidth="1px" OnClick="btnAdd_Click" /></p>
    </div>
    <div class="footer">
        <p>&nbsp</p>
    </div>
</div>
</asp:Content>

