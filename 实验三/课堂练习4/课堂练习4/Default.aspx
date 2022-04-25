<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="课堂练习4.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <b>友情链接</b><br />
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="https://www.sina.com.cn">新浪网</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="https://direcore.xyz">雅虎网</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="https://direcore.xyz">腾讯网</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="LinkButton4" runat="server" PostBackUrl="https://direcore.xyz">淘宝网</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="LinkButton5" runat="server" PostBackUrl="https://direcore.xyz">搜狐网</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="LinkButton6" runat="server" PostBackUrl="https://direcore.xyz">凤凰网</asp:LinkButton>
        </div>
    </form>
</body>
</html>
