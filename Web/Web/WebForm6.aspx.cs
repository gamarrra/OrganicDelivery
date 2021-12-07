﻿using System;
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
    public partial class WebForm6 : System.Web.UI.Page
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

        private void MostrarGrilla()
        {
            var productosBLL = new ProductosBLL();
            Grilla.DataSource = productosBLL.MostrarListadoProductosOrdenados();
            Grilla.DataBind();
        }
    }
}