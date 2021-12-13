<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prime_composite.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Enter a number
        <br />
        <asp:TextBox ID="value1" runat="server" OnTextChanged="value1_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Check" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
