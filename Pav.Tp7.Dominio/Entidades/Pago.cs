using System;

namespace MiTienda.Dominio.Entidades.Entidades
{
    public abstract class Pago
    {
        public int Id { get; set; }

        public DateTime FechaCreacion { get; set; }

        public double Monto { get; set; }

        public int VentaId { get; set; }

        public virtual Venta Venta { get; set; } //visibilidad
    }
}