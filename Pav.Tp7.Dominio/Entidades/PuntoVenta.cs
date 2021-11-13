using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiTienda.Dominio.Entidades.Entidades
{
    public class PuntoVenta
    {
        public int ID { get; set; }

        public int SucursalID { get; set; }

        public virtual Sucursal Sucursal { get; set; } //visivilidad

        public string PuntoVentaNumero { get => PuntoVentaNumero; set => ID.ToString("000"); }
    }
}