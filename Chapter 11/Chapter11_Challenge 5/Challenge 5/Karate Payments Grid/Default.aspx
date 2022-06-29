<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Karate Payments Grid</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>
            Payments by Karate Students</h1>
        <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                BorderColor="Blue" BorderStyle="Solid" BorderWidth="1px" 
                DataSourceID="KarateDataSource" Height="23px" Width="640px">
                <Columns>
                    <asp:BoundField DataField="First_Name" HeaderText="First_Name" 
                        SortExpression="First_Name">
                    <HeaderStyle BackColor="#000099" ForeColor="White" HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Last_Name" HeaderText="Last_Name" 
                        SortExpression="Last_Name">
                    <HeaderStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Payment_Date" DataFormatString="{0:d}" 
                        HeaderText="Payment_Date" SortExpression="Payment_Date"></asp:BoundField>
                    <asp:BoundField DataField="Amount" DataFormatString="{0:c}" HeaderText="Amount" 
                        SortExpression="Amount">
                    <HeaderStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                </Columns>
                <HeaderStyle BackColor="#000099" ForeColor="White" />
            </asp:GridView>
            <asp:SqlDataSource ID="KarateDataSource" runat="server" 
                ConnectionString="<%$ ConnectionStrings:KarateConnectionString %>" 
                SelectCommand="SELECT Members.First_Name, Members.Last_Name, Payments.Payment_Date, Payments.Amount FROM Members INNER JOIN Payments ON Members.ID = Payments.Member_Id ORDER BY Members.Last_Name">
            </asp:SqlDataSource>
        </p>
    
    </div>
    </form>
</body>
</html>
