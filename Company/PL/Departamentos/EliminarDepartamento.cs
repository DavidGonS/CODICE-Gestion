using System;
using System.Data.SqlClient;
using System.Linq;

using System.Windows.Forms;
using Company.PL.ExtraWindows;

namespace Company.PL.Departamentos
{
    public partial class EliminarDepartamento : Form
    {
        private SqlConnection connection = new SqlConnection("server=BATTISTA\\DAVIDSERVER; database=company2; integrated security=true");

        public EliminarDepartamento()
        {
            InitializeComponent();
        }

        public EliminarDepartamento(string usuario)
        {
            InitializeComponent();
            lbUsuario.Text = usuario;
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string nombreDepartamento = tbNombreDepartamento.Text;

            string query = "DELETE FROM Departamentos " +
                            "WHERE nombreDep='" + nombreDepartamento + "'";

            SqlCommand command = new SqlCommand(query, connection);
            int count = command.ExecuteNonQuery();
            if (count == 1)
            {
                MessageBox.Show("El departamento " + nombreDepartamento + " ha sido eliminado correctamente");
            }
            else if (nombreDepartamento.Equals(""))
            {
                MessageBox.Show("Debes introducir el nombre del departamento");
            }
            else
            {
                MessageBox.Show("No existe el departamento " + nombreDepartamento);
            }
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
