<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sorting.aspx.cs" Inherits="Solo_project.Sorting" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sorting</title>
    <div class="navigation">
        <asp:HyperLink NavigateUrl="~/Add.aspx" runat="server" Text="Add new Student" ToolTip="Adds new student to the library" />
        <asp:HyperLink NavigateUrl="~/SearchStudent.aspx" runat="server" Text="Search for a Student" ToolTip="Searchs for a Student by Faculty nummber" />
        <asp:HyperLink NavigateUrl="~/Sorting.aspx" runat="server" Text="View all Students" ToolTip="Sorted" />
    </div>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <h3>List of all the books in the library</h3>

            <asp:Repeater runat="server" ID="Studenttorepeat">
                <ItemTemplate>
                    <div class="book-container">
                        Name:
                    <asp:Label Text='<%# Eval("Name") %>' runat="server" />
                       &nbsp
                        Faculty:
                    <asp:Label Text='<%# Eval("Faculty") %>' runat="server" />
                        &nbsp
                        Faculty Number:
                    <asp:Label Text='<%# Eval("Faculty_number") %>' runat="server" />
                          &nbsp
                            Avenger:
                    <asp:Label Text='<%# Eval("Avg") %>' runat="server" />
                                 <br />
                        <br />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
    </div>
    </form>
</body>
</html>
