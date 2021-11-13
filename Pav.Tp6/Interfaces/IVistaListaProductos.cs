using MiTienda.Dominio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Tp7.Presentacion.Interfaces
{
    interface IVistaListaProductos
    {
        void SetBindingSource(IEnumerable<Producto> productos);
        int GetCodigoProductoActual();
        Producto GetProductoActual();
    }
}
