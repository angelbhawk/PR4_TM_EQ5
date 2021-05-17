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
            if (Pacien.tipoSangre.Length > 5 || Pacien.tipoSangre.Length <=0) 
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

        public void ModificarPacientes(EPacientes Pacien)
        {
            if (ValidarPaciente(Pacien))
            {
                PacienDatos.UpdatePaciente(Pacien);
            }
        }

        //ObtenerColonia
        public List<EPacientes> ObtenerColonia(string Colonia)
        {
            Mensaje.Clear();
            Mensaje.Clear();
            if (Colonia == "")
            {
                Mensaje.Append("Por favor proporcionar una colonia existente");
            }
            if (Mensaje.Length == 0)
            {
                return PacienDatos.AllPacientesColonia(Colonia);
            }
            return null;
        }

        //ObtenerSexo
        public List<EPacientes> ObtenerSexo(string Sexo)
        {
            Mensaje.Clear();
            Mensaje.Clear();
            if (Sexo == "")
            {
                Mensaje.Append("Por favor proporcionar una sexo existente");
            }
            if (Mensaje.Length == 0)
            {
                return PacienDatos.AllPacientesSexo(Sexo);
            }
            return null;
        }

        //ObtenerEnfermedad
        public List<EPacientes> ObtenerEnfermedad(string Enfermedad)
        {
            Mensaje.Clear();
            Mensaje.Clear();
            if (Enfermedad == "")
            {
                Mensaje.Append("Por favor proporcionar una enfermedad existente");
            }
            if (Mensaje.Length == 0)
            {
                return PacienDatos.AllPacientesEnfermedad(Enfermedad);
            }
            return null;
        }

        //ObtenerTipoDeSangre
        public List<EPacientes> ObtenerTipoDeSangre(string TipoSangre)
        {
            Mensaje.Clear();
            Mensaje.Clear();
            if (TipoSangre == "")
            {
                Mensaje.Append("Por favor proporcionar un tipo de sangre existente");
            }
            if (Mensaje.Length == 0)
            {
                return PacienDatos.AllPacientesTipoSangre(TipoSangre);
            }
            return null;
        }

        //ObtenerColorDEOjos
        public List<EPacientes> ObtenerColorOjos(string ColorOjos)
        {
            Mensaje.Clear();
            Mensaje.Clear();
            if (ColorOjos == "")
            {
                Mensaje.Append("Por favor proporcionar un color de ojos existente");
            }
            if (Mensaje.Length == 0)
            {
                return PacienDatos.AllPacientesColorOjos(ColorOjos);
            }
            return null;
        }

        //ObtenerFechaIngreso
        public List<EPacientes> ObtenerFechaIngreso(DateTime FechaIngreso)
        {
            Mensaje.Clear();
            Mensaje.Clear();
            if (FechaIngreso == null)
            {
                Mensaje.Append("Por favor proporcionar una fecha de ingreso existente");
            }
            if (Mensaje.Length == 0)
            {
                return PacienDatos.AllPacientesFechaIngreso(FechaIngreso);
            }
            return null;
        }
    }
}