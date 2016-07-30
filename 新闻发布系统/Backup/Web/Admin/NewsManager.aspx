<%@ Page Language="C#" MasterPageFile="~/common.master" AutoEventWireup="true" CodeFile="NewsManager.aspx.cs" Inherits="Admin_NewsManager2" Title="新闻管理页" %>
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

<div id="newsmanager" class="round2">
    <h3>新闻管理</h3>
    <div class="con">
    <div class="fontcolor">提示，点击新闻标题后可进行对该新闻评论的删除</div>
        <table class="m_table">
            <tr>
                <th class="xuhao">序号</th>
                <th>标题</th>
                <th class="del">修改</th>
                <th class="del">删除</th>
            </tr>
            <asp:Repeater ID="rptNews" runat="server">
            <ItemTemplate>
            <tr>
                <td><%# Eval("id") %></td>
                <td><a href="../newscontent.aspx?newsid=<%# Eval("id") %>" target="_blank" ><%# Eval("title") %></a></td>
                <td><a href="#">修改</a></td>
                <td><asp:LinkButton ID="lbtnDel" OnClientClick="return confirm('是否删除该新闻及其评论');" OnClick="lbtnDel_Click" CommandArgument='<%# Eval("id") %>' runat="server">删除</asp:LinkButton></td>
            </tr>
            </ItemTemplate>
            </asp:Repeater>
            
        </table>
    </div>
    <div class="footer">
        <p>&nbsp</p>
    </div>
</div>
</asp:Content>

