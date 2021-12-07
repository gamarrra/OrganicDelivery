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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void button1Clicked(object sender, EventArgs e)
        {
            try
            {
                var usuarioBLL = new UsuariosBLL();
                var usuario = usuarioBLL.Logearse(tb_usuario.Text, tb_pass.Text);
                if (usuario != null)
                {
                    Session["usuario"] = usuario.Usuario;
                    Session["tipo"] = usuario.Tipo;
                    Response.Redirect("WebForm2.aspx");
                }
                else
                {
                    lbl_Mensaje.ForeColor = System.Drawing.Color.Red;
                    lbl_Mensaje.Text = "Usuario/Contraseña incorrecta";
                }

            }
            catch (Exception ex)
            {
                lbl_Mensaje.Text = ex.Message.ToString();
            }
        }
    }
}