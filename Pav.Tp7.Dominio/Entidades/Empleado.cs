using MiTienda.Dominio.Entidades.SystemEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiTienda.Dominio.Entidades.Entidades
{
    public class Empleado : User
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public TipoEmpleado TipoEmpleado { get; set; }

        public int? SucursalID { get; set; }

        public virtual Sucursal sucursal { get; set; } //visivilidad a sucursal
    }
}