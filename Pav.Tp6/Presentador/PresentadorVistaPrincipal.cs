using Pav.Tp7.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pav.Tp7.Presentador
{
    class PresentadorVistaPrincipal
    {
        private VistaPrincipal _vistaPrincipal;
        private VistaListaProductos _vistaListaProductos;

        public PresentadorVistaPrincipal(VistaPrincipal vista)
        {
            _vistaPrincipal = vista;
        }

        public void InicializarListaProductos(Form lista)
        {
            if (_vistaListaProductos == null)
            {
                _vistaListaProductos = new VistaListaProductos()
                {
                    MdiParent = lista,
                    WindowState = FormWindowState.Maximized
                };
                _vistaListaProductos.VisibleChanged += Vp_VisibleChanged;
            }
            _vistaListaProductos.Show();
        }

        public void Vp_VisibleChanged(object sender, EventArgs e)
        {
            if (_vistaListaProductos.Visible) return;
            _vistaListaProductos.VisibleChanged -= Vp_VisibleChanged;
            _vistaListaProductos = null;
        }
    }
}
