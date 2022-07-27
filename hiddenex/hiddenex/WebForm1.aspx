<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="hiddenex.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:HiddenField ID="HiddenField2" runat="server" />
            <br />
            <br />
            <asp:Button ID="Btn1" runat="server" Text="Store" OnClick="Btn1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btn2" runat="server" Text="Load" OnClick="Btn2_Click" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
