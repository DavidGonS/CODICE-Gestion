using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company.PL
{
    public partial class MenuEmpleados : Form
    {
        public MenuEmpleados()
        {
            InitializeComponent();
        }

        public MenuEmpleados(string usuario)
        {
            InitializeComponent();
            lbUsuario.Text = usuario;
        }

        private void btInsertar_Click(object sender, EventArgs e)
        {
            string usuario = lbUsuario.Text;
            InsertarEmpleado insertar = new InsertarEmpleado(usuario);
            insertar.Show();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            string usuario = lbUsuario.Text;
            Empleados.ListarEmpleado listar = new Empleados.ListarEmpleado(usuario);
            listar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string usuario = lbUsuario.Text;
            Empleados.ModificarEmpleado modificar = new Empleados.ModificarEmpleado(usuario);
            modificar.Show();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            string usuario = lbUsuario.Text;
            Empleados.EliminarEmpleado eliminar = new Empleados.EliminarEmpleado(usuario);
            eliminar.Show();
        }
    }
}
