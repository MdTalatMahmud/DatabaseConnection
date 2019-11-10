<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentUpdateUI.aspx.cs" Inherits="DatabaseConnection.UI.StudentUpdateUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="NameTextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="EmailTextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Phone No"></asp:Label>
            <asp:TextBox ID="PhnTextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Reg No"></asp:Label>
            <asp:TextBox ID="RegNoTextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="UpdateButton" runat="server" OnClick="SaveButton_Click" Text="Update" />
            <br />
            <br />
            <asp:Label ID="MessageLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
