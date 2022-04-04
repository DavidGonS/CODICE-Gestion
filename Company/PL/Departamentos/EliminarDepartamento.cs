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
    public partial class EliminarDepartamento : Form
    {
        private SqlConnection connection = new SqlConnection("server=BATTISTA\\DAVIDSERVER; database=company; integrated security=true");

        public EliminarDepartamento()
        {
            InitializeComponent();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string nombreDepartamento = tbNombreDepartamento.Text;

            string query = "DELETE FROM Departamentos " +
                            "WHERE nombre='" + nombreDepartamento + "'";

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
    }
}
