using MiTienda.Dominio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Tp7
{
     class DBSimulada
    {
        private static List<Producto> Productos = new List<Producto>();
        public DBSimulada()
        {
            IniciarDB();
        }

        public static void IniciarDB()
        {
            GenerarProductos();
        }

        public static void AddPoducto(Producto producto)
        {
            Productos.Add(producto);
        }

        public static Producto GetProductos(int codigo)
        {
            Producto producto = Productos.Find(x => x.Codigo == codigo);
            return producto;
        }

        private static void GenerarProductos()
        {
            //Productos.Add(new Producto(1010, "Coca Cola 1L", 57, 0.21));
            //Productos.Add(new Producto(1011, "Cafe", 80, 0.21));
            //Productos.Add(new Producto(1111, "Leche", 50, 0.21, 30));
        }
         

        public static List<Producto> GetProductos()
        {
            return Productos;
        }
    }
}
