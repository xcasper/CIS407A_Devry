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
        <asp:LinkButton ID="LinkButton1" runat="server" 
            PostBackUrl="~/frmSalaryCalculator.aspx" width="200px">Annual Salary Calculator</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton1" runat="server" Height="50px" 
            ImageUrl="~/payroll.jpg" PostBackUrl="~/frmSalaryCalculator.aspx" 
            Width="60px" />
        <br />
        <asp:LinkButton ID="LinkButton2" runat="server" 
            PostBackUrl="~/frmPersonnel.aspx" width="200px" height="19px">Add New Employee</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton2" runat="server" Height="50px" 
            ImageUrl="~/new_employee.jpg" PostBackUrl="~/frmPersonnel.aspx" Width="60px" />
    
        <br />
        <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/frmUserActivity.aspx" width="200px" height="19px">User Activity</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton4" runat="server" Height="50px" ImageUrl="~/userActivity.jpg" Width="60px" PostBackUrl="~/frmUserActivity.aspx" />
    
        <br />
        &nbsp;&nbsp;&nbsp;<asp:LinkButton ID="LinkButton4" runat="server" PostBackUrl="~/frmViewPersonnel.aspx" width="200px" height="19px">View Personnel</asp:LinkButton>
        &nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton5" runat="server" Height="50px" ImageUrl="~/viewPersonnel.jpg" PostBackUrl="~/frmViewPersonnel.aspx" Width="60px" />
&nbsp;&nbsp;&nbsp;
    
        <br />
        <asp:LinkButton ID="LinkButton5" runat="server" width="200px" PostBackUrl="~/frmSearchPersonnel.aspx">Search Personnel</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton6" runat="server" Height="50px" ImageUrl="~/searchPersonnel.jpg" Width="60px" PostBackUrl="~/frmSearchPersonnel.aspx" />
    
        <br />
        <asp:LinkButton ID="LinkButton6" runat="server" width="200px" PostBackUrl="~/frmEditPersonnel.aspx" style="margin-bottom: 0px">Edit Personnel</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton7" runat="server" Height="50px" ImageUrl="~/editPersonnel.jpg" Width="60px" PostBackUrl="~/frmEditPersonnel.aspx" />
    
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
