<%@ Page Language="C#" MasterPageFile="~/common.master" AutoEventWireup="true" CodeFile="SearchResult.aspx.cs" Inherits="SearchResult" Title="搜索结果页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="main">
            <!--搜索结果-->
            <div id="searchresult" class="commonframe">
                <h4>搜索结果</h4>
                <asp:GridView ID="gvNews" runat="server" AutoGenerateColumns="False">
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

