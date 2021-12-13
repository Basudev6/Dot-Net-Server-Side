<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="largest.aspx.cs" Inherits="WebApplication1.largest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter first number&nbsp;&nbsp;
            <asp:TextBox ID="value1" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter second number&nbsp;
            <asp:TextBox ID="value2" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter third number&nbsp;
            <asp:TextBox ID="value3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Check" />
        </div>
    </form>
</body>
</html>
