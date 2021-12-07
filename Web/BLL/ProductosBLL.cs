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
   public class ProductosBLL
    {
        public Productos MostrarUnProducto(int Idproducto)
        {
            var productoDAL = new ProductoDAL();
            var dt = productoDAL.MostrarUn(Idproducto);
            var producto = new Productos();
            
            foreach (DataRow dr in dt.Rows)
            { 
                producto.Idproducto = Int32.Parse(dr["Idproducto"].ToString());
                producto.Producto = dr["Producto"].ToString();
                producto.Capacidad = dr["Capacidad"].ToString();
                producto.Origen = dr["Origen"].ToString();
                producto.Precio = Int32.Parse(dr["Precio"].ToString());
                producto.Categoria = dr["Categoria"].ToString();
                producto.Oferta = dr["Oferta"].ToString();
            }
            return producto;
        }
        
        public List<Productos> MostrarListadoProductos()
        {
            var productoDAL = new ProductoDAL();
            var dt= productoDAL.MostrarListado();
            var ListadoProductos = new List<Productos>();
           
            foreach (DataRow dr in dt.Rows)
            {
                var producto = new Productos();
                producto.Idproducto = Int32.Parse(dr["Idproducto"].ToString());
                producto.Producto = dr["Producto"].ToString();
                producto.Capacidad = dr["Capacidad"].ToString();
                producto.Origen = dr["Origen"].ToString();
                producto.Precio = Int32.Parse( dr["Precio"].ToString());
                producto.Categoria = dr["Categoria"].ToString();
                producto.Oferta = dr["Oferta"].ToString();
                ListadoProductos.Add(producto);
            }

            return ListadoProductos;
        }


        public List<Productos> BuscarCat(string Categoria)
        {
            var productoDAL = new ProductoDAL();
            var dt = productoDAL.BuscarCat(Categoria);
            var ListadoProductos = new List<Productos>();

            foreach (DataRow dr in dt.Rows)
            {
                var producto = new Productos();
                producto.Idproducto = Int32.Parse(dr["Idproducto"].ToString());
                producto.Producto = dr["Producto"].ToString();
                producto.Capacidad = dr["Capacidad"].ToString();
                producto.Origen = dr["Origen"].ToString();
                producto.Precio = Int32.Parse(dr["Precio"].ToString());
                producto.Categoria = dr["Categoria"].ToString();
                producto.Oferta = dr["Oferta"].ToString();
                ListadoProductos.Add(producto);
            }

            return ListadoProductos;
        }

        public int InsertarProducto(string Producto, string Capacidad, string Origen, int Precio, string Categoria, string Oferta)
        {
            var productoDAL = new ProductoDAL();
            return productoDAL.Insertar(Producto, Capacidad, Origen, Precio, Categoria, Oferta);
        }

        public int ModificarProducto(int Idproducto,string Producto, string Capacidad, string Origen, int Precio, string Categoria, string Oferta)
        {
            var productoDAL = new ProductoDAL();
            return productoDAL.Modificar(Idproducto,Producto,Capacidad,Origen,Precio,Categoria,Oferta);
        }

        public int BorrarProducto(int Idproducto)
        {
            var productoDAL = new ProductoDAL();
            return productoDAL.Borrar(Idproducto);
        }

        public List<Productos> MostrarListadoProductosOrdenados()
        {
            var productoDAL = new ProductoDAL();
            var dt = productoDAL.OrdenarListado();
            var ListadoProductos = new List<Productos>();

            foreach (DataRow dr in dt.Rows)
            {
                var producto = new Productos();
                producto.Idproducto = Int32.Parse(dr["Idproducto"].ToString());
                producto.Producto = dr["Producto"].ToString();
                producto.Capacidad = dr["Capacidad"].ToString();
                producto.Origen = dr["Origen"].ToString();
                producto.Precio = Int32.Parse(dr["Precio"].ToString());
                producto.Categoria = dr["Categoria"].ToString();
                producto.Oferta = dr["Oferta"].ToString();
                ListadoProductos.Add(producto);
            }

            return ListadoProductos;
        }
        public List<Productos> BuscarOfe(string Oferta)
        {
            var productoDAL = new ProductoDAL();
            var dt = productoDAL.BuscarOfe(Oferta);
            var ListadoProductos = new List<Productos>();

            foreach (DataRow dr in dt.Rows)
            {
                var producto = new Productos();
                producto.Idproducto = Int32.Parse(dr["Idproducto"].ToString());
                producto.Producto = dr["Producto"].ToString();
                producto.Capacidad = dr["Capacidad"].ToString();
                producto.Origen = dr["Origen"].ToString();
                producto.Precio = Int32.Parse(dr["Precio"].ToString());
                producto.Categoria = dr["Categoria"].ToString();
                producto.Oferta = dr["Oferta"].ToString();
                ListadoProductos.Add(producto);
            }

            return ListadoProductos;
        }

        public List<Productos> BuscarProd(string Producto)
        {
            var productoDAL = new ProductoDAL();
            var dt = productoDAL.BuscarProd(Producto);
            var ListadoProductos = new List<Productos>();

            foreach (DataRow dr in dt.Rows)
            {
                var producto = new Productos();
                producto.Idproducto = Int32.Parse(dr["Idproducto"].ToString());
                producto.Producto = dr["Producto"].ToString();
                producto.Capacidad = dr["Capacidad"].ToString();
                producto.Origen = dr["Origen"].ToString();
                producto.Precio = Int32.Parse(dr["Precio"].ToString());
                producto.Categoria = dr["Categoria"].ToString();
                producto.Oferta = dr["Oferta"].ToString();
                ListadoProductos.Add(producto);
            }

            return ListadoProductos;
        }
    }
}
