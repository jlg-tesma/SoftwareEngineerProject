using System.Collections.Generic;

namespace MiTienda.Dominio.Entidades.Entidades
{
    public class Almacen
    {
        public int Id { get; set; }

        public int SucursalId { get; set; }

        public virtual Sucursal Sucursal { get; set; }  //visibilidad

        public ICollection<ProductoAlmacenado> ProductosAlmacenados { get; set; }
    }
}