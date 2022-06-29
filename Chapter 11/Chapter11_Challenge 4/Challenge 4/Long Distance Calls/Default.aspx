<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style11
        {
            width: 39%;
        }
        .style8
        {
            width: 179px;
            height: 26px;
            text-align: right;
        }
        .style9
        {
            width: 39%;
            height: 26px;
        }
        .style12
        {
            width: 179px;
            text-align: right;
        }
        .style14
        {
            text-align: center;
        }
        .style10
        {
            width: 179px;
            text-align: left;
        }
        .style13
        {
            width: 39%;
            text-align: left;
        }
        .style35
        {
            height: 26px;
            text-align: right;
        }
        .style37
        {
            text-align: center;
            width: 249px;
        }
        .style38
        {
            width: 249px;
        }
        .style39
        {
            width: 284px;
        }
        .style40
        {
            width: 249px;
            height: 23px;
        }
        .style41
        {
            text-align: left;
        }
        .style42
        {
            color: #FF0000;
        }
        .style43
        {
            height: 319px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
    <div>
    
        <table class="style43">
            <tr>
                <td colspan="2">
                    <h1>
                        Long-Distance Calls</h1>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Panel ID="Panel1" runat="server" GroupingText="Select a Rate Category" 
                        Width="290px">
                        <table class="style39">
                            <tr>
                                <td class="style38">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style38">
                                    <asp:RadioButtonList ID="radCategories" runat="server" CellPadding="2" 
                                        CellSpacing="2" RepeatDirection="Horizontal" Width="279px">
                                        <asp:ListItem Selected="True">Daytime</asp:ListItem>
                                        <asp:ListItem>Evening</asp:ListItem>
                                        <asp:ListItem>Off-Peak</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                            </tr>
                            <tr>
                                <td class="style40">
                                </td>
                            </tr>
                            <tr>
                                <td class="style37">
                                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Details.aspx">View Details</asp:HyperLink>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="style35" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style8">
                    Enter the Number of Minutes:</td>
                <td class="style9">
                    <asp:TextBox ID="txtMinutes" runat="server" Width="50px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style12">
                    Total Charge for the Call:</td>
                <td class="style11">
                    <asp:Label ID="lblTotalCharge" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style14" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10">
                    <asp:Button ID="btnCalculate" runat="server" Height="40px" Text="Calculate" 
                        Width="80px" />
                </td>
                <td class="style13">
                    <asp:Button ID="btnClear" runat="server" Height="40px" Text="Clear" 
                        Width="80px" />
                </td>
            </tr>
            <tr>
                <td class="style41" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style41" colspan="2">
                    <strong>
                    <asp:Label ID="lblMessage" runat="server" CssClass="style42"></asp:Label>
                    </strong>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
