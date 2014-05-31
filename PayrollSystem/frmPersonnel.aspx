<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmPersonnel.aspx.cs" Inherits="frmPersonnel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="~/CoolBiz_Productions_logo.JPG" 
            PostBackUrl="~/frmMain.aspx" />
        <asp:Panel ID="Panel1" runat="server" Height="250px" Width="300px">
            <asp:Label ID="Label2" runat="server" Text="First Name:"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Last Name:" width="71px"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Pay Rate:" width="71px"></asp:Label>
            <asp:TextBox ID="txtPayRate" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Start Date:" width="71px"></asp:Label>
            <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="End Date:" width="71px"></asp:Label>
            <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" PostBackUrl="~/frmMain.aspx" />
            <asp:Button ID="btnViewPersonnel" runat="server" Text="View Personnel" PostBackUrl="~/frmViewPersonnel.aspx" />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
        </asp:Panel>
    </div>
    </form>
</body>
</html>
