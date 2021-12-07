using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;

namespace Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarGrilla();
        }
        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            var productosBLL = new ProductosBLL();
            productosBLL.InsertarProducto(tbProducto.Text, tbCapacidad.Text, tbOrigen.Text, Int32.Parse( tbPrecio.Text),tbCategoria.Text,tbOferta.Text );
            MostrarGrilla();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            var productosBLL = new ProductosBLL();
            var resultado=productosBLL.ModificarProducto(Int32.Parse(tbIdproducto.Text),tbProducto.Text, tbCapacidad.Text, tbOrigen.Text, Int32.Parse(tbPrecio.Text), tbCategoria.Text, tbOferta.Text);
            //en esta capa se hacen las validaciones para "atajar" los problemas"
            if(resultado==0)
            {
                lblError.Text = "No Actualizó ningun registro";
            }
            MostrarGrilla();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var productoBLL = new ProductosBLL();
                GrillaProductos.DataSource = productoBLL.BuscarCat(tbOrigen.Text);
                GrillaProductos.DataBind();
            }
            catch (Exception ex) {
                lblError.Text = ex.Message.ToString();
            }

        }

        protected void btnBuscarUno_Click(object sender, EventArgs e)
        {
            try
            {
                var productoBLL = new ProductosBLL();
                var producto= productoBLL.MostrarUnProducto(Int32.Parse(tbIdproducto.Text));
                if (producto != null)
                {
                    tbProducto.Text = producto.Producto;
                    tbOrigen.Text = producto.Origen;
                    //var lista = new List<Producto>();
                    //lista.add(producto);
                    //GrillaProductos.DataSource = lista;
                    //GrillaProductos.DataBind(); (para mas info mirar video)

                }
                else
                {
                    lblError.Text = "No se encontraron datos con ese ID";
                }

            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message.ToString();
            }

        }


        protected void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            try
            {
                tbIdproducto.Text = "";
                tbProducto.Text = "";
                tbOrigen.Text = "";
                tbCapacidad.Text = "";
                tbCategoria.Text = "";
                tbOferta.Text = "";
                tbPrecio.Text = "";

                MostrarGrilla();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message.ToString();
            }

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            var productosBLL = new ProductosBLL();
            productosBLL.BorrarProducto(Int32.Parse(tbIdproducto.Text));
            MostrarGrilla();
        }
        private void MostrarGrilla()
        {
            var productosBLL = new ProductosBLL();
            GrillaProductos.DataSource = productosBLL.MostrarListadoProductos();
            GrillaProductos.DataBind();
        }

    }
}