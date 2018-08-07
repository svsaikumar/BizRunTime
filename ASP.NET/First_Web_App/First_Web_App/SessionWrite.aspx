<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionWrite.aspx.cs" Inherits="First_Web_App.SessionAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>           
           Enter your Name: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
        
    </form>
</body>
</html>
