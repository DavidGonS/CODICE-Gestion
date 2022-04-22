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
    public partial class ListarEmpleado : Form
    {
        private SqlConnection connection = new SqlConnection("server=BATTISTA\\DAVIDSERVER; database=company2; integrated security=true");

        public ListarEmpleado()
        {
            InitializeComponent();
        }

        public ListarEmpleado(string usuario)
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
                

                tbLista.AppendText("ID: ");
                tbLista.AppendText(reader["id"].ToString());
                tbLista.AppendText(Environment.NewLine);

                tbLista.AppendText("Nombre: ");
                tbLista.AppendText(reader["nombre"].ToString());
                tbLista.AppendText(Environment.NewLine);

                tbLista.AppendText("Primer Apellido: ");
                tbLista.AppendText(reader["primerApellido"].ToString());
                tbLista.AppendText(Environment.NewLine);

                tbLista.AppendText("Segundo Apellido: ");
                tbLista.AppendText(reader["segundoApellido"].ToString());
                tbLista.AppendText(Environment.NewLine);

                tbLista.AppendText("Email: ");
                tbLista.AppendText(reader["email"].ToString());
                tbLista.AppendText(Environment.NewLine);

                tbLista.AppendText("Nombre Departamento: ");
                tbLista.AppendText(reader["nombreDepartamento"].ToString());
                tbLista.AppendText(Environment.NewLine);

                tbLista.AppendText(Environment.NewLine);

            }
            else
            {
                MessageBox.Show("No existe el empleado con el id: " + id);
            }
            connection.Close();
        }

        private void btBuscarFecha_Click(object sender, EventArgs e)
        {
            connection.Open();
            string fechaDesde = dtpDesde.Value.Date.ToString();
            string fechaHasta = dtpHasta.Value.Date.ToString();

            string query = "SELECT id, nombre, primerApellido, segundoApellido, email, nombreDepartamento, fechaIncorporacion " +
                "from empleados " +
                "where fechaIncorporacion between '" + fechaDesde + "' and '" + fechaHasta + "'"   ;

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {

                tbLista.AppendText("ID: ");
                tbLista.AppendText(reader["id"].ToString());
                tbLista.AppendText(Environment.NewLine);

                tbLista.AppendText("Nombre: ");
                tbLista.AppendText(reader["nombre"].ToString());
                tbLista.AppendText(Environment.NewLine);

                tbLista.AppendText("Primer Apellido: ");
                tbLista.AppendText(reader["primerApellido"].ToString());
                tbLista.AppendText(Environment.NewLine);

                tbLista.AppendText("Segundo Apellido: ");
                tbLista.AppendText(reader["segundoApellido"].ToString());
                tbLista.AppendText(Environment.NewLine);

                tbLista.AppendText("Email: ");
                tbLista.AppendText(reader["email"].ToString());
                tbLista.AppendText(Environment.NewLine);

                tbLista.AppendText("Nombre Departamento: ");
                tbLista.AppendText(reader["nombreDepartamento"].ToString());
                tbLista.AppendText(Environment.NewLine);

                tbLista.AppendText("Fecha Incorporacion: ");
                tbLista.AppendText(reader["fechaIncorporacion"].ToString());
                tbLista.AppendText(Environment.NewLine);

                tbLista.AppendText(Environment.NewLine);
            } else
            {
                MessageBox.Show("No existen datos para estas fechas");
            }
            connection.Close();
        }
    }
}
