<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sales Staff</title>
    <style type="text/css">
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="frmLogin" runat="server">
    <div>
    
    </div>
        <h1 style="text-align: center" class="auto-style3">Login Page</h1>
        <p class="auto-style2">
            <span class="auto-style3">E-mail Address :
            </span>
            <asp:TextBox ID="txtEmail" runat="server" Width="350px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvEmptyEmail" runat="server" ControlToValidate="txtEmail" 
                ErrorMessage="An E-mail Must Be Entered." CssClass="auto-style3">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" 
                ErrorMessage="Enter a Valid E-Mail Address." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="auto-style3">
                *</asp:RegularExpressionValidator>
        </p>
        <p class="auto-style2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style3">Zip Code : </span>
            <asp:TextBox ID="txtZipCode" runat="server" Width="350px" TabIndex="1"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvEmptyZipCode" runat="server" ControlToValidate="txtZipCode" ErrorMessage="A Zipcode Must Be Entered" CssClass="auto-style3">*</asp:RequiredFieldValidator>
            <asp:RangeValidator ID="rvZipCode" runat="server" ControlToValidate="txtZipCode" MinimumValue="11111" 
                MaximumValue="99999" Type="Integer" ErrorMessage="The Zipcode Must Be Between 11111 and 99999." CssClass="auto-style3">*</asp:RangeValidator>
        </p>
        <p class="auto-style2">
            <asp:Button ID="btnLogin" runat="server" Text="Login" BackColor="Red" Font-Bold="True" ForeColor="White" TabIndex="2" />
        </p>
        <div class="auto-style2">
            <asp:ValidationSummary ID="vsLoginErrors" runat="server" ForeColor="Red" TabIndex="3" />
        </div>
    </form>
</body>
</html>
