using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Company.PL.Empleados
{
    public partial class EliminarEmpleado : Form
    {
        private SqlConnection connection = new SqlConnection("server = BATTISTA\\DAVIDSERVER; database=company; integrated security = true");

        public EliminarEmpleado()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string id = tbId.Text;

            string query = "SELECT id, nombre, primerApellido, segundoApellido, email " +
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
                MessageBox.Show("El empleado con id " + id + " ha sido eliminado correctamente");
            } else
            {
                MessageBox.Show("No existe el empleado con id: " + id);
            }
            connection.Close();
            btEliminar.Enabled = false;
        }
    }
}
