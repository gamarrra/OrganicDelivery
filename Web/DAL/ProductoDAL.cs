using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductoDAL
    {
        public DataTable MostrarUn(int Idproducto)
        {
            var oDatos = new datos();
            var parametro1 = new SqlParameter("@PIdproducto", Idproducto);
            var vecParams = new SqlParameter[] { parametro1 };
            return oDatos.MostrarDatatable("select * from Productos where Idproducto=@PIdproducto", vecParams);
        }

        public DataTable MostrarListado()
        {
            var oDatos = new datos();
            return oDatos.MostrarDatatable("select * from Productos", null);
        }
        public DataTable OrdenarListado()
        {
            var oDatos = new datos();
            return oDatos.MostrarDatatable("SELECT * FROM Productos ORDER BY Producto ASC", null);
        }

        public DataTable BuscarCat(string Categoria)
        {
            var oDatos = new datos();
            var parametro3 = new SqlParameter("@PCategoria", Categoria);
            var vecParams = new SqlParameter[] { parametro3 };
            return oDatos.MostrarDatatable("select * from Productos where Categoria=isnull(@PCategoria,Categoria)", vecParams); //aca agregar and u or si queremos que busque donde ambass sean true
        }

        public int Insertar(string Producto, string Capacidad, string Origen, int Precio, string Categoria, string Oferta)
        {
            var oDatos = new datos();

            var parametro2 = new SqlParameter("@PProducto", Producto);
            var parametro3 = new SqlParameter("@PCapacidad", Capacidad);
            var parametro4 = new SqlParameter("@POrigen", Origen);
            var parametro5 = new SqlParameter("@PPrecio", Precio);
            var parametro6 = new SqlParameter("@PCategoria", Categoria);
            var parametro7 = new SqlParameter("@POferta", Oferta);

            var vecParams = new SqlParameter[] { parametro2, parametro3, parametro4, parametro5, parametro6, parametro7 };

            //return (int)oDatos.EjecutarScalar("insert into Producto (Producto,Origen) values (@PProducto,@POrigen); select @@identity", vecParams);//este devuelve el valor autoincremental
            return (int)oDatos.EjecutarSinResultado("insert into Productos (Producto,Capacidad, Origen,Precio,Categoria,Oferta) values (@PProducto,@PCapacidad, @POrigen, @PPrecio, @PCategoria, @POferta)", vecParams);
        }

        public int Modificar(int Idproducto, string Producto, string Capacidad, string Origen, int Precio, string Categoria, string Oferta)
        {
            var oDatos = new datos();
            var parametro = new SqlParameter("@PIdproducto", Idproducto);
            var parametro2 = new SqlParameter("@PProducto", Producto);
            var parametro3 = new SqlParameter("@PCapacidad", Capacidad);
            var parametro4 = new SqlParameter("@POrigen", Origen);
            var parametro5 = new SqlParameter("@PPrecio", Precio);
            var parametro6 = new SqlParameter("@PCategoria", Categoria);
            var parametro7 = new SqlParameter("@POferta", Oferta);

            var vecParams = new SqlParameter[] { parametro2, parametro3, parametro4, parametro5, parametro6, parametro7, parametro };

            return (int)oDatos.EjecutarSinResultado("update Productos set Producto=@PProducto,Capacidad=@PCapacidad,Origen=@POrigen,Precio=@PPrecio,Categoria=@PCategoria,Oferta=@POferta where Idproducto=@PIdproducto", vecParams);
        }

        public int Borrar(int Idproducto)
        {
            var oDatos = new datos();
            var parametro2 = new SqlParameter("@PIdproducto", Idproducto);
            var vecParams = new SqlParameter[] { parametro2 };
            return (int)oDatos.EjecutarSinResultado("delete Productos where Idproducto=@PIdproducto ", vecParams);
        }

        public DataTable BuscarOfe(string Oferta)
        {
            var oDatos = new datos();
            var parametro3 = new SqlParameter("@POferta", Oferta);
            var vecParams = new SqlParameter[] { parametro3 };
            return oDatos.MostrarDatatable("select * from Productos where Oferta=isnull(@POferta,Oferta)", vecParams); //aca agregar and u or si queremos que busque donde ambass sean true
        }
        public DataTable BuscarProd(string Producto)
        {
            var oDatos = new datos();
            Producto = Producto.ToLower();
            var parametro3 = new SqlParameter("@PProducto", Producto);
            var vecParams = new SqlParameter[] { parametro3 };
            return oDatos.MostrarDatatable("select * from Productos where Producto=isnull(@PProducto,Producto)", vecParams); //aca agregar and u or si queremos que busque donde ambass sean true
        }

    }
}

