<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="session_login.aspx.cs" Inherits="WebApplication1.session_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtuser" runat="server"></asp:TextBox>
            <br />
            <br />
            Password&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtpwd" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" Text="Log In" />
        </div>
    </form>
</body>
</html>
