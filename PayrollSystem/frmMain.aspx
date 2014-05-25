<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmMain.aspx.cs" Inherits="frmMain" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <asp:ImageButton ID="ImageButton3" runat="server" 
            ImageUrl="~/CoolBiz_Productions_logo.JPG" 
            PostBackUrl="~/frmMain.aspx" />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" 
            PostBackUrl="~/frmSalaryCalculator.aspx">Annual Salary Calculator</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton1" runat="server" Height="50px" 
            ImageUrl="~/payroll.jpg" PostBackUrl="~/frmSalaryCalculator.aspx" 
            Width="60px" />
        <br />
        <asp:LinkButton ID="LinkButton2" runat="server" 
            PostBackUrl="~/frmPersonnel.aspx">Add New Employee</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton2" runat="server" Height="50px" 
            ImageUrl="~/new_employee.jpg" PostBackUrl="~/frmPersonnel.aspx" Width="60px" />
    
    </div>
    </form>
</body>
</html>
