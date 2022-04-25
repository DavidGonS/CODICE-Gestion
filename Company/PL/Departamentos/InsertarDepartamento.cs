using System;
using System.Data.SqlClient;
using System.Linq;

using System.Windows.Forms;
using Company.PL.ExtraWindows;

namespace Company.PL.Departamentos
{
    public partial class InsertarDepartamento : Form
    {
        private SqlConnection connection = new SqlConnection("server=BATTISTA\\DAVIDSERVER; database=company2; integrated security=true");

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

            string query = "INSERT INTO Departamentos(nombreDep) " +
                            "VALUES('" + nombre + "')";

            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            MessageBox.Show("Departamento creado correctamente");

            tbNombreDepartamento.Text = "";
            connection.Close();

        }

        private void btSalir_Click_1(object sender, EventArgs e)
        {
            SalirAplicacion salir = new SalirAplicacion();
            salir.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = lbUsuario.Text;
            MenuDepartamentos departamentos = new MenuDepartamentos(usuario);
            departamentos.Show();
            this.Close();
        }
    }
}
