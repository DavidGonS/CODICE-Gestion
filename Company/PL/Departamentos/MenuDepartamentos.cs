using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company.PL.Departamentos
{
    public partial class MenuDepartamentos : Form
    {
        public MenuDepartamentos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarDepartamento insertar = new InsertarDepartamento();
            insertar.Show();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            ListarDepartamento listar = new ListarDepartamento();
            listar.Show();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            EliminarDepartamento eliminar = new EliminarDepartamento();
            eliminar.Show();
        }
    }
}
