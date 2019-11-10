<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteStudentUI.aspx.cs" Inherits="DatabaseConnection.UI.DeleteStudentUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="RegNoDeleteLabel" runat="server" Text="Enter Registration Number "></asp:Label>
            <asp:TextBox ID="DeleteRegNoTextBoxID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="DeleteButton" runat="server" OnClick="DeleteButton_Click" Text="Delete" />
            <br />
            <br />
            <asp:Label ID="DeleteMsgID" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
