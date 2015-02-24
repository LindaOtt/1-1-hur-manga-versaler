<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Versaler.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hur många versaler?</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Hur många versaler?</h1>
        <asp:TextBox ID="TextBox1" TextMode="MultiLine" cols="20" Rows="2" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Bestäm antalet versaler" OnClick="Button1_Click" /></div>
        <asp:Label ID="Message" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
