<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDisplay.aspx.cs" Inherits="CustomerDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SportsPro Customers</title>
    <link href="Styles/Main.css" rel="stylesheet" />
</head>
<body>
    <header>
        <h2>SportsPro</h2>
        <h3>Sports management software for the sports enthusiast</h3>
    </header>
    <section>
        <form id="form1" runat="server">
            <label>Select a customer:</label>
            <asp:DropDownList ID="ddlCustomer" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="CustomerID" AutoPostBack="True"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:CustomerConnection %>' SelectCommand="SELECT * FROM [Customers] ORDER BY [Name]"></asp:SqlDataSource>
            <table id="customerData">
                <tr>
                    <td><label>Address:</label></td>
                    <td>
                        <asp:Label ID="lblAddress" runat="server" Text=""></asp:Label><br />
                        <asp:Label ID="lblAddress2" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td><label>Phone:</label></td>
                    <td><asp:Label ID="lblPhone" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td><label>Email:</label></td>
                    <td><asp:Label ID="lblEmail" runat="server" Text=""></asp:Label></td>
                </tr>              
            </table>
            <asp:Button ID="btnAdd" runat="server" Text="Add to Contact List" OnClick="btnAdd_Click" />
            <asp:Button ID="btnDisplay" runat="server" Text="Display Contact List" CausesValidation="False" PostBackUrl="~/ContactDisplay.aspx" />
            <p id="message">
                <asp:Label ID="lblMessage" runat="server" Text="" EnableViewState="False"></asp:Label>
            </p>
        </form>
    </section>
</body>
</html>
