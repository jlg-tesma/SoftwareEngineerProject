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
using Pav.Tp7.Presentacion.Interfaces;
using MiTienda.Dominio.Entidades.Entidades;

namespace Pav.Tp7.Vistas
{
    public partial class VistaProducto : Form, IVistaProducto
    {
        private readonly PresentadorVistaProducto _presentadorVistaProducto;
        public VistaProducto(int codigo)
        {
            InitializeComponent();
            _presentadorVistaProducto = new PresentadorVistaProducto(this, codigo);
        }

        public bool CamposValidos()
        {
            var isValid = string.IsNullOrEmpty(txtCodigo.Text) && string.IsNullOrEmpty(txtDescripcion.Text)
                        && string.IsNullOrEmpty(txtCSI.Text) && string.IsNullOrEmpty(txtPI.Text)
                        && string.IsNullOrEmpty(txtCCI.Text) && string.IsNullOrEmpty(txtMG.Text)
                        && string.IsNullOrEmpty(txtPF.Text) && string.IsNullOrEmpty(txtExistencias.Text);
            if (!isValid)
            {
                if (!int.TryParse(txtCodigo.Text, out _))
                {
                    MessageBox.Show("Codigo solo puede ser Numerico", "Codigo No Valido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else MessageBox.Show("No puede tener campos vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return !isValid;
        }

        public void cerrar()
        {
            this.Dispose();
        }

        public Producto ObtenerProductoActual()
        {
            return (bsProducto.Current as Producto);
        }

        public void SetBindingSource(Producto producto)
        {
            bsProducto.DataSource = producto;
        }

        private void btnGuardarModificar_Click(object sender, EventArgs e)
        {
            _presentadorVistaProducto.Guardar();
        }
    }
}
