using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;
using Web;

namespace Web
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lbl_numero.Text = "Usuario: " + Session["usuario"].ToString();
                MostrarGrilla();
                MuestraBotones();
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


        protected void Grilla_RowCommand(Object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            if (e.CommandName == "BorrarItem")
            {
                var productosBLL = new ProductosBLL();
                productosBLL.BorrarProducto(int.Parse(e.CommandArgument.ToString()));
                MostrarGrilla();
                Response.Redirect("WebForm2.aspx");
            }
            if (e.CommandName == "Editar")
            {
                Session["Idproducto"] = int.Parse(e.CommandArgument.ToString());
                Response.Redirect("WebForm10.aspx");
            }
        }
        private void MostrarGrilla()
        {
            var productosBLL = new ProductosBLL();
            Grilla.DataSource = productosBLL.MostrarListadoProductos();
            Grilla.DataBind();
        }
        protected void button1Clicked(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }


    }
}