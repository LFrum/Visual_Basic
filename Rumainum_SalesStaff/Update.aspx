<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Update.aspx.vb" Inherits="Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-weight: bold;
            color: #FFFFFF;
            background-color: #3399FF;
        }
        .auto-style2 {
            text-align: left;
        }
        .auto-style3 {
            text-align: left;
            color: #3399FF;
        }
        .auto-style4 {
            color: #993300;
            background-color: #FFFF66;
        }
    </style>
</head>
<body>
    <form id="frmSalesStaff" runat="server">
    <div>
    
    </div>
        <h1 class="auto-style3">Sales Staff Information</h1>
        <p>
            <asp:DetailsView ID="DetailViewSalesStaff" runat="server" AllowPaging="True" AutoGenerateRows="False" DataKeyNames="ID" DataSourceID="SalesStaffInformation" Height="28px" Width="399px" BorderStyle="Solid" CssClass="auto-style4">
                <Fields>
                    <asp:BoundField DataField="ID" HeaderText="ID" ItemStyle-HorizontalAlign="Right" ReadOnly="True" SortExpression="ID" ><ItemStyle HorizontalAlign="Right"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="Last_Name" HeaderText="Last Name" ItemStyle-HorizontalAlign="Left" ReadOnly="True" SortExpression="Last_Name" ><ItemStyle HorizontalAlign="Left"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="First_Name" HeaderText="First Name" ItemStyle-HorizontalAlign="Left" SortExpression="First_Name" ><ItemStyle HorizontalAlign="Left"></ItemStyle>
                    </asp:BoundField>
                    <asp:CheckBoxField DataField="Full_Time" HeaderText="Full Time" ItemStyle-HorizontalAlign="Center" SortExpression="Full_Time" ><ItemStyle HorizontalAlign="Center"></ItemStyle>
                    </asp:CheckBoxField>
                    <asp:BoundField DataField="Hire_Date" HeaderText="Hire Date" ItemStyle-HorizontalAlign="Right" DataFormatString="{0:d}" SortExpression="Hire_Date" ><ItemStyle HorizontalAlign="Right"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="Salary" HeaderText="Salary" ItemStyle-HorizontalAlign="Right" DataFormatString="{0:C}" SortExpression="Salary" ><ItemStyle HorizontalAlign="Right"></ItemStyle>
                    </asp:BoundField>
                    <asp:CommandField ShowEditButton="True" />
                </Fields>
                <PagerStyle BackColor="#FFCC00" />
            </asp:DetailsView>
        </p>
        <h2>
            <asp:SqlDataSource ID="SalesStaffInformation" runat="server" ConnectionString="<%$ ConnectionStrings:SalesStaffConnectionString %>" DeleteCommand="DELETE FROM [SalesStaff] WHERE [ID] = @ID" InsertCommand="INSERT INTO [SalesStaff] ([ID], [Last_Name], [First_Name], [Full_Time], [Hire_Date], [Salary]) VALUES (@ID, @Last_Name, @First_Name, @Full_Time, @Hire_Date, @Salary)" SelectCommand="SELECT * FROM [SalesStaff]" UpdateCommand="UPDATE [SalesStaff] SET [Last_Name] = @Last_Name, [First_Name] = @First_Name, [Full_Time] = @Full_Time, [Hire_Date] = @Hire_Date, [Salary] = @Salary WHERE [ID] = @ID">
                <DeleteParameters>
                    <asp:Parameter Name="ID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="ID" Type="Int32" />
                    <asp:Parameter Name="Last_Name" Type="String" />
                    <asp:Parameter Name="First_Name" Type="String" />
                    <asp:Parameter Name="Full_Time" Type="Boolean" />
                    <asp:Parameter Name="Hire_Date" Type="DateTime" />
                    <asp:Parameter Name="Salary" Type="Decimal" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Last_Name" Type="String" />
                    <asp:Parameter Name="First_Name" Type="String" />
                    <asp:Parameter Name="Full_Time" Type="Boolean" />
                    <asp:Parameter Name="Hire_Date" Type="DateTime" />
                    <asp:Parameter Name="Salary" Type="Decimal" />
                    <asp:Parameter Name="ID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </h2>
        <p class="auto-style2">
            <strong>
            <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="auto-style1" />
            </strong>
        </p>
    </form>
</body>
</html>