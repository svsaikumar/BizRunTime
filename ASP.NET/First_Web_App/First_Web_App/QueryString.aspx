<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryString.aspx.cs" Inherits="First_Web_App.QueryString" %>

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
                    <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox><br /> </td>
                </tr>
                <tr>
                    <td> Enter Password:</td>
                    <td> <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                
                <tr>
                    <td align="right"><asp:Button ID="Loginbtn" runat="server" Text="Login" OnClick="Loginbtn_Click"/></td>
                    <td><asp:Button ID="Resetbtn" runat="server" Text="Reset" OnClick="Resetbtn_Click"  /></td>
                </tr>
                 <tr>
                     <td colspan="2" align="center">
                         <asp:Label ID="lblStatus" Text="Status" runat="server" Forecolor="Red" />
                     </td>
                 </tr>
            </table>
        </div>
    </form>
</body>
</html>
