<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm10.aspx.cs" Inherits="Web.WebForm10" %>

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
            <form class="grilla" id="form1" runat="server">
                <div>
                    <table>
                        <tr>
                            <td>Producto: </td>
                            <td>
                                <asp:TextBox ID="tbProducto" runat="server" Width="172px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Origen: </td>
                            <td>
                                <asp:TextBox ID="tbOrigen" runat="server" Width="172px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Precio: </td>
                            <td>
                                <asp:TextBox ID="tbPrecio" runat="server" Width="172px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Capacidad: </td>
                            <td>
                                <asp:TextBox ID="tbCapacidad" runat="server" Width="172px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Oferta: </td>
                            <td>
                                <asp:TextBox ID="tbOferta" runat="server" Width="172px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Categoria: </td>
                            <td>
                                <asp:TextBox ID="tbCategoria" runat="server" Width="172px"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                    <div class="container">
                        <asp:Button ID="btnLimpiarFiltros" runat="server" OnClick="btnLimpiarFiltros_Click" Text="Limpiar Filtros" />
                        <asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Editar" />
                        <asp:Label ID="lbl_Mensaje" runat="server"></asp:Label>
                    </div>
                </div>
            </form>
        </div>
    </div>

</body>
</html>
