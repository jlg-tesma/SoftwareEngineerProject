using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MiTienda.Dominio.Entidades.Entidades
{
    public class Sucursal
    {
        public int ID { get; set; }

        public int TiendaID { get; set; }

        public int SucursalNumero { get; set; }

        [Required(ErrorMessage = "No puede ser vacio")]
        public string Direccion { get; set; }

        [StringLength(7, MinimumLength = 6)]
        public string TelefonoFijo
        {
            get => TelefonoFijo;
            set 
            {
                if (int.TryParse(value, out _))
                {
                    TelefonoFijo = value;
                }
            }
        }

        [StringLength(4 , MinimumLength = 4)]
        public string TelefonoCodigoArea 
        { 
            get => TelefonoCodigoArea;
            set
            {
                if (int.TryParse(value, out _))
                {
                    TelefonoCodigoArea = value;
                }
            }
        }

        public ICollection<PuntoVenta> PuntoVenta { get; set; }

        public virtual Tienda Tienda { get; set; } //visivilidad

        public bool EsCasaCentral { get; set; }

        public ICollection<Empleado> Empleados { get; set; }
    }
}