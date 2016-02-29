<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Program.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search</title>
    <asp:HyperLink NavigateUrl="~/Add.aspx" runat="server" Text="Add new Country" ToolTip="Adds new country" />
    <asp:HyperLink NavigateUrl="~/Search.aspx" runat="server" Text="Search for a country" />

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList runat="server" ID="toggleActivebox"
                AutoPostBack="true">
                <asp:ListItem Text="Please select" Value="0" />
                <asp:ListItem Text="Name of country" Value="1" />
                <asp:ListItem Text="Capital of country" Value="2" />
                <asp:ListItem Text="Population" Value="3" />

            </asp:DropDownList>
              <br />
            <asp:Label Text="From" runat="server" Visible="false" ID="FromLabel" />
            <asp:TextBox runat="server" ID="From" Visible="false" />
               <br />
            <asp:Label Text="To" runat="server" Visible="false" ID="ToLabel" />
            <asp:TextBox runat="server" ID="To" Visible="false" />
               <br />
            <asp:Label Text="Write down the word for searching: " runat="server" Visible="false" ID="Search1" />
            <asp:TextBox runat="server" ID="Searching" Visible="false" />
            <asp:Button Text="Search" runat="server" ID="searchBtn" OnClick="searchBtn_Click" />
                <asp:Repeater runat="server" ID="CountryRepeater">
                <ItemTemplate>
                    <div class="book-container">
                        Country:
                    <asp:Label Text='<%# Eval("Name") %>' runat="server" />
                        <br />
                        Capital:
                    <asp:Label Text='<%# Eval("Capital") %>' runat="server" />
                        <br />
                        Populations:
                    <asp:Label Text='<%# Eval("Population") %>' runat="server" />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <br />
              <asp:Label Text="" runat="server" ID="Error" />
        </div>
    </form>
</body>
</html>
