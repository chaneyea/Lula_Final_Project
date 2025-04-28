<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Lula_Final_Project.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <!-- Gabe's Problem 1028 Section -->
        <asp:Button ID="btnShowSolution1028" runat="server" Text="Problem 1028" OnClick="btnShowSolution1028_Click" />
        <br />
        <asp:Label ID="lblDescription1028" runat="server" Font-Bold="true" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblTestCase1028" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblResult1028" runat="server" Text=""></asp:Label>
        </div>
        <!-- Nolan's Problem 65 -->
        <div>
        <asp:Button ID="btnShowSolution65" runat="server" Text="Problem 65" OnClick="btnShowSolution65_Click" />
        <br />
        <asp:Label ID="lblDescription65" runat="server" Font-Bold="true" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblTestCase65" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="lblResult65" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
