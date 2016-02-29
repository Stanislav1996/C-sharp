<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="Program.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add</title>
     <asp:HyperLink NavigateUrl="~/Add.aspx" runat="server" Text="Add new Country" ToolTip="Adds new country" />
        <asp:HyperLink NavigateUrl="~/Search.aspx" runat="server" Text="Search for a country"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <h3>Enter the info for the country</h3>
            <asp:Label Text="Name:" runat="server" />
            <asp:TextBox runat="server" ID="Country" />
             <br />
            <asp:Label Text="Capital:" runat="server" />
            <asp:TextBox runat="server" ID="Capital" /> 
        <br />
            <asp:Label Text="Population:" runat="server" />
            <asp:TextBox runat="server" ID="Population" />
             <br />
            <asp:Button Text="Add" runat="server" ID="button" Onclick="button_Click" />
         <asp:Label Text="" runat="server" ID="messageLabel" />
    </div>
    </form>
</body>
</html>
