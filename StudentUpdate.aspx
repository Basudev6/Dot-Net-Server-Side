<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentUpdate.aspx.cs" Inherits="WebApplication1.StudentUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
           <h1>&nbsp;Student Record Form</h1> 
        <p>
            Student ID&nbsp;
            <asp:TextBox ID="txtStudentID" runat="server"></asp:TextBox>
        </p>
           <p>
            Student Name&nbsp; <asp:TextBox ID="txtStudentName" runat="server"></asp:TextBox>
        </p>
        <p>
            Address&nbsp;
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        </p>
        <p>
            Email&nbsp; <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </p>
        <p>
            Phone&nbsp;
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
&nbsp;
        </p>
        <p>
            Course&nbsp;
            <asp:TextBox ID="txtCourse" runat="server"></asp:TextBox>
        </p>
        <p>
            Gender&nbsp;
            <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
        </p>
        <p>
            DOB&nbsp;
            <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </p>
    </form>
</body>
</html>
