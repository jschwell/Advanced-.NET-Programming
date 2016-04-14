<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Wedding Calculator</title>
    <link href="Styles.css" rel="stylesheet" />
</head>
<body>
    <h1>Wedding Calculator</h1>
    <form id="form1" runat="server" defaultbutton="btnCalculate" defaultfocus="txtEventName">
    <div>
        <label for="txtEventName">Event Name</label>
        <asp:TextBox ID="txtEventName" runat="server" CssClass="entry"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter an event name" ControlToValidate="txtEventName" CssClass="validator" Display="Dynamic"></asp:RequiredFieldValidator>
        <br />
        <label for="txtGuests">Number of Guests</label>
        <asp:TextBox ID="txtGuests" runat="server" CssClass="entry"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter the number of guests" ControlToValidate="txtGuests" CssClass="validator" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Enter an integer between 150 and 500" ControlToValidate="txtGuests" CssClass="validator" Display="Dynamic" MaximumValue="500" MinimumValue="150" Type="Integer"></asp:RangeValidator>
        <br />
        <label for="txtDinnerCost">Dinner Estimated Cost per Guest</label>
        <asp:TextBox ID="txtDinnerCost" runat="server" CssClass="entry"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter a dinner cost" ControlToValidate="txtDinnerCost" CssClass="validator" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage="Enter a cost between 0 and 40" ControlToValidate="txtDinnerCost" CssClass="validator" Display="Dynamic" MaximumValue="40" MinimumValue="0" Type="Currency"></asp:RangeValidator>
        <br />
        <label for="txtLimousineCost">Limousine Cost</label>
        <asp:TextBox ID="txtLimousineCost" runat="server" CssClass="entry"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter a limousine cost" ControlToValidate="txtLimousineCost" CssClass="validator" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator3" runat="server" ErrorMessage="Enter a cost between 0 and 5000" ControlToValidate="txtLimousineCost" CssClass="validator" Display="Dynamic" MaximumValue="5000" MinimumValue="0" Type="Currency"></asp:RangeValidator>
        <br />
        <label for="txtMusicCost">Music Cost</label>
        <asp:TextBox ID="txtMusicCost" runat="server" CssClass="entry"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Enter a music cost" ControlToValidate="txtMusicCost" CssClass="validator" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator4" runat="server" ErrorMessage="Enter a cost between 0 and 15000" ControlToValidate="txtMusicCost" CssClass="validator" Display="Dynamic" MaximumValue="15000" MinimumValue="0" Type="Currency"></asp:RangeValidator>
        <br />
        <label for="txtFlowersCost">Flowers Cost</label>
        <asp:TextBox ID="txtFlowersCost" runat="server" CssClass="entry"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Enter a flowers cost" ControlToValidate="txtFlowersCost" CssClass="validator" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator5" runat="server" ErrorMessage="Enter a cost between 0 and 5000" ControlToValidate="txtFlowersCost" CssClass="validator" Display="Dynamic" MaximumValue="5000" MinimumValue="0" Type="Currency"></asp:RangeValidator>
        <br />
        <label for="txtOpenBarCost">Open Bar Estimated Cost per Guest</label>
        <asp:TextBox ID="txtOpenBarCost" runat="server" CssClass="entry"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Enter an open bar cost" ControlToValidate="txtOpenBarCost" CssClass="validator" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator6" runat="server" ErrorMessage="Enter a cost between 0 and 100" ControlToValidate="txtOpenBarCost" CssClass="validator" Display="Dynamic" MaximumValue="100" MinimumValue="0" Type="Currency"></asp:RangeValidator>
        <br />
        <label for="lblTotalCost">Total Cost</label>
        <asp:Label ID="lblTotalCost" runat="server" CssClass="result"></asp:Label>
        <br />
        <asp:Button ID="btnCalculate" runat="server" Text="Calculate" CssClass="button" OnClick="btnCalculate_Click" />
        <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="button" OnClick="btnClear_Click" CausesValidation="False" />
    </div>
    </form>
</body>
</html>
