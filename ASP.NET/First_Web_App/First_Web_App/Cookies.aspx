<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookies.aspx.cs" Inherits="First_Web_App.Cookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>


    <style>
        label
        {
            width:20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Name: <asp:TextBox ID ="txtName" runat="server"></asp:TextBox><br />
            Enter Age:<asp:TextBox ID ="txtAge" runat="server"></asp:TextBox><br />
            Enter City:<asp:TextBox ID ="txtCity" runat="server"></asp:TextBox><br />
            Enter email<asp:TextBox ID ="txtEmail" runat="server"></asp:TextBox><br />
            <asp:Button  ID ="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            
        </div>
    </form>
</body>
</html>
