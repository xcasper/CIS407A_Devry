<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmPersonalVerified.aspx.cs" Inherits="frmPersonnelVerified" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
        <asp:ImageButton ID="ImageButton3" runat="server" 
            ImageUrl="~/CoolBiz_Productions_logo.JPG" 
            PostBackUrl="~/frmMain.aspx" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Information to Submit"></asp:Label>
        <br />
        <asp:TextBox ID="txtVerifiedInfo" runat="server" Height="80px" 
            TextMode="MultiLine" Width="400px" OnTextChanged="txtVerifiedInfo_TextChanged"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
