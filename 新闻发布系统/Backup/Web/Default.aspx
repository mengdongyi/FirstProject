<%@ Page Language="C#" MasterPageFile="~/common.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="首页" %>

<%@ Register Src="UserControl/NewsCateGory.ascx" TagName="NewsCateGory" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<a href="Admin/Login.aspx">管理员登录</a>
    <div id="main">
            <!--新闻分类-->
            <uc1:NewsCateGory ID="NewsCateGory1" runat="server" />
            <!--最新新闻-->
            <div id="newnews" class="commonframe">
                <h4>最新新闻</h4>
                <asp:GridView ID="gvNewNews" runat="server" AutoGenerateColumns="False">
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
                
                <%--<table>
                    <tr>
                        <th class="th_category">所属类别</th>
                        <th>新闻标题</th>
                        <th class="th_time">发布时间</th>
                    </tr>
                    <tr>
                        <td><a href="#" class="td_category">体育新闻</a></td>
                        <td><a href="#">12345678</a></td>
                        <td class="td_time">sdfdfdff</td>
                    </tr>
                    <tr>
                        <td><a href="#" class="td_category">体育新闻</a></td>
                        <td><a href="#">12345678</a></td>
                        <td class="td_time">sdfdfdff</td>
                    </tr>
                    <tr>
                        <td><a href="#" class="td_category">体育新闻</a></td>
                        <td><a href="#">12345678</a></td>
                        <td class="td_time">sdfdfdff</td>
                    </tr>
                    <tr>
                        <td><a href="#" class="td_category">体育新闻</a></td>
                        <td><a href="#">12345678</a></td>
                        <td class="td_time">sdfdfdff</td>
                    </tr>
                    <tr>
                        <td><a href="#" class="td_category">体育新闻</a></td>
                        <td><a href="#">12345678</a></td>
                        <td class="td_time">sdfdfdff</td>
                    </tr>
                </table>--%>
            </div>
            <!--热点新闻-->
            <div id="hotnews" class="commonframe">
                <h4>热点新闻</h4>
                <asp:GridView ID="gvHotNews" runat="server" AutoGenerateColumns="False">
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

