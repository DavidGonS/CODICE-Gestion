using System;
using System.Data.SqlClient;
using System.Linq;

using System.Windows.Forms;
using Company.PL.ExtraWindows;

namespace Company.PL.Empleados
{
    public partial class EliminarEmpleado : Form
    {
        private SqlConnection connection = new SqlConnection("server = BATTISTA\\DAVIDSERVER; database=company2; integrated security = true");

        public EliminarEmpleado()
        {
            InitializeComponent();
        }

        public EliminarEmpleado(string usuario)
        {
            InitializeComponent();
            lbUsuario.Text = usuario;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string id = tbId.Text;

            string query = "SELECT id, nombre, primerApellido, segundoApellido, email, codigoDepartamento " +
                            "FROM Empleados " +
                            "WHERE id='" + id + "'";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                lbNombre.Text = reader["nombre"].ToString();
                lbPrimerApellido.Text = reader["primerApellido"].ToString();
                lbSegundoApellido.Text = reader["segundoApellido"].ToString();
                lbEmail.Text = reader["email"].ToString();
                lbNombreDepartamento.Text = reader["codigoDepartamento"].ToString();
                btEliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No existe el empleado con el id " + id);
            }
            connection.Close();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string id = tbId.Text;

            string query = "DELETE FROM Empleados " +
                            "WHERE id='" + id + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int count = command.ExecuteNonQuery();
            if (count == 1)
            {
                lbNombre.Text = "";
                lbPrimerApellido.Text = "";
                lbSegundoApellido.Text = "";
                lbEmail.Text = "";
                lbNombreDepartamento.Text = "";
                MessageBox.Show("El empleado con id " + id + " ha sido eliminado correctamente");
            }
            else
            {
                MessageBox.Show("No existe el empleado con id: " + id);
            }
            connection.Close();
            btEliminar.Enabled = false;
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            SalirAplicacion salir = new SalirAplicacion();
            salir.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = lbUsuario.Text;
            MenuEmpleados menu = new MenuEmpleados(usuario);
            menu.Show();
            this.Close();
        }
    }
}
