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
            用户头像<br />
            <asp:Image ID="Image1" runat="server" Height="294px" ImageUrl="~/Images/1.jpg" Width="294px" />
            <br />
            选择头像<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="~/Images/1.jpg">头像1</asp:ListItem>
                <asp:ListItem Value="~/Images/2.jpg">头像2</asp:ListItem>
                <asp:ListItem Value="~/Images/3.jpg">头像3</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="提交" />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
