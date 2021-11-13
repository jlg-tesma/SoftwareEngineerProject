using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MiTienda.Dominio.Entidades.Entidades
{
    public class Tienda
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public ICollection<Sucursal> Sucursales { get; set; }
    }
}