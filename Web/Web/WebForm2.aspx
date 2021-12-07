<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Web.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Organic Productos</title>
    <link rel="stylesheet" href="StyleSheet1.css" />
    <style>
        body {
            background-image: url('img/fondo.jfif');
        }
    </style>

</head>


<body>
    <div class="header">
        <h2>Organic Delivery</h2>
        <div class="logo">
            <img src="img/logo.png" alt="Avatar" class="avatar2" />
        </div>
        <div class="navbar">
            <a href="WebForm2.aspx">Home</a>
            <a href="WebForm4.aspx" id="editor" runat="server">Edición</a>
            <a href="WebForm6.aspx">Ordenar por Nombre</a>
            <a href="WebForm8.aspx">Ofertas</a>
            <a href="WebForm9.aspx">Frutas</a>
            <a href="WebForm5.aspx">Verduras</a>
            <a href="WebForm11.aspx">Almacen</a>
            <a href="WebForm7.aspx">Cosmeticos</a>
            <a href="WebForm1.aspx">Salir</a>
        </div>
        <div class="usuario">
            <asp:Label ID="lbl_numero" runat="server"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="column middle">

            <form class="forma" id="form1" runat="server">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Producto"></asp:Label></td>
                        <td>
                            <asp:TextBox ID="tbProducto" runat="server"></asp:TextBox></td>
                    </tr>
                </table>

                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
                <div>
                    <asp:GridView class="grilla" ID="Grilla" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                        <Columns>
                            <asp:BoundField DataField="Idproducto" HeaderText="Idproducto" />
                            <asp:BoundField DataField="Origen" HeaderText="Origen" />
                            <asp:BoundField DataField="Producto" HeaderText="Producto" />
                            <asp:BoundField DataField="Capacidad" HeaderText="Capacidad" />
                            <asp:BoundField DataField="Precio" HeaderText="Precio" />
                        </Columns>
                    </asp:GridView>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
