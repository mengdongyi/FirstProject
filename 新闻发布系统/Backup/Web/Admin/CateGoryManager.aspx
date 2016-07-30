<%@ Page Language="C#" MasterPageFile="~/common.master" AutoEventWireup="true" CodeFile="CateGoryManager.aspx.cs" Inherits="Admin_CateGoryManager2" Title="类别管理类" %>
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

<div id="camanager" class="round2">
    <h3>类别管理</h3>
    <div class="con">
    <div class="fontcolor">提示,点击类别名称后可直接修改,回车或鼠标点击其他地方后修改生效</div>
        <table class="m_table">
            <tr>
                <th class="xuhao">序号</th>
                <th>类别名称</th>
                <th class="del">删除</th>
            </tr>
            <asp:Repeater ID="rptGateGory" runat="server">
            <ItemTemplate>
            <tr>
                <td><%# Eval("id") %></td>
                <td><%# Eval("name") %></td>
                <td><a href="#">
                    <asp:LinkButton ID="lbtnDelCa" CommandArgument='<%# Eval("id") %>' OnClientClick="return confirm('删除类别会使其下新闻及评论全都删除，是否真的要删除')" OnClick="lbtnDelCa_Click" runat="server" CausesValidation="false">删除</asp:LinkButton>
            </tr>
            </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
    <div class="footer">
        <p>&nbsp</p>
    </div>
</div>

<div id="addca" class="round2">
    <h3>添加类别</h3>
    <div class="con">
        请输入类别名称：<asp:TextBox ID="txtCaName" runat="server" CssClass="txtcaname" ValidationGroup="addCa"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtCaName" ValidationGroup="addCa" runat="server" ErrorMessage="请输入类别名称" Text="*"></asp:RequiredFieldValidator>
        <asp:Button ID="btnAdd" ValidationGroup="addCa" runat="server" Text="添加类别" CssClass="btnadd" OnClick="btnAdd_Click" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="addCa" ShowMessageBox="true" ShowSummary="false" />
    </div>
    <div class="footer">
        <p>&nbsp</p>
    </div>
</div>
</asp:Content>

