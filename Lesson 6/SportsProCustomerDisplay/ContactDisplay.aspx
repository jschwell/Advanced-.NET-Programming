<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContactDisplay.aspx.cs" Inherits="ContactDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SportsPro Contact List</title>
    <link href="Styles/Main.css" rel="stylesheet" />
</head>
<body>
    <header>
        <h2>SportsPro</h2>
        <h3>Sports management software for the sports enthusiast</h3>
    </header>
    <section>
        <form id="form1" runat="server">
            <label>Contact List:</label><br />
            <asp:ListBox ID="lbContacts" runat="server"></asp:ListBox>
            <div id="contactbuttons">
                <asp:Button ID="btnRemove" runat="server" Text="Remove Contact" CssClass="button" OnClick="btnRemove_Click" /><br />
                <asp:Button ID="btnEmpty" runat="server" Text="Empty List" CssClass="button" OnClick="btnEmpty_Click" />
            </div>
            <div id="selectbutton">
                <asp:Button ID="btnSelectMore" runat="server" Text="Select Additional Customers" PostBackUrl="~/CustomerDisplay.aspx" />
            </div>
            <p id="message">
                <asp:Label ID="lblMessage" runat="server" Text="" EnableViewState="False"></asp:Label>
            </p>
        </form>
    </section>
</body>
</html>
