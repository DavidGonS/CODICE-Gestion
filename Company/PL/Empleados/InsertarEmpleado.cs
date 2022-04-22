using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Company.PL
{
    public partial class InsertarEmpleado : Form
    {
        private SqlConnection connection = new SqlConnection("server=BATTISTA\\DAVIDSERVER; database=company2; integrated security=true");

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
            string fechaIncorporacion = dtpFechaIncorporacion.Value.ToShortDateString();

            string query = "INSERT INTO Empleados(nombre, primerApellido, segundoApellido, email, nombreDepartamento, fechaIncorporacion) " +
                "VALUES('" + nombre + "','" + primerApellido + "','" + segundoApellido + "','" + email + "','" + nombreDepartamento + "','" + fechaIncorporacion + "')";
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

        private void dtpFechaIncorporacion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbNombre.Text = "";
            tbPrimerApellido.Text = "";
            tbSegundoApellido.Text = "";
            tbEmail.Text = "";
            tbNombreDepartamento.Text = "";
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string usuario = lbUsuario.Text;
            MenuEmpleados menu = new MenuEmpleados(usuario);
            menu.Show();
            this.Close();
        }
    }
}
