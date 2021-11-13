using MiTienda.Dominio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Tp7.AccesoDatos.Servicios
{
    public class ServicioProducto : IServicioProducto
    {
        public void agregar(Producto producto)
        {
            using (var db = new MiTiendaContexto())
            {
                db.Producto.Add(producto);
                db.SaveChanges();
            }
        }

        public void Eliminar(Producto producto)
        {
            using (var db = new MiTiendaContexto())
            {
                db.Producto.Remove(producto);
                db.SaveChanges();
            }
        }

        public void Modificar(Producto producto)
        {
            using (var db = new MiTiendaContexto())
            {
                var product = db.Producto.Where(x => x.Codigo == producto.Codigo).FirstOrDefault();
                product = producto;
                db.Producto.AddOrUpdate(product);
                db.SaveChanges();
            }
        }

        public Producto ObtenerProducto(int Codigo)
        {
            using (var db = new MiTiendaContexto())
            {
                return (Producto)db.Producto.Where(x => x.Codigo == Codigo).FirstOrDefault();
            }
        }

        public IEnumerable<Producto> ObtenerTodos()
        {
            using (var db = new MiTiendaContexto())
            {
                return db.Producto.ToArray();
            }
        }
    }
}
