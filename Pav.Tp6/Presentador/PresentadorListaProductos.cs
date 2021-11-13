using Pav.Tp7.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pav.Tp7.AccesoDatos.Servicios;
using Pav.Tp7.Presentacion.Interfaces;
using MiTienda.Dominio.Entidades.Entidades;

namespace Pav.Tp7.Presentador
{
    class PresentadorListaProductos
    {
        private readonly IServicioProducto _servicioProductos = new ServicioProducto();
        private IVistaListaProductos _vistaListaProductos;

        public PresentadorListaProductos(IVistaListaProductos vistaProductos)
        {
            _vistaListaProductos = vistaProductos;
        }

        internal void OnLoad()
        {
            _vistaListaProductos.SetBindingSource(null);
            var productos = _servicioProductos.ObtenerTodos();
            _vistaListaProductos.SetBindingSource(productos);
        }

        internal void AgregarProducto()
        {
            var producto = new VistaProducto(-1);
            producto.ShowDialog();
            OnLoad();

        }

        internal void EditarProducto()
        {
            int codigoProducto = _vistaListaProductos.GetCodigoProductoActual();
            VistaProducto vistaProducto = new VistaProducto(codigoProducto);
            vistaProducto.ShowDialog();
            OnLoad();
        }

        internal void EliminarProducto()
        {
            Producto producto = _vistaListaProductos.GetProductoActual();
            var respuesta = MessageBox.Show("¿Seguro que desea eliminar el Producto?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta.Equals(DialogResult.Yes))
            {
                //producto.Estado = Estado.ELIMINADO;
                _servicioProductos.Modificar(producto);
            }
            OnLoad();
        }
    }
}
