using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTienda.Dominio.Entidades.Entidades
{
    public class LineaVenta
    {
        public int ID { get; set; }

        public int VentaID { get; set; }

        public int ProductoID { get; set; }

        public int Cantidad { get; set; }

        public double TotalDeLinea { get; set; }

        public virtual Producto Producto { get; set; }

        public virtual Venta Venta { get; set; }
    }
}
