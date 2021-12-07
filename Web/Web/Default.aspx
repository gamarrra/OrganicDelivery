<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <table>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="ID"></asp:Label></td>
                <td>
                    <asp:TextBox ID="tbIdproducto" runat="server"></asp:TextBox></td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Producto"></asp:Label></td>
                <td>
                    <asp:TextBox ID="tbProducto" runat="server"></asp:TextBox></td>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Origen"></asp:Label></td>
                <td>
                    <asp:TextBox ID="tbOrigen" runat="server"></asp:TextBox></td>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Precio"></asp:Label></td>
                <td>
                    <asp:TextBox ID="tbPrecio" runat="server"></asp:TextBox></td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Capacidad"></asp:Label></td>
                <td>
                    <asp:TextBox ID="tbCapacidad" runat="server"></asp:TextBox></td>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Categoria"></asp:Label></td>
                <td>
                    <asp:TextBox ID="tbCategoria" runat="server"></asp:TextBox></td>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Oferta"></asp:Label></td>
                <td>
                    <asp:TextBox ID="tbOferta" runat="server"></asp:TextBox></td>
                <td>
                    <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
                    <asp:Button ID="btnBuscarUno" runat="server" OnClick="btnBuscarUno_Click" Text="Buscar Uno" />
                    <asp:Button ID="btnInsertar" runat="server" OnClick="btnInsertar_Click" Text="Insertar" />
                    <asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar" />
                    <asp:Button ID="btnBorrar" runat="server" OnClick="btnBorrar_Click" Text="Borrar" />
                    <asp:Button ID="btnLimpiarFiltros" runat="server" OnClick="btnLimpiarFiltros_Click" Text="Limpiar Filtros" />
                </td>

            </tr>
        </table>

        <asp:Label ID="lblError" runat="server" ForeColor="Red" Text=""></asp:Label>



        <br />

        <asp:GridView ID="GrillaProductos" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />

        </asp:GridView>


        <br />


    </form>
</body>
</html>
