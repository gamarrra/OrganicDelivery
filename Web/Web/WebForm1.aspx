<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Organic index</title>
    <link rel="stylesheet" href="StyleSheet1.css" />
    <style>
        body {
            background-image: url('img/fondo.jfif');
        }
    </style>
</head>

<body>
    <form id="form" runat="server">
        <div class="imgcontainer">
            <img src="img/logo.jfif" alt="Avatar" class="avatar" />
        </div>
        <div>
            <div class="container">
                <table class="table">
                    <tr>
                        <td>Usuario: </td>
                        <td>
                            <asp:TextBox ID="tb_usuario" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Password: </td>
                        <td>
                            <asp:TextBox ID="tb_pass" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="container">
                <asp:Button ID="Button1" runat="server" Text="Ingresar" OnClick="button1Clicked" />
                <asp:Label ID="lbl_Mensaje" runat="server"></asp:Label>
            </div>
        </div>

    </form>
</body>
</html>
