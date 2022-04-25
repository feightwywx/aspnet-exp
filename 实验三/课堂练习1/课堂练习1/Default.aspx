<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="课堂练习1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <b>注册通行证</b><br />
            <br />
            姓 名<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            密 码<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            提 问<asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="143px">
                <asp:ListItem>您的出生地</asp:ListItem>
                <asp:ListItem>最喜欢的食物</asp:ListItem>
                <asp:ListItem>最喜欢的A手成员</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            回 答<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" PostBackUrl="~/ConfirmPage.aspx" Text="注册" />
        </div>
    </form>
</body>
</html>
