<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="exception_handeling.aspx.cs" Inherits="WebApplication1.exception_handeling" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Enter first number&nbsp;
        <asp:TextBox ID="value1" runat="server"></asp:TextBox>
        <br />
        <br />
        Enter second number&nbsp;
        <asp:TextBox ID="value2" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Divide" OnClick="Button1_Click" />
        <br />
    </form>
</body>
</html>
