using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Company.PL;

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
            lbUsuario.Text = "User: " + usuario;
        }

        private void btDepartamento_Click(object sender, EventArgs e)
        {
            string usuario = lbUsuario.Text;
            PL.Departamentos.MenuDepartamentos departamentos = new PL.Departamentos.MenuDepartamentos(usuario);
            departamentos.Show();
        }

        private void btEmpleados_Click(object sender, EventArgs e)
        {
            string usuario = lbUsuario.Text;
            MenuEmpleados menu = new MenuEmpleados(usuario);
            menu.Show();
        }
    }
}
