using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4_ENTIDAD
{
    public class EPacientes
    {
        public string rfc { get; set; }
        public string nombre { get; set; }
        public string domicilio { get; set; }
        public string colonia { get; set; }
        public string sexo { get; set; }
        public string enfermedad { get; set; }
        public string habitacion { get; set; }
        public string tipoSangre { get; set; }
        public string colorOjos { get; set; }
        public int peso { get; set; }
        public DateTime fechaIngreso { get; set; }
    }
}