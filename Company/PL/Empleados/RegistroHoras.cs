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
using Company.PL.ExtraWindows;

namespace Company.PL.Empleados
{
    public partial class RegistroHoras : Form
    {
        private SqlConnection connection = new SqlConnection("server = BATTISTA\\DAVIDSERVER; database=company2; integrated security = true");

        public RegistroHoras()
        {
            InitializeComponent();
        }
        public RegistroHoras(string usuario)
        {
            InitializeComponent();
            lbUsuario.Text = usuario;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string id = tbId.Text;
            string query = "select nombre, primerApellido " +
                            "from Empleados " +
                            "where id='" + id + "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                lbNombre.Text = reader["nombre"].ToString();
                lbApellido.Text = reader["primerApellido"].ToString();
            } else
            {
                MessageBox.Show("No existe el empleado con el id " + id);
            }
            connection.Close();
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            connection.Open();
            double horas = Convert.ToInt32(tbHoras.Text);
            string idEmpleado = tbId.Text;
            string fechaImputacion = dtpFechaImputacion.Value.ToShortDateString();

            string query = "insert into RegistroHoras(horas, idEmpleado, fechaImputacion) " +
                            "values('" + horas + "','" + idEmpleado + "','" + fechaImputacion + "')";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Datos introducidos correctamente");

            tbId.Text = "";
            tbHoras.Text = "";
            lbNombre.Text = "";
            lbApellido.Text = "";

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = lbUsuario.Text;
            MenuEmpleados menu = new MenuEmpleados(usuario);
            menu.Show();
            this.Close();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            SalirAplicacion salir = new SalirAplicacion();
            salir.Show();
        }
    }
}
