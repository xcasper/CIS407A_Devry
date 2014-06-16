<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmLogin.aspx.cs" Inherits="frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
    <div>
        <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="~/CoolBiz_Productions_logo.JPG" style="text-align: center" />
        <asp:Login ID="Login1" runat="server" DestinationPageUrl="~/frmMain.aspx" TitleText="Please enter your UserName and Password in order to log into the system" OnAuthenticate="Login1_Authenticate">
        </asp:Login>
    
    </div>
    </form>
</body>
</html>
