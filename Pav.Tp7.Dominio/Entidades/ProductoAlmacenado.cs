using System;

namespace MiTienda.Dominio.Entidades.Entidades
{
    public class ProductoAlmacenado
    {
        public int Id { get; set; }

        public int AlmacenId { get; set; }

        public virtual Almacen Almacen { get; set; }

        public Producto Producto { get; set; }

        public int Cantidad { get; set; }

        public DateTime FechaAlta { get; set; }
    }
}