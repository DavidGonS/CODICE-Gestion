using System;
using System.Data.SqlClient;
using System.Linq;

using System.Windows.Forms;
using Company.PL.ExtraWindows;

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

            string query = "SELECT em.* " +
                            "FROM Empleados em " +
                            "full JOIN Departamentos dep ON em.codigoDepartamento=dep.id " +
                            "WHERE dep.nombreDep='" + nombreDepartamento + "'";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
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
            }
            else
            {
                MessageBox.Show("No existe el departamento " + nombreDepartamento);
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = lbUsuario.Text;
            MenuDepartamentos departamentos = new MenuDepartamentos(usuario);
            departamentos.Show();
            this.Close();
        }

        private void btSalir_Click_1(object sender, EventArgs e)
        {
            SalirAplicacion salir = new SalirAplicacion();
            salir.Show();
        }
    }
}
