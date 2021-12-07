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
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lbl_numero.Text = "Usuario: " + Session["usuario"].ToString();
                MuestraBotones();
                try
                {
                    var productoBLL = new ProductosBLL();
                    Grilla.DataSource = productoBLL.BuscarCat("Almacen");
                    Grilla.DataBind();

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
    }
}