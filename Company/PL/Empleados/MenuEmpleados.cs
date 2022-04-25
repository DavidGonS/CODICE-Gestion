using System;
using System.Linq;
using System.Windows.Forms;
using Company.PL.ExtraWindows;

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
            this.Close();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            string usuario = lbUsuario.Text;
            Empleados.ListarEmpleado listar = new Empleados.ListarEmpleado(usuario);
            listar.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string usuario = lbUsuario.Text;
            Empleados.ModificarEmpleado modificar = new Empleados.ModificarEmpleado(usuario);
            modificar.Show();
            this.Close();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            string usuario = lbUsuario.Text;
            Empleados.EliminarEmpleado eliminar = new Empleados.EliminarEmpleado(usuario);
            eliminar.Show();
            this.Close();
        }

        private void MenuEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            SalirAplicacion salir = new SalirAplicacion();
            salir.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = lbUsuario.Text;
            MenuPrincipal menu = new MenuPrincipal(usuario);
            menu.Show();
            this.Close();
        }
    }
}
