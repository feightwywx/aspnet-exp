<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="课堂练习2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <b>2011年六年级1班班长选举</b>
            <br />
            <br />
            班长候选人<br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem>张无忌</asp:ListItem>
                <asp:ListItem>郭靖</asp:ListItem>
                <asp:ListItem>段誉</asp:ListItem>
                <asp:ListItem>胡斐</asp:ListItem>
                <asp:ListItem>乔峰</asp:ListItem>
                <asp:ListItem>慕容复</asp:ListItem>
                <asp:ListItem>杨过</asp:ListItem>
                <asp:ListItem>潘天鸿</asp:ListItem>
                <asp:ListItem>黄蓉</asp:ListItem>
                <asp:ListItem>赵敏</asp:ListItem>
            </asp:CheckBoxList>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="投票" />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />

        </div>
    </form>
</body>
</html>
