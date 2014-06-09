<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmEditPersonnel.aspx.cs" Inherits="frmEditPersonnel" %>

<!DOCTYPE html>

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
        <br />
        <asp:Label ID="Label1" runat="server" style="text-align: center" Text="Edit Employees"></asp:Label>
        <br />
        <asp:GridView ID="grdEditPersonnel" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" EnableModelValidation="True">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="PayRate" HeaderText="PayRate" SortExpression="PayRate" />
                <asp:BoundField DataField="StartDate" HeaderText="StartDate" SortExpression="StartDate" />
                <asp:BoundField DataField="EndDate" HeaderText="EndDate" SortExpression="EndDate" />
                <asp:CommandField HeaderText="Edit" ShowEditButton="True" ShowHeader="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PayrollSystem_DBConnectionString %>" DeleteCommand="DELETE FROM [tblPersonnel] WHERE [ID] = ?" InsertCommand="INSERT INTO [tblPersonnel] ([ID], [FirstName], [LastName], [PayRate], [StartDate], [EndDate]) VALUES (?, ?, ?, ?, ?, ?)" ProviderName="<%$ ConnectionStrings:PayrollSystem_DBConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [tblPersonnel]" UpdateCommand="UPDATE [tblPersonnel] SET [FirstName] = ?, [LastName] = ?, [PayRate] = ?, [StartDate] = ?, [EndDate] = ? WHERE [ID] = ?">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ID" Type="Int32" />
                <asp:Parameter Name="FirstName" Type="String" />
                <asp:Parameter Name="LastName" Type="String" />
                <asp:Parameter Name="PayRate" Type="Int32" />
                <asp:Parameter Name="StartDate" Type="DateTime" />
                <asp:Parameter Name="EndDate" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="FirstName" Type="String" />
                <asp:Parameter Name="LastName" Type="String" />
                <asp:Parameter Name="PayRate" Type="Int32" />
                <asp:Parameter Name="StartDate" Type="DateTime" />
                <asp:Parameter Name="EndDate" Type="String" />
                <asp:Parameter Name="ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
