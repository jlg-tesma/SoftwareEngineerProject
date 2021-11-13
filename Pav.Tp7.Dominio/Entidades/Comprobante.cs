using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTienda.Dominio.Entidades.Entidades
{
    public class Comprobante
    {
        public int Id { get; set; }

        public string Numero { get; set; }

        public DateTime FechaGenerado { get; set; }

        public int VentaId { get; set; }

        public virtual Venta Venta { get; set; }

        public TipoComprobante TipoComprobante { get; set; }
    }
}
