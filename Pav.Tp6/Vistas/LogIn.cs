using Pav.Tp7.Presentacion.Interfaces;
using Pav.Tp7.Presentacion.Presentador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pav.Tp7.Presentacion.Vistas
{
    public partial class LogIn : Form, IVistaLogIn
    {
        private readonly PresentadorLogIn _presentadorLogIn;

        public LogIn()
        {
            InitializeComponent();
            _presentadorLogIn = new PresentadorLogIn(this);
        }

        public string GetPassword()
        {
            return passTB.Text;
        }

        public string GetUser()
        {
            return userTB.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            //if (_presentadorLogIn.Autenticado()) this.Dispose();
            _presentadorLogIn.Autenticado();
        }
    }
}
