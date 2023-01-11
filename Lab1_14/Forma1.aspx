<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Forma1.aspx.cs" Inherits="LD1_14.Forma1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LD_14</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            LD1_14<br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Pradiniai duomenys:"></asp:Label>
            <br />
            <asp:Table ID="Table1" runat="server" ToolTip="Duomenys iš /App_Data/U3.txt">
            </asp:Table>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Atlikti skaičiavimus" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Rezultatai:" Visible="False"></asp:Label>
            <br />
            <asp:Table ID="Table2" runat="server">
            </asp:Table>
            <br />
        </div>
    </form>
</body>
</html>
