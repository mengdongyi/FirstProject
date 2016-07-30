<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NewsCateGory.ascx.cs" Inherits="UserControl_NewsCateGory" %>
<div id="category" class="commonframe">
    <h4>新闻分类</h4>
        <ul>
        <li><a href="Default.aspx">首　　页</a></li>
        <asp:Repeater ID="rptCateGory" runat="server">
            <ItemTemplate>
                <li><a href='List.aspx?Caid=<%# Eval("id") %>'><%# Eval("name") %></a></li>
            </ItemTemplate>
        </asp:Repeater>                 
        </ul>
</div>