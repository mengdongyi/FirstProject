<%@ Page Language="C#" MasterPageFile="~/common.master" AutoEventWireup="true" CodeFile="List.aspx.cs" Inherits="List" Title="新闻列表页" %>

<%@ Register Src="UserControl/NewsCateGory.ascx" TagName="NewsCateGory" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<a href="Admin/Login.aspx">管理员登录</a>
<div id="main">
            <!--新闻分类-->
            <uc1:NewsCateGory ID="NewsCateGory1" runat="server" />
            <!--新闻列表-->
            <div id="newslist" class="commonframe">
                <h4><asp:Label ID="lblCaName" runat="server" Text="无新闻"></asp:Label></h4>
                <asp:GridView ID="gvNews" runat="server" AutoGenerateColumns="False" EmptyDataText="该类别暂无新闻">
                <Columns>
                    <asp:TemplateField HeaderText="所属类别" HeaderStyle-CssClass="th_category">
                        <ItemTemplate>
                            <a class="td_category" href="List.aspx?Caid=<%# Eval("caid") %>">[<%# Eval("name") %>]</a>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="新闻标题">
                        <ItemTemplate>
                            <a href="newscontent.aspx?newsid=<%# Eval("id") %>" target="_blank" title='<%# Eval("title") %>'><%# StringTruncat( Eval("title").ToString(),18,"...")%></a>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="发布时间" HeaderStyle-CssClass="th_time" ItemStyle-CssClass="td_time">
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("createTime") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                </asp:GridView>
            </div>
        </div>
</asp:Content>

