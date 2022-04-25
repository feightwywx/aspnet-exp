<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="课堂练习3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow runat="server" HorizontalAlign="Center" BorderStyle="Double">
                    <asp:TableCell>在线投票</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" HorizontalAlign="Center" BorderStyle="Double">
                    <asp:TableCell>为你喜欢的的东百贵物加油！</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" BorderStyle="Double">
                    <asp:TableCell>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>刀哥</asp:ListItem>
                <asp:ListItem>虎哥</asp:ListItem>
                <asp:ListItem>阴兵五兄弟</asp:ListItem>
            </asp:RadioButtonList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server" HorizontalAlign="Center" BorderStyle="Double">
                    <asp:TableCell>
                        <asp:Button ID="Button1" runat="server" Text="投票" OnClick="Button1_Click" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            
        </div>
    </form>
</body>
</html>
