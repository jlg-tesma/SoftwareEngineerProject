using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTienda.Dominio.Entidades.Entidades
{
    public class Producto
    {
        private double _MargenGanancia = 0;
        private double _PrecioFinal = 0;

        
        public int Id { get; set; }
        public int Codigo { get; set; }

        public string Descripcion { get; set; }

        public double CostoSinIva { get; set; }

        public double PorcentageIva { get; set; }
        public double CostoConIva { get { return CostoSinIva + CostoSinIva * PorcentageIva; } }

        public double MargenGanancia
        {
            get { return _MargenGanancia; }
            set
            {
                _MargenGanancia = value;
            }
        }
        public double PrecioFinal
        {
            get { return CostoConIva + (CostoConIva * _MargenGanancia); }
            set
            {
                _PrecioFinal = value;
                _MargenGanancia = (_PrecioFinal - CostoConIva) / CostoConIva;
            }
        }
        public int RubroId { get; set; }

        public Talle Talle { get; set; }

        public int MarcaId { get; set; }

        public Color Color { get; set; }

        public virtual Rubro Rubro { get; set; } //visibilidad

        public virtual Marca Marca { get; set; } //visibilidad
        //public Producto(int codigo, string descripcion, double costoSinIva, double porcentajeIva)
        //{
            
        //    Codigo = codigo;
        //    Descripcion = descripcion;
        //    CostoSinIva = costoSinIva;
        //    PorcentageIva = porcentajeIva;
        //}
              
    }
}
