<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccountClient.aspx.cs" Inherits="AccountClient.AccountClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" >
  
        <asp:Label ID="Label4" runat="server" Text="Insert the information about the account"></asp:Label>
        <br />
  
        <asp:Label ID="Label1" runat="server" Text="Ballance"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtBallance" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <p>
            <asp:Label ID="Label2" runat="server" Text="Currency"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtCurrency" Text="MKD" runat="server" Enabled="false"></asp:TextBox>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            </p>
        <asp:Label ID="Label3" runat="server" Text="Note"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNote" runat="server"></asp:TextBox>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

      
        
        <p>
            <asp:Button ID="btnCreate" runat="server" OnClick="btnCreate_Click" Text="Create Account" Width="197px" />
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>

      
        
    </form>
</body>
</html>
