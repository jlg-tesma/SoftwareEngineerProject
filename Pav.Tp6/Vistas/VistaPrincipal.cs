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
using Pav.Tp7.Presentador;
using Pav.Tp7.Vistas;

namespace Pav.Tp7.Vistas
{
    public partial class VistaPrincipal : Form, IVistaPrincipal
    {
        private readonly PresentadorVistaPrincipal _presentador;


        public VistaPrincipal()
        {
            InitializeComponent();
            _presentador = new PresentadorVistaPrincipal(this);
            
        }

        private void VistaPrincipal_Load(object sender, EventArgs e)
        {
           
        }


        private void tsmProductos_Click(object sender, EventArgs e)
        {
            _presentador.InicializarListaProductos(this);
        }

        private void VistaProducto_VisibleChanged(object sender, EventArgs e)
        {
            _presentador.Vp_VisibleChanged(sender,e);
        }

        public void Mostrar()
        {
            this.Show();
        }
    }
}
