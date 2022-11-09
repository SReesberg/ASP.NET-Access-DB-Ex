<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ExamPrepExercise6.WebForm2" %>

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
        <div>
            <h2>Current Votes</h2>
        </div>
        <p>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>  
                <div>  
                    <table>  
                     
                        
                        <tr>  
                            <td>Hero</td>  
                            <td><%#Eval("heroName")%></td>  
                        </tr>  
                        <br />
                        <tr>  
                            <td>Votes</td>  
                            <td><%#Eval("voteAmount")%></td>  
                        </tr>  
                       
                        
                    </table>  
                </div>  
            </ItemTemplate>
            </asp:Repeater>
        </p>
        <p>
        </p>
        <p>
        </p>
        <p>
        </p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style1" ForeColor="Blue" NavigateUrl="~/WebForm1.aspx">Return Home</asp:HyperLink>
        </p>
    </form>
</body>
</html>
