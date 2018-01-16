<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Airport_HomePage.aspx.cs" Inherits="XML_WebApplication.Airport_HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
            <asp:Button ID="btnClick" runat="server" OnClick="btnClick_Click" Text="Button" />
        </div>
        <asp:TextBox ID="txtOutput" runat="server" Height="296px" Width="478px"></asp:TextBox>
    </form>
</body>
</html>
