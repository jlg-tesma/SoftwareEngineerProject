using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiTienda.Dominio.Entidades.Entidades
{
    public class Venta
    {
        public int ID { get; set; }

        public int PuntoVentaID { get; set; }

        public virtual PuntoVenta PuntoVenta { get; set; } //visibilidad a PuntoVentas

        public double Parcial { get; set; }

        public double Impuesto { get; set; }

        public double Total { get; set; }

        public ICollection<LineaVenta> LineaVentas { get; set; }

        public int EmpleadoId { get; set; }

        public virtual Empleado Empleado { get; set; }  //visibilidad

        public Pago Pago { get; set; }

        public virtual Cliente Cliente { get; set; } //visibilidad
    }
}