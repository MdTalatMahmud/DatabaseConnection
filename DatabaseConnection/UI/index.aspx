<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="DatabaseConnection.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Phone No"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Reg No"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Department"></asp:Label>
            <asp:DropDownList ID="DropDownListID" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="SaveButton" runat="server" OnClick="SaveButton_Click" Text="Save" />
            <br />
            <br />
            <asp:Label ID="MessageLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
