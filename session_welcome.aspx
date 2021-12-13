<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="session_welcome.aspx.cs" Inherits="WebApplication1.session_welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome to dashboard<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnlogout" runat="server" OnClick="btnlogout_Click" Text="Log Out" />
        </div>
    </form>
</body>
</html>
