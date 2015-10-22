<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
    
    </div>
        <h2 style="font-family: Arial, Helvetica, sans-serif">Spy New Assignment Form</h2>
        <p>
            Spy Code Name:&nbsp;
            <asp:TextBox ID="codeNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            New Assignment Name:&nbsp;
            <asp:TextBox ID="assignmentNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            End Date of Previous Assignment:</p>
        <p>
            <asp:Calendar ID="previousAssignmentEndCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            Start Date of New Assignment:</p>
        <p>
            <asp:Calendar ID="newAssignmentStartCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            Projected End Date of New Assignment:</p>
        <p>
            <asp:Calendar ID="newAssignmentEndCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            <asp:Button ID="assignSpyButton" runat="server" OnClick="assignSpyButton_Click" Text="Assign Spy" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
