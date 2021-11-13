using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTienda.Dominio.Entidades.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string RazonSocial { get; set; }

        public int? PreCuil { get; set; }

        public int? PostCuil { get; set; }

        public string DNI { get; set; }

        public CondicionTributaria CondicionTributaria { get; set; }

        public ICollection<Venta> ComprasRealizadas { get; set; }

        public ICollection<Pago> PagosRealizados { get; set; }
    }
}
