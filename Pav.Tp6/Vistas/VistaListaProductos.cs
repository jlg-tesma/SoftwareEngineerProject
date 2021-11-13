using MiTienda.Dominio.Entidades.Entidades;
using Pav.Tp7.Presentacion.Interfaces;
using Pav.Tp7.Presentador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pav.Tp7.Vistas
{
    public partial class VistaListaProductos : Form, IVistaListaProductos
    {
        private readonly PresentadorListaProductos _presentadorListaProductos;
        public VistaListaProductos()
        {
            InitializeComponent();
            _presentadorListaProductos = new PresentadorListaProductos(this);
        }

        
        private void VistaListaProductos_Load(object sender, EventArgs e)
        {
            _presentadorListaProductos.OnLoad();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            _presentadorListaProductos.EditarProducto();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            _presentadorListaProductos.AgregarProducto();
        }

        
        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            _presentadorListaProductos.EliminarProducto();
        }

        public void SetBindingSource(IEnumerable<Producto> productos)
        {
            productoBindingSource.DataSource = productos;
        }

        public int GetCodigoProductoActual()
        {
            var producto = productoBindingSource.Current as Producto;
            return producto.Codigo;
        }

        public Producto GetProductoActual()
        {
            return productoBindingSource.Current as Producto;
        }
    }
}
