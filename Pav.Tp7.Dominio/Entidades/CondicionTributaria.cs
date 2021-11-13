using System.Collections.Generic;

namespace MiTienda.Dominio.Entidades.Entidades
{
    public class CondicionTributaria
    {
        public int  Id { get; set; }

        public string Nombre { get; set; }

        public string Descipcion { get; set; }

        public ICollection<TipoComprobante> TipoComprobanteAsociado { get; set; }

        public virtual Cliente Cliente { get; set; } //visibilidad
    }
}