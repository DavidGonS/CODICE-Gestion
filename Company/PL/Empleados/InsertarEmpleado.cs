using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Company.PL.ExtraWindows;

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
            int codigoDepartamento = Convert.ToInt32(tbCodigoDepartamento.Text);
            string fechaIncorporacion = dtpFechaIncorporacion.Value.ToShortDateString();

            string query = "INSERT INTO Empleados(nombre, primerApellido, segundoApellido, email, fechaIncorporacion, codigoDepartamento) " +
                "VALUES('" + nombre + "','" + primerApellido + "','" + segundoApellido + "','" + email + "','" + fechaIncorporacion + "','" + codigoDepartamento + "')";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Datos guardados correctamente");

            tbNombre.Text = "";
            tbPrimerApellido.Text = "";
            tbSegundoApellido.Text = "";
            tbEmail.Text = "";
            tbCodigoDepartamento.Text = "";
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
            tbCodigoDepartamento.Text = "";
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            SalirAplicacion salir = new SalirAplicacion();
            salir.Show();
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
