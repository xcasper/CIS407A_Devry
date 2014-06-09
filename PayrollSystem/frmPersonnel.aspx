<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmPersonnel.aspx.cs" Inherits="frmPersonnel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="~/CoolBiz_Productions_logo.JPG" 
            PostBackUrl="~/frmMain.aspx" style="text-align: center" />
        <asp:Panel ID="Panel1" runat="server" Height="250px" Width="643px">
            <div class="auto-style2">
                <asp:Label ID="Label2" runat="server" Text="First Name:"></asp:Label>
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstName" ErrorMessage="First Name May Not Be Empty"></asp:RequiredFieldValidator>
                <br />
                <asp:Label ID="Label1" runat="server" Text="Last Name:" width="71px"></asp:Label>
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastName" ErrorMessage="Last Name May Not Be Empty"></asp:RequiredFieldValidator>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Pay Rate:" width="71px"></asp:Label>
                <asp:TextBox ID="txtPayRate" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label4" runat="server" Text="Start Date:" width="71px"></asp:Label>
                <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtStartDate" ErrorMessage="Enter date in MM/DD/YYYY format" ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>
                <br />
                <asp:Label ID="Label5" runat="server" Text="End Date:" width="71px"></asp:Label>
                <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEndDate" ErrorMessage="Enter date in MM/DD/YYYY format" ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>
                <br />
                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                <br />
                <asp:Label ID="lblError" runat="server"></asp:Label>
                <br />
            </div>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
