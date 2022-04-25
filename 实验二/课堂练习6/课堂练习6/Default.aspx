<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="课堂练习6.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            请输入日期：<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="所输入日期必须在2011-2020年之间" ForeColor="Red" MaximumValue="2020-12-31" MinimumValue="2011-01-01" Type="Date"></asp:RangeValidator>
            <br />
            <asp:Button ID="Button1" runat="server" Text="验证" />
        </div>
    </form>
</body>
</html>
