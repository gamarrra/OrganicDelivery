using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDAL
    {
        public DataTable MostrarUn(string Usuario)
        {
            var oDatos = new datos();
            var parametro1 = new SqlParameter("@PUsuario", Usuario);
            var vecParams = new SqlParameter[] { parametro1 };
            return oDatos.MostrarDatatable("select * from Usuarios where Usuario=@PUsuario", vecParams);
        }
    }
}
