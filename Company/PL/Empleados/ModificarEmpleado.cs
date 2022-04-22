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
    public partial class ModificarEmpleado : Form
    {
        private SqlConnection connection = new SqlConnection("server = BATTISTA\\DAVIDSERVER; database=company2; integrated security = true");

        public ModificarEmpleado()
        {
            InitializeComponent();
        }

        public ModificarEmpleado(string usuario)
        {
            InitializeComponent();
            lbUsuario.Text = usuario;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string id = tbId.Text;

            string query = "SELECT id, nombre, primerApellido, segundoApellido, email, nombreDepartamento " +
                            "FROM Empleados " +
                            "WHERE id='" + id + "'";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                tbNombre.Text = reader["nombre"].ToString();
                tbPrimerApellido.Text = reader["primerApellido"].ToString();
                tbSegundoApellido.Text = reader["segundoApellido"].ToString();
                tbEmail.Text = reader["email"].ToString();
                tbNombreDepartamento.Text = reader["nombreDepartamento"].ToString();
                btModificar.Enabled = true;
            } else
            {
                MessageBox.Show("No existe el empleado con el id: " + id);
            }
            connection.Close();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string id = tbId.Text;
            string nombre = tbNombre.Text;
            string primerApellido = tbPrimerApellido.Text;
            string segundoApellido = tbSegundoApellido.Text;
            string email = tbEmail.Text;
            string nombreDepartamento = tbNombreDepartamento.Text;

            string query = "UPDATE Empleados " +
                            "SET nombre='" + nombre + "', primerApellido='" + primerApellido + "', segundoApellido='" + segundoApellido + "', email='" + email + "', nombreDepartamento='" + nombreDepartamento + "'" +
                            "WHERE id=" + id;
            SqlCommand command = new SqlCommand(query, connection);
            int count = command.ExecuteNonQuery();

            if (count == 1)
            {
                MessageBox.Show("Datos modificados correctamente");
                tbNombre.Text = "";
                tbPrimerApellido.Text = "";
                tbSegundoApellido.Text = "";
                tbEmail.Text = "";
                tbNombreDepartamento.Text = "";
            } else
            {
                MessageBox.Show("No existe el empleado");
            }
            connection.Close();
            btModificar.Enabled = false;
           
        }
    }
}