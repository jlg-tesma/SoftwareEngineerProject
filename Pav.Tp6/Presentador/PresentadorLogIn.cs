using Pav.Tp7.Presentacion.Interfaces;
using Pav.Tp7.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.Tp7.Presentacion.Presentador
{
    public class PresentadorLogIn
    {
        private readonly IVistaLogIn _vistaLogIn;
        //private  IVistaPrincipal _vistPrincipal;
        public PresentadorLogIn(IVistaLogIn logIn)
        {
            _vistaLogIn = logIn;
        }

        public bool Autenticado()
        {
            var user = _vistaLogIn.GetUser();
            var pass = _vistaLogIn.GetPassword();

            if (user.Equals("admin") && pass.Equals("admin"))
            {
                RunPrincipalView();
                return true;
            }
            else
                return false;
        }

        private void RunPrincipalView()
        {
            /*
             Lo mejor seria incluir el LogIn en el formulario MDI como lomitante
            e impedir que se lo pueda cerrar hasta estar autenticado
             */
            //if (_vistPrincipal == null)
            //{
                var _vistPrincipal = new VistaPrincipal(){};
            //}
            //_vistPrincipal.Mostrar();
            _vistPrincipal.ShowDialog();
        }
    }
}
