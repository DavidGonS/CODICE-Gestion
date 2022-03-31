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

        private void btDepartamento_Click(object sender, EventArgs e)
        {
            Departamento departamento = new Departamento();
            departamento.Show();
        }

        private void btEmpleados_Click(object sender, EventArgs e)
        {
            MenuEmpleados menu = new MenuEmpleados();
            menu.Show();
        }
    }
}
