<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentDelete.aspx.cs" Inherits="WebApplication1.StudentDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <h1>&nbsp;Student Record Delete</h1> 
        <p>
            Student ID&nbsp;
            <asp:TextBox ID="txtStudentID" runat="server"></asp:TextBox>
        </p>
        </div>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnSubmit_Click" Width="52px" />
        </p>
    </form>
</body>
</html>
