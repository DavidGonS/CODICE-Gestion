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

        public MenuDepartamentos(string usuario)
        {
            InitializeComponent();
            lbUsuario.Text = usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = lbUsuario.Text;
            InsertarDepartamento insertar = new InsertarDepartamento(usuario);
            insertar.Show();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            string usuario = lbUsuario.Text;
            ListarDepartamento listar = new ListarDepartamento(usuario);
            listar.Show();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            string usuario = lbUsuario.Text;
            EliminarDepartamento eliminar = new EliminarDepartamento(usuario);
            eliminar.Show();
        }
    }
}
