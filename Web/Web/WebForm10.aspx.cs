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
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                MuestraBotones();
                try
                {
                    var productoBLL = new ProductosBLL();
                    var producto = productoBLL.MostrarUnProducto(Int32.Parse(Session["Idproducto"].ToString()));
                    if (producto != null)
                    {
                        tbProducto.Text = producto.Producto;
                        tbOrigen.Text = producto.Origen;
                        tbPrecio.Text = producto.Precio.ToString();
                        tbCapacidad.Text = producto.Capacidad;
                        tbCategoria.Text = producto.Categoria;
                        tbOferta.Text = producto.Oferta;
                    }
                    else
                    {
                    }

                    lbl_numero.Text = "Usuario: " + Session["usuario"].ToString();

                }
                catch (Exception ex)
                {
                }
            }
        }
        private void MuestraBotones()
        {
            if (int.Parse(Session["tipo"].ToString()) == 1)
            {
                editor.HRef = "";
            }
            else
            {

            }
        }
        protected void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            try
            {
                tbProducto.Text = "";
                tbOrigen.Text = "";
                tbCapacidad.Text = "";
                tbCategoria.Text = "";
                tbOferta.Text = "";
                tbPrecio.Text = "";
            }
            catch (Exception ex)
            {
            }

        }
        protected void btnModificar_Click(object sender, EventArgs e)
        {
            bool ok = esNumero(tbPrecio.Text.ToString());

            if (ok == true && tbProducto.Text != null && tbCapacidad.Text != null && tbOrigen.Text != null && tbCategoria.Text != null && tbOferta.Text != null)
            {
                var productosBLL = new ProductosBLL();
                var resultado = productosBLL.ModificarProducto(Int32.Parse(Session["Idproducto"].ToString()), tbProducto.Text, tbCapacidad.Text, tbOrigen.Text, Int32.Parse(tbPrecio.Text), tbCategoria.Text, tbOferta.Text);
                Response.Redirect("WebForm2.aspx");
            }
            else
            {
                lbl_Mensaje.Text = "Chequee que el precio sea un numero mayor a cero y todos los campos estén completos";
                lbl_Mensaje.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected bool esNumero(string precio)
        {
            bool esNumero = false;
            int parseado = -1;
            if (int.TryParse(precio, out parseado) && parseado > 0)
            {
                esNumero = true;
            }

            return esNumero;

        }





    }
}
