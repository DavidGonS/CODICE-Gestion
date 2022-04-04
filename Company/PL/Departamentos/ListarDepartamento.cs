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

        private SqlConnection connection = new SqlConnection("server=BATTISTA\\DAVIDSERVER; database=company; integrated security=true");


        public ListarDepartamento(string usuario)
        {
            InitializeComponent();
            lbUsuario.Text = usuario;
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            connection.Open();

            string nombreDepartamento = tbNombreDepartamento.Text;

            string query = "SELECT Empleados.* " +
                            "FROM Empleados " +
                            "INNER JOIN Departamentos ON Empleados.id=Departamentos.id " +
                            "WHERE Empleados.nombreDepartamento='" + nombreDepartamento + "'";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                tbLista.AppendText(reader["Empleados.nombreDepartamento"].ToString());
            }
            else
            {
                MessageBox.Show("No existe el departamento " + nombreDepartamento);
            }
            connection.Close();
        }
    }
}
