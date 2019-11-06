<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowAllStudentUI.aspx.cs" Inherits="DatabaseConnection.ShowAllStudentUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Show All Students</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="StudentGridView" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
