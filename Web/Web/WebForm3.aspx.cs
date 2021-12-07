using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;
using ENTIDADES;


namespace Web
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_numero.Text = "Usuario: " + Session["usuario"].ToString();
            MuestraBotones();
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
        protected void button1Clicked(object sender, EventArgs e)
        {
            bool ok = esNumero(tbPrecio.Text.ToString());

            if (ok == true && tbProducto.Text != null && tbCapacidad.Text != null && tbOrigen.Text != null && tbCategoria.Text != null && tbOferta.Text != null)
            {
                var productosBLL = new ProductosBLL();
            productosBLL.InsertarProducto(tbProducto.Text, tbCapacidad.Text, tbOrigen.Text, Int32.Parse(tbPrecio.Text), tbCategoria.Text, tbOferta.Text);
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
            if (int.TryParse(precio, out parseado)&&parseado>0)
            {
                esNumero = true;
            }

            return esNumero;

        }






    }
}
