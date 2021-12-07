using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Usuarios
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }
        public int Tipo { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public int Habilitado { get; set; }

    }
}
