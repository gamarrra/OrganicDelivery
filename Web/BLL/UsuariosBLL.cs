using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using DAL;
using System.Data;

namespace BLL
{
    public class UsuariosBLL
    {
        public Usuarios Logearse(string Usuario,string Pass)
        {
            var usuarioDAL = new UsuarioDAL();
            var dt = usuarioDAL.MostrarUn(Usuario);
            var usuario = new Usuarios();

            foreach (DataRow dr in dt.Rows)
            {
                usuario.IdUsuario = Int32.Parse(dr["IdUsuario"].ToString());
                usuario.Usuario = dr["Usuario"].ToString();
                usuario.Pass = dr["Pass"].ToString();
                usuario.Tipo = Int32.Parse(dr["Tipo"].ToString());
                usuario.Fin = DateTime.Parse(dr["Fin"].ToString());
                usuario.Habilitado = Int32.Parse(dr["Habilitado"].ToString());
            }
            if(usuario!=null && usuario.Pass == Pass)
            {
                return usuario;
            }

            return null;
            
        }
    }
}
