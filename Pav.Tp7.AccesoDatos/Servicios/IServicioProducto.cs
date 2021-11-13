using MiTienda.Dominio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Tp7.AccesoDatos.Servicios
{
    public interface IServicioProducto
    {
        void agregar(Producto producto);
        void Modificar(Producto producto);
        void Eliminar(Producto producto);
        IEnumerable<Producto> ObtenerTodos();
        Producto ObtenerProducto(int Codigo);
    }
}
