<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="课堂练习1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 16px; background-color: lightyellow">
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow runat="server" Width="300px">
                    <asp:TableCell runat="server">留言人姓名</asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="name0" runat="server"></asp:TextBox>

                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" Height="300px">
                    <asp:TableCell runat="server">留言内容</asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="comment0" runat="server" TextMode="MultiLine" Rows="5"></asp:TextBox>

                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:Button ID="Button1" runat="server" Text="留言" OnClick="Button1_Click" /></asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:Button ID="Button2" runat="server" Text="重置" OnClick="Button2_Click" /></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
