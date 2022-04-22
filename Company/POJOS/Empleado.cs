using System;
using System.Linq;

namespace Company.BLL
{
    class EmpleadoBLL
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string email { get; set; }
        public string nombreDepartamento { get; set; }

        public DateTime fechaIncorporacion { get; set; }
        public DateTime fechaSalida { get; set; }
    }
}
