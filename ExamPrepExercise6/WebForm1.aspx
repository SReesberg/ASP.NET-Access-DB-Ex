<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ExamPrepExercise6.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <h1>Viva Voting.com</h1>
        </div>
        <p>
            &nbsp;</p>
        <p>
            Select who you think should be nominated as best super hero of 2010.
            <asp:HyperLink ID="ViewVotesLink" runat="server" CssClass="auto-style1" ForeColor="Blue" NavigateUrl="~/WebForm2.aspx">View Votes</asp:HyperLink>
        </p>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="LabelResult" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LblName" runat="server" Text="Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TBName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="ReqValName" runat="server" ControlToValidate="TBName" ErrorMessage="Please provide your name!" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="LabelID" runat="server" Text="ID:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TBID" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="ReqValID" runat="server" ControlToValidate="TBID" ErrorMessage="Please provide your ID number!" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TBID" ErrorMessage="Your ID number should be 13 digits long!" ForeColor="Red" ValidationExpression="\b[0-9]{13}\b*"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Button ID="BtnVote" runat="server" OnClick="BtnVote_Click" Text="Vote!" />
    </form>
</body>
</html>
