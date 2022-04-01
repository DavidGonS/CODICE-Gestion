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

namespace Company.PL
{
    public partial class InsertarEmpleado : Form
    {
        private SqlConnection connection = new SqlConnection("server=BATTISTA\\DAVIDSERVER; database=company; integrated security=true");

        public InsertarEmpleado()
        {
            InitializeComponent();
        }

        public InsertarEmpleado(string usuario)
        {
            InitializeComponent();
            lbUsuario.Text = usuario;
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string nombre = tbNombre.Text;
            string primerApellido = tbPrimerApellido.Text;
            string segundoApellido = tbSegundoApellido.Text;
            string email = tbEmail.Text;
            string nombreDepartamento = tbNombreDepartamento.Text;

            string query = "INSERT INTO Empleados(nombre, primerApellido, segundoApellido, email, nombreDepartamento) " +
                "VALUES('" + nombre + "','" + primerApellido + "','" + segundoApellido + "','" + email + "','" + nombreDepartamento + "')";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Datos guardados correctamente");

            tbNombre.Text = "";
            tbPrimerApellido.Text = "";
            tbSegundoApellido.Text = "";
            tbEmail.Text = "";
            tbNombreDepartamento.Text = "";
            connection.Close();
        }
    }
}
