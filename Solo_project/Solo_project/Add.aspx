﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="Solo_project.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add new Student</title>

</head>
<body>
    <div class="navigation">
        <asp:HyperLink NavigateUrl="~/Add.aspx" runat="server" Text="Add new Student" ToolTip="Adds new student to the library" />
        <asp:HyperLink NavigateUrl="~/SearchStudent.aspx" runat="server" Text="Search for a Student" ToolTip="Searchs for a Student by Faculty nummber" />
        <asp:HyperLink NavigateUrl="~/Sorting.aspx" runat="server" Text="View all Students" ToolTip="Sorted" />
    </div>
    <form id="form1" runat="server">
        <div>
            <h3>Enter the info for the student</h3>
            <asp:Label Text="Name:" runat="server" />
            <asp:TextBox runat="server" ID="Nameofstudent" />
             <br />
            <asp:Label Text="Capital:" runat="server" />
            <asp:TextBox runat="server" ID="Capital" /> <br />
            <asp:Label Text="Population:" runat="server" />
            <asp:TextBox runat="server" ID="Population" />
             <br />
            <asp:Button Text="Add" runat="server" ID="button"  />
        </div>
    </form>
</body>
</html>
