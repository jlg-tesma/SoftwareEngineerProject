using Pav.Tp7;
using Pav.Tp7.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pav.Tp7.Presentacion.Interfaces;
using Pav.Tp7.AccesoDatos.Servicios;
using MiTienda.Dominio.Entidades.Entidades;

namespace Pav.Tp7.Presentador
{
    class PresentadorVistaProducto
    {
        private IVistaProducto _vistaProducto;
        private readonly IServicioProducto _ServicioProducto = new ServicioProducto();

        
        public PresentadorVistaProducto(IVistaProducto vistaProducto, int codigo)
        {
            this._vistaProducto = vistaProducto;
            _vistaProducto.SetBindingSource(OperacionDeProducto(codigo));
        }
        private Producto OperacionDeProducto(int codigo)
        {
            if (_ServicioProducto.ObtenerProducto(codigo) == null)
            {
                return new Producto();
            }
            else return _ServicioProducto.ObtenerProducto(codigo);
        }
        public void Guardar()
        {
            if (_vistaProducto.CamposValidos())
            {
                var producto = _vistaProducto.ObtenerProductoActual();
                if (_ServicioProducto.ObtenerProducto(producto.Codigo) == null)
                {
                    try
                    {
                        _ServicioProducto.agregar(producto);
                        MessageBox.Show("Producto agregado", "Operacion Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se puedo guardar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    _ServicioProducto.Modificar(producto);
                    MessageBox.Show("Producto modificado", "Operacion Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                _vistaProducto.cerrar();
            }
        }
    }
}
