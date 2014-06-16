<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmMain.aspx.cs" Inherits="frmMain" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <asp:ImageButton ID="ImageButton3" runat="server" 
            ImageUrl="~/CoolBiz_Productions_logo.JPG" 
            PostBackUrl="~/frmMain.aspx" />
        <br />
        <asp:LinkButton ID="linkbtnCalculator" runat="server" 
            PostBackUrl="~/frmSalaryCalculator.aspx" width="200px">Annual Salary Calculator</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgbtnCalculator" runat="server" Height="50px" 
            ImageUrl="~/payroll.jpg" PostBackUrl="~/frmSalaryCalculator.aspx" 
            Width="60px" />
        <br />
        <asp:LinkButton ID="linkbtnNewEmployee" runat="server" 
            PostBackUrl="~/frmPersonnel.aspx" width="200px" height="19px">Add New Employee</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgbtnNewEmployee" runat="server" Height="50px" 
            ImageUrl="~/new_employee.jpg" PostBackUrl="~/frmPersonnel.aspx" Width="60px" />
    
        <br />
        <asp:LinkButton ID="linkbtnViewUserActivity" runat="server" PostBackUrl="~/frmUserActivity.aspx" width="200px" height="19px">User Activity</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgbtnViewUserActivity" runat="server" Height="50px" ImageUrl="~/userActivity.jpg" Width="60px" PostBackUrl="~/frmUserActivity.aspx" />
    
        <br />
        &nbsp;&nbsp;&nbsp;<asp:LinkButton ID="linkbtnViewPersonnel" runat="server" PostBackUrl="~/frmViewPersonnel.aspx" width="200px" height="19px">View Personnel</asp:LinkButton>
        &nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgbtnViewPersonnel" runat="server" Height="50px" ImageUrl="~/viewPersonnel.jpg" PostBackUrl="~/frmViewPersonnel.aspx" Width="60px" />
&nbsp;&nbsp;&nbsp;
    
        <br />
        <asp:LinkButton ID="linkbtnSearch" runat="server" width="200px" PostBackUrl="~/frmSearchPersonnel.aspx">Search Personnel</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgbtnSearch" runat="server" Height="50px" ImageUrl="~/searchPersonnel.jpg" Width="60px" PostBackUrl="~/frmSearchPersonnel.aspx" />
    
        <br />
        <asp:LinkButton ID="linkbtnEditEmployees" runat="server" width="200px" PostBackUrl="~/frmEditPersonnel.aspx" style="margin-bottom: 0px">Edit Personnel</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgbtnEditEmployees" runat="server" Height="50px" ImageUrl="~/editPersonnel.jpg" Width="60px" PostBackUrl="~/frmEditPersonnel.aspx" />
    
        <br />
        <asp:LinkButton ID="linkbtnManageUsers" runat="server" width="200px" PostBackUrl="~/frmManageUsers.aspx" style="margin-bottom: 0px">Manage Users</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="imgbtnManageUsers" runat="server" Height="50px" ImageUrl="~/manageUsers.jpg" Width="60px" PostBackUrl="~/frmManageUsers.aspx" />
    
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
