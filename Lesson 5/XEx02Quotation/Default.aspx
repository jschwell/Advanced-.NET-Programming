<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Price Quotation</title>
    <link href="Styles.css" rel="stylesheet" />
</head>
<body>
    <h1>Price quotation</h1>
    <form id="form1" runat="server" defaultbutton="btnCalculate" defaultfocus="txtSalesPrice">
    <div>
        <label>Sales Price</label>
        <asp:TextBox ID="txtSalesPrice" runat="server" CssClass="entry"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter a sales price" ControlToValidate="txtSalesPrice" CssClass="validator" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Invalid sales price (must be greater than 0)" Type="Currency" Operator="GreaterThan" ValueToCompare="0" CssClass="validator" Display="Dynamic" ControlToValidate="txtSalesPrice"></asp:CompareValidator>
        <br />
        <label>Discount Percent</label>
        <asp:TextBox ID="txtDiscountPercent" runat="server" CssClass="entry"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter a discount percent" ControlToValidate="txtDiscountPercent" CssClass="validator" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Invalid percent (must be between 0 and 100)" CssClass="validator" ControlToValidate="txtDiscountPercent" Display="Dynamic" MaximumValue="100" MinimumValue="0" Type="Currency"></asp:RangeValidator>
        <br />
        <label>Discount Amount</label>
        <asp:Label ID="lblDiscountAmount" runat="server" CssClass="result"></asp:Label>
        <br />
        <label>Total Price</label>
        <asp:Label ID="lblTotalPrice" runat="server" CssClass="result"></asp:Label>
        <br /> 
        <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" CssClass="button" />
        <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="button" CausesValidation="False" OnClick="btnClear_Click" />
    </div>
    </form>
</body>
</html>
