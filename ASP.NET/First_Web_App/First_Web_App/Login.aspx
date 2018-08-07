<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="First_Web_App.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <caption><h2>Login Form</h2></caption>
                <tr>
                    <td>Enter User Name:</td>
                    <td><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox><br /> </td>
                </tr>
                <tr>
                    <td> Enter Password:</td>
                    <td> <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                
                <tr>
                    <td align="right"><asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/></td>
                    <td><asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
