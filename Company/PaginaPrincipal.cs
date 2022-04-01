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


namespace Company
{
    public partial class PaginaPrincipal : Form
    {
        private SqlConnection connection = new SqlConnection("server = BATTISTA\\DAVIDSERVER; database=company; integrated security = true");

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
    }
}
