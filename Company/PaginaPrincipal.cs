using System;
using System.Data.SqlClient;
using System.Linq;

using System.Windows.Forms;


namespace Company
{
    public partial class PaginaPrincipal : Form
    {
        private SqlConnection connection = new SqlConnection("server = BATTISTA\\DAVIDSERVER; database=company2; integrated security = true");

        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string usuario = tbUsuario.Text;
            string contrasena = tbContrasena.Text;
            string query = "SELECT * FROM Usuarios " +
                            "WHERE usuario='" + usuario + "' AND contrasena='" + contrasena + "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                tbUsuario.Text = "";
                tbContrasena.Text = "";

                MenuPrincipal menu = new MenuPrincipal(usuario);
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                tbContrasena.Text = "";
            }
            connection.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
