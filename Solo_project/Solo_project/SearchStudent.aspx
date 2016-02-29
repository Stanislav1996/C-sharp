<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchStudent.aspx.cs" Inherits="Solo_project.SearchStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Searching</title>
    <div class="navigation">
        <asp:HyperLink NavigateUrl="~/Add.aspx" runat="server" Text="Add new Student" ToolTip="Adds new student to the library" />
        <asp:HyperLink NavigateUrl="~/SearchStudent.aspx" runat="server" Text="Search for a Student" ToolTip="Searchs for a Student by Faculty nummber" />
        <asp:HyperLink NavigateUrl="~/Sorting.aspx" runat="server" Text="View all Students" ToolTip="Sorted" />
    </div>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <h3>Type faculty number of the student</h3>
          <asp:Label Text="Faculty number: " runat="server" />
          <asp:TextBox runat="server" ID="Fac_searching" />
          <asp:Button Text="Search" runat="server" ID="searchBtn" OnClick="searchBtn_Click"/>
       <br />
        <br />
        <br />
          <asp:Label Text="Name of student: " runat="server" />
          <asp:Label Text="" runat="server" ID="Name"/>
            <br />
          <asp:Label Text="Faculty: " runat="server" />
          <asp:Label Text="" runat="server" ID="Faculty"/>
            <br />
          <asp:Label Text="Faculty number: " runat="server" />
          <asp:Label Text="" runat="server" ID="FACnumber"/>
            <br />
         <asp:Label Text="Avenger: " runat="server" />
          <asp:Label Text="" runat="server" ID="Avenger" />
            <br />

    </div>
    </form>
</body>
</html>
