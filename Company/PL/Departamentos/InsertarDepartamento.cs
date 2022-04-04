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
    public partial class InsertarDepartamento : Form
    {
        private SqlConnection connection = new SqlConnection("server=BATTISTA\\DAVIDSERVER; database=company; integrated security=true");

        public InsertarDepartamento()
        {
            InitializeComponent();
        }

        public InsertarDepartamento(string usuario)
        {
            InitializeComponent();
            lbUsuario.Text = usuario;
        }

        private void btInsertar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string nombre = tbNombreDepartamento.Text;

            string query = "INSERT INTO Departamentos(nombre) " +
                            "VALUES('" + nombre + "')";

            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            MessageBox.Show("Departamento creado correctamente");

            tbNombreDepartamento.Text = "";
            connection.Close();

        }
    }
}
