using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company.PL.ExtraWindows
{
    public partial class SalirAplicacion : Form
    {
        public SalirAplicacion()
        {
            InitializeComponent();
        }

        private void btNoSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
