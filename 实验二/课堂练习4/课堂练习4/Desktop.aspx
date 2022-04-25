<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Desktop.aspx.cs" Inherits="课堂练习4.Desktop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel2" runat="server">
                姓名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                性别：<asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Value="女">男</asp:ListItem>
                    <asp:ListItem Value="男">女</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                出生年月：<asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
                年<asp:DropDownList ID="DropDownList2" runat="server">
                </asp:DropDownList>
                月<br />
                个人爱好：<asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal" Width="600px">
                    <asp:ListItem>唱歌</asp:ListItem>
                    <asp:ListItem>跳舞</asp:ListItem>
                    <asp:ListItem>说唱</asp:ListItem>
                    <asp:ListItem>篮球</asp:ListItem>
                </asp:CheckBoxList>
                <asp:Label ID="Label1" runat="server" Height="146px" Text="个人照片："></asp:Label>
                <asp:Image ID="Image1" runat="server" ImageUrl="~/pic.jpg" Height="128px" Width="128px" ImageAlign="Middle" />
                <br />
                <asp:Button ID="Button1" runat="server" Text="更新照片" OnClick="Button1_Click" />
                <br />
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <br />
                <asp:Button ID="Button2" runat="server" Text="上传" OnClick="Button2_Click" />
                <br />
            </asp:Panel>
            <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center" Visible="false">
                <asp:Table ID="Table1" runat="server" GridLines="Both">
                    <asp:TableRow runat="server" Height="75" Width="300" HorizontalAlign="Center">
                        <asp:TableCell runat="server">姓名：</asp:TableCell>
                        <asp:TableCell runat="server"></asp:TableCell>
                        <asp:TableCell runat="server" RowSpan="3">
                            <asp:Image ID="Image2" ImageUrl="~/pic.jpg" Height="150" Width="150" runat="server" ImageAlign="Middle" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server" Height="75" Width="300" HorizontalAlign="Center">
                        <asp:TableCell runat="server">性别：</asp:TableCell>
                        <asp:TableCell runat="server"></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server" Height="75" Width="300" HorizontalAlign="Center">
                        <asp:TableCell runat="server">出生年月</asp:TableCell>
                        <asp:TableCell runat="server"></asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow runat="server" Height="75" Width="300" HorizontalAlign="Center">
                        <asp:TableCell runat="server">个人爱好</asp:TableCell>
                        <asp:TableCell runat="server" ColumnSpan="2"></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>

                <br />
            </asp:Panel>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">填写个人信息</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">提交查看个人信息</asp:LinkButton>
        </div>
    </form>
</body>
</html>
