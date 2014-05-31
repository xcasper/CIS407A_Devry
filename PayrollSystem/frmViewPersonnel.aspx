<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmViewPersonnel.aspx.cs" Inherits="frmViewPersonnel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
    <div>
        <asp:ImageButton ID="ImageButton3" runat="server" 
            ImageUrl="~/CoolBiz_Productions_logo.JPG" 
            PostBackUrl="~/frmMain.aspx" />   
        <br />
        <asp:Label ID="Label1" runat="server" Text="View Personnel"></asp:Label>
        <asp:GridView ID="grdViewPersonnel" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
