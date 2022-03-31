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

        private void btInsertar_Click(object sender, EventArgs e)
        {
            InsertarEmpleado insertar = new InsertarEmpleado();
            insertar.Show();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            Empleados.ListarEmpleado listar = new Empleados.ListarEmpleado();
            listar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Empleados.ModificarEmpleado modificar = new Empleados.ModificarEmpleado();
            modificar.Show();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            Empleados.EliminarEmpleado eliminar = new Empleados.EliminarEmpleado();
            eliminar.Show();
        }
    }
}
