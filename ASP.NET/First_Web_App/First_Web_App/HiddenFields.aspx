<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenFields.aspx.cs" Inherits="First_Web_App.HiddenFields" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Hit Count" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Open New Page" PostBackUrl ="~/GetHiddenValues.aspx"/>
            <asp:HiddenField ID="hfCount" runat="server" Value="0" />           
        </div>
    </form>
</body>
</html>
