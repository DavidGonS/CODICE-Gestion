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

namespace Company.PL.Departamentos
{
    public partial class ListarDepartamento : Form
    {

        private SqlConnection connection = new SqlConnection("server=BATTISTA\\DAVIDSERVER; database=company2; integrated security=true");


        public ListarDepartamento(string usuario)
        {
            InitializeComponent();
            lbUsuario.Text = usuario;
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            connection.Open();

            string nombreDepartamento = tbNombreDepartamento.Text;

            string query = "SELECT em.nombre, em.primerApellido, em.segundoApellido, em.email, em.NombreDepartamento " +
                            "FROM Empleados em" +
                            "full JOIN Departamentos dep ON em.id=dep.id " +
                            "WHERE dep.nombre='" + nombreDepartamento + "'";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                tbLista.AppendText(Environment.NewLine);

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
            }
            else
            {
                MessageBox.Show("No existe el departamento " + nombreDepartamento);
            }
            connection.Close();
        }
    }
}
