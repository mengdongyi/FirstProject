<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Admin_Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>后台登陆</title>
    <link href="../css/login.css" rel="stylesheet" type="text/css" />
    <script language="javascript" type="text/javascript">
function change() 
        {   
            var imgNode = document.getElementById("vimg");   
            imgNode.src = "../Handler/Handler.ashx?t=" + (new Date()).valueOf();  
            // 这里加个时间的参数是为了防止浏览器缓存的问题   
        }   

</script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="loginfrm" class="round1">
        <h3>后台登陆</h3>
        <div id="login">
            
        <img src="../images/lovely.gif" alt="LOGO" class="login_logs" style="width: 160px; height: 120px" />
        <p>
            用户名：<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtUserName" runat="server" ErrorMessage="请输入用户名" Text="*"></asp:RequiredFieldValidator></p>
        <p>
            密　码：<asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="请输入密码" Text="*" ControlToValidate="txtPwd"></asp:RequiredFieldValidator></p>
        <p>
            验证码：<img src="../Handler/Handler.ashx" id="vimg" alt="验证码" onclick="change();" />
    <asp:TextBox ID="txtCode" runat="server" CssClass="txtcode"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="请输入验证码" Text="*" ControlToValidate="txtCode"></asp:RequiredFieldValidator></p>
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:Button ID="btnLogin" runat="server" Text="登陆" OnClick="btnLogin_Click" />
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <p>
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="true" ShowSummary="false" />
        </p>
        </div>
        <div id="footer">版权所有 孟冬伊</div>
    </div>
    </form>
</body>
</html>
