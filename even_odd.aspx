<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="even_odd.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Enter a number
            <asp:TextBox ID="value1" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Check" />
        </p>
    </form>
</body>
</html>
