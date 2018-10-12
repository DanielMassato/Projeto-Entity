<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ClientWebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 64%;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            text-align: right;
            font-weight: normal;
            font-size: medium;
            width: 312px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>Acessando Web Services<table class="auto-style1">
        <tr>
            <td class="auto-style2" colspan="2">DADOS PARA TESTE</td>
        </tr>
        <tr>
            <td class="auto-style3">Nome Com Acento:</td>
            <td>
                <asp:TextBox ID="tbxTexto" runat="server" Width="276px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Tira Acento" Width="190px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Nome Sem Acento:</td>
            <td>
                <asp:Label ID="lblResultado" runat="server" Text="_______________________"></asp:Label>
            </td>
        </tr>
        </table>
        </h2>
    </div>
    </form>
</body>
</html>
