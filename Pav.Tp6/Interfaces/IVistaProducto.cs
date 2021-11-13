using MiTienda.Dominio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Tp7.Presentacion.Interfaces
{
    interface IVistaProducto
    {
        bool CamposValidos();
        Producto ObtenerProductoActual();
        void SetBindingSource(Producto producto);
        void cerrar();
    }
}
