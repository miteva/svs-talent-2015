<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="AccountClient.Manage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <asp:Label ID="lblNote3" runat="server" Text="Account Info"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                                      <asp:Label ID="lblAccountAfterAction" runat="server" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Your Balance: "></asp:Label>
        <asp:Label ID="lblBallance" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblNote0" runat="server" Text="Your Ballance: " Visible="False"></asp:Label>
            <asp:Label ID="lblBallanceAfterAction" runat="server" Visible="False"></asp:Label>
            &nbsp;<div>
    
            <asp:Label ID="Label5" runat="server" Text="Your currency: "></asp:Label>
            <asp:Label ID="lblCurrency" runat="server" Text="Label"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblNote1" runat="server" Text="Your Currency: " Visible="False"></asp:Label>
            <asp:Label ID="lblCurrencyAfterAction" runat="server" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Note: "></asp:Label>
            <asp:Label ID="lblNote" runat="server" Text="Label"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblNote2" runat="server" Text="Note: " Visible="False"></asp:Label>
            <asp:Label ID="lblNoteAfterAction" runat="server" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Choose an action"></asp:Label>
            <asp:DropDownList ID="ddlAction" runat="server">
                <asp:ListItem>Transfer</asp:ListItem>
                <asp:ListItem>Convert</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />

            <asp:Button ID="btnSubmitAction" runat="server" Height="26px" Text="Submit" Width="181px" OnClick="btnSubmitAction_Click" />
    
                <br />
    
            <br />
            <asp:Label ID="lblChooseCurrency" runat="server" Text="Choose currency to convert" Visible="False"></asp:Label>
            <asp:DropDownList ID="ddlConvert" runat="server" Visible="False">
                <asp:ListItem>MKD</asp:ListItem>
                <asp:ListItem>USD</asp:ListItem>
                <asp:ListItem>EU</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="btnSubmitConvert" runat="server" OnClick="Button1_Click" Text="Submit" Visible="False" Width="225px" />
    
                <br />
                <br />
    
    </div>
        <asp:Label ID="lblAmountTransfer" runat="server" Text="Amount" Visible="False"></asp:Label>
        <asp:TextBox ID="txtAmountTransfer" runat="server" Visible="False"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <p>
            <asp:Label ID="lblCurrencyTransfer" runat="server" Text="Currency" Visible="False"></asp:Label>
            <asp:DropDownList ID="ddlCurrency" runat="server" Visible="False">
                <asp:ListItem>MKD</asp:ListItem>
                <asp:ListItem>USD</asp:ListItem>
                <asp:ListItem>EU</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="lblActionTransfer" runat="server" Text="Action" Visible="False"></asp:Label>
            <asp:DropDownList ID="ddlTypeTransfer" runat="server" Visible="False">
                <asp:ListItem>Credit</asp:ListItem>
                <asp:ListItem>Debit</asp:ListItem>
            </asp:DropDownList>

        </p>
        <p>

            <asp:Button ID="btnSubmitTransfer" runat="server" Height="26px" Text="Submit" Width="181px" Visible="False" OnClick="btnSubmitTransfer_Click" />
    
            <asp:Label ID="lblErrorAmount" runat="server"></asp:Label>
    
        </p>
    </form>
</body>
</html>
