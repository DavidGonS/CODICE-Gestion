
using Company.PL;
using System;
using System.Linq;

using System.Windows.Forms;
using Company.PL.ExtraWindows;

namespace Company
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public MenuPrincipal(string usuario)
        {
            InitializeComponent();
            lbUsuario.Text = usuario;
        }

        private void btDepartamento_Click(object sender, EventArgs e)
        {
            string usuario = lbUsuario.Text;
            PL.Departamentos.MenuDepartamentos departamentos = new PL.Departamentos.MenuDepartamentos(usuario);
            departamentos.Show();
            this.Close();
        }

        private void btEmpleados_Click(object sender, EventArgs e)
        {
            string usuario = lbUsuario.Text;
            MenuEmpleados menu = new MenuEmpleados(usuario);
            menu.Show();
            this.Close();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            SalirAplicacion salir = new SalirAplicacion();
            salir.Show();
        }
    }
}
