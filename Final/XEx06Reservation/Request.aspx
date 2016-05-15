<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Request.aspx.cs" Inherits="Request" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Reservations</title>
    <link href="Styles/Main.css" rel="stylesheet" />
    <link href="Styles/Request.css" rel="stylesheet" />
</head>
<body>
    <header>
        <h1>Royal Inns and Suites</h1>
        <h2>Where you&rsquo;re always treated like royalty</h2>
    </header>
    <section>
        <form id="form1" runat="server" defaultbutton="btnSubmit" defaultfocus="txtArrivalDate">
            <h1>Reservation Request</h1>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="* means that the field is required." CssClass="validator" />
            <h2>Request data</h2>
            <label class="label">Arrival date</label>
            <asp:TextBox ID="txtArrivalDate" runat="server" TextMode="DateTime"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="*" Display="Dynamic" CssClass="validator" ControlToValidate="txtArrivalDate"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" Text="Must be a valid date" ControlToValidate="txtArrivalDate" Type="Date" Display="Dynamic" CssClass="validator" Operator="DataTypeCheck"></asp:CompareValidator>
            <br />
            <label class="label">Departure date</label>
            <asp:TextBox ID="txtDepartureDate" runat="server" TextMode="DateTime"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Text="*" Display="Dynamic" CssClass="validator" ControlToValidate="txtDepartureDate"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator2" runat="server" Text="Must be after arrival date" ControlToValidate="txtDepartureDate" ControlToCompare="txtArrivalDate" Operator="GreaterThan" Display="Dynamic" CssClass="validator" Type="Date"></asp:CompareValidator>
            <br />
            <label class="label">Number of people</label>
            <asp:DropDownList ID="ddlNumberOfPeople" runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
            </asp:DropDownList>
            <br />          
            <label class="label">Bed type</label>
            <asp:RadioButtonList ID="rblBedType" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>King</asp:ListItem>
                <asp:ListItem>Two Queens</asp:ListItem>
                <asp:ListItem>One Queen</asp:ListItem>
            </asp:RadioButtonList>
            <br />

            <h2>Special requests</h2>
            <asp:TextBox ID="txtRequests" runat="server" TextMode="MultiLine"></asp:TextBox>
            <br />
       
            <h2>Contact information</h2>
            <label class="label">First name</label>
            <asp:TextBox ID="txtFirstName" runat="server" CssClass="entry"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Text="*" Display="Dynamic" CssClass="validator" ControlToValidate="txtFirstName"></asp:RequiredFieldValidator>
            <br />
            <label class="label">Last name</label>
            <asp:TextBox ID="txtLastName" runat="server" CssClass="entry"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Text="*" Display="Dynamic" CssClass="validator" ControlToValidate="txtLastName"></asp:RequiredFieldValidator>
            <br />
            <label class="label">Email address</label>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="entry" TextMode="Email"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Text="*" Display="Dynamic" CssClass="validator" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Text="Must be valid email address" Display="Dynamic" CssClass="validator" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <label class="label">Telephone number</label>
            <asp:TextBox ID="txtPhone" runat="server" CssClass="entry" TextMode="Phone"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Text="*" Display="Dynamic" CssClass="validator" ControlToValidate="txtPhone"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" Text="Use the format: 999-999-9999" Display="Dynamic" CssClass="validator" ControlToValidate="txtPhone" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
            <br />
            <label class="label">Preferred method</label>
            <asp:DropDownList ID="ddlPreferredMethod" runat="server">
                <asp:ListItem>Email</asp:ListItem>
                <asp:ListItem>Telephone</asp:ListItem>
            </asp:DropDownList>
            <br />

            <label class="label">&nbsp;</label>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="button" OnClick="btnSubmit_Click" />&nbsp;
            <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="button" OnClick="btnClear_Click" CausesValidation="False" /><br />
            <p>
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </p>
    </form>
    </section>
    <footer>
        <p>&copy; 2015, Royal Inns and Suites</p>
    </footer>
</body>
</html>
