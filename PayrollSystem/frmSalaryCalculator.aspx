<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmSalaryCalculator.aspx.cs" Inherits="frmSalaryCalculator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">

        <asp:ImageButton ID="ImageButton3" runat="server" 
            ImageUrl="~/CoolBiz_Productions_logo.JPG" 
            PostBackUrl="~/frmMain.aspx" />

            <br />

            <asp:Label ID="Label4" runat="server" Text="Annual Hours:"></asp:Label>

            <asp:TextBox ID="txtAnnualHours" runat="server"></asp:TextBox>
    
            <br />
    
            <asp:Label ID="Label2" runat="server" Text="Rate:" width="86px"></asp:Label>
            <asp:TextBox ID="txtRate" runat="server" ontextchanged="TextBox2_TextChanged" 
                style="margin-bottom: 0px"></asp:TextBox>
            <p>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text="Calculate Salary" />
            </p>
            <p>
                <asp:Label ID="lblSalary" runat="server" Text="$"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
