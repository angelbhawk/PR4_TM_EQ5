using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR4_DATOS;
using PR4_ENTIDAD;

namespace PR4_LOGICA
{
    public class LPacientes
    {
        private DPacientes PacienDatos = new DPacientes();
        public readonly StringBuilder Mensaje = new StringBuilder();

        private bool ValidarPaciente(EPacientes Pacien)
        {
            Mensaje.Clear();
            if (string.IsNullOrEmpty(Pacien.nombre))
            {
                Mensaje.Append("El campo Nombre es obligatorio");

            }
            if (string.IsNullOrEmpty(Pacien.domicilio))
            {
                Mensaje.Append(Environment.NewLine + "El campo Domicilio es obligatorio");
            }
            if (Pacien.peso <= 0)
            {
                Mensaje.Append(Environment.NewLine + "El campo Peso es debe ser mayor a cero y obligatorio");
            }
            if (Pacien.tipoSangre.Length > 4 || Pacien.tipoSangre.Length <=0) 
            {
                Mensaje.Append(Environment.NewLine + "El campo tipo de sangre no puede dejarse en blanco o contener más de 4 caracteres");
            }
            return Mensaje.Length == 0;
        }

        public void RegistrarPaciente(EPacientes Pacien)
        {
            Mensaje.Clear();
            if (ValidarPaciente(Pacien))
            {
                if (PacienDatos.GetPacientes(Pacien.rfc) == null)
                {
                    PacienDatos.Insertar(Pacien);
                }
                else
                {
                    Mensaje.Append("RFC del paciente ya dado de alta en la B.D.");
                }
            }
        }

        public List<EPacientes> ListaPacientes()
        {
            return PacienDatos.AllPacientes();
        }

        public EPacientes ObtenerPacientes(string RFC)
        {
            Mensaje.Clear();
            Mensaje.Clear();
            if (RFC == "")
            {
                Mensaje.Append("por favor proporcionar un RFC valido");
            }
            if (Mensaje.Length == 0)
            {
                return PacienDatos.GetPacientes(RFC);
            }
            return null;
        }

        public void EliminarPaciente(string RFC)
        {
            Mensaje.Clear();
            if (RFC == "")
            {
                Mensaje.Append("por favor proporcionar un RFC valido");
            }
            if (Mensaje.Length == 0)
            {
                PacienDatos.EliminarPaciente(RFC);
            }
        }

        public void ModificarAlumnos(EPacientes Pacien)
        {
            if (ValidarPaciente(Pacien))
            {
                PacienDatos.UpdatePaciente(Pacien);
            }
        }
    }
}