using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.OleDb;
using PR4_ENTIDAD;

namespace PR4_DATOS
{
    public class DPacientes
    {
        string Cnx = ConfigurationManager.ConnectionStrings["CnxPort"].ToString();
        public void Insertar(EPacientes Pacien)
        {
            using (OleDbConnection conx = new OleDbConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "INSERT INTO Paciente(RFC,Nombre,Domicilio," +
                    "Colonia,Sexo,Enfermedad,Habitacion,TipoDeSangre,ColorDeOjos,Peso," +
                    "FechaDeIngreso) VALUES (@rfc, @Nom, @Dom, @Col, @Sexo, @Enfer, @Habi, " +
                    "@TipoSan, @ColOjos, @Peso, @FeIngre)";
                using (OleDbCommand cmd = new OleDbCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@rfc", Pacien.rfc);
                    cmd.Parameters.AddWithValue("@Nom", Pacien.nombre);
                    cmd.Parameters.AddWithValue("@Dom", Pacien.domicilio);
                    cmd.Parameters.AddWithValue("@Col", Pacien.colonia);
                    cmd.Parameters.AddWithValue("@Sexo", Pacien.sexo);
                    cmd.Parameters.AddWithValue("@Enfer", Pacien.enfermedad);
                    cmd.Parameters.AddWithValue("@Habi", Pacien.habitacion);
                    cmd.Parameters.AddWithValue("@TipoSan", Pacien.tipoSangre);
                    cmd.Parameters.AddWithValue("@ColOjos", Pacien.colorOjos);
                    cmd.Parameters.AddWithValue("@Peso", Pacien.peso);
                    cmd.Parameters.AddWithValue("@FeIngre", Pacien.fechaIngreso);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                conx.Close();
            }
        }
        #region AllCosas
        public List<EPacientes> AllPacientes()
        {
            List<EPacientes> Pacientes = new List<EPacientes>();
            using (OleDbConnection conx = new OleDbConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "SELECT * FROM Paciente ORDER BY RFC ASC";
                using (OleDbCommand cmd = new OleDbCommand(sqlquery, conx))
                {
                    OleDbDataReader dtr = cmd.ExecuteReader();
                    while (dtr.Read())
                    {
                        EPacientes Pacien = new EPacientes
                        {
                            rfc = Convert.ToString(dtr["RFC"]),
                            nombre = Convert.ToString(dtr["Nombre"]),
                            domicilio = Convert.ToString(dtr["Domicilio"]),
                            colonia = Convert.ToString(dtr["Colonia"]),
                            sexo = Convert.ToString(dtr["Sexo"]),
                            enfermedad = Convert.ToString(dtr["Enfermedad"]),
                            habitacion = Convert.ToString(dtr["Habitacion"]),
                            tipoSangre = Convert.ToString(dtr["TipoDeSangre"]),
                            colorOjos = Convert.ToString(dtr["ColorDeOjos"]),
                            peso = Convert.ToInt32(dtr["Peso"]),
                            fechaIngreso = Convert.ToDateTime(dtr["FechaDeIngreso"])
                        };
                        Pacientes.Add(Pacien);
                    }
                    cmd.Dispose();
                }
                conx.Close();
            }
            return Pacientes;
        }
        //METODO BUSQUEDA POR COLONIA
        public List<EPacientes> AllPacientesColonia(string Colonia)
        {
            List<EPacientes> Pacientes = new List<EPacientes>();
            using (OleDbConnection conx = new OleDbConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "SELECT * FROM Paciente WHERE Colonia = @Col";
                using (OleDbCommand cmd = new OleDbCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@Col", Colonia);
                    OleDbDataReader dtr = cmd.ExecuteReader();
                    while (dtr.Read())
                    {
                        EPacientes Pacien = new EPacientes
                        {
                            rfc = Convert.ToString(dtr["RFC"]),
                            nombre = Convert.ToString(dtr["Nombre"]),
                            domicilio = Convert.ToString(dtr["Domicilio"]),
                            colonia = Convert.ToString(dtr["Colonia"]),
                            sexo = Convert.ToString(dtr["Sexo"]),
                            enfermedad = Convert.ToString(dtr["Enfermedad"]),
                            habitacion = Convert.ToString(dtr["Habitacion"]),
                            tipoSangre = Convert.ToString(dtr["TipoDeSangre"]),
                            colorOjos = Convert.ToString(dtr["ColorDeOjos"]),
                            peso = Convert.ToInt32(dtr["Peso"]),
                            fechaIngreso = Convert.ToDateTime(dtr["FechaDeIngreso"])
                        };
                        Pacientes.Add(Pacien);
                    }
                    cmd.Dispose();
                }
                conx.Close();
            }
            return Pacientes;
        }

        //BUSQUEDA POR SEXO
        public List<EPacientes> AllPacientesSexo(string Sexo)
        {
            List<EPacientes> Pacientes = new List<EPacientes>();
            using (OleDbConnection conx = new OleDbConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "SELECT * FROM Paciente WHERE Sexo = @Sexo";
                using (OleDbCommand cmd = new OleDbCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@Sexo", Sexo);
                    OleDbDataReader dtr = cmd.ExecuteReader();
                    while (dtr.Read())
                    {
                        EPacientes Pacien = new EPacientes
                        {
                            rfc = Convert.ToString(dtr["RFC"]),
                            nombre = Convert.ToString(dtr["Nombre"]),
                            domicilio = Convert.ToString(dtr["Domicilio"]),
                            colonia = Convert.ToString(dtr["Colonia"]),
                            sexo = Convert.ToString(dtr["Sexo"]),
                            enfermedad = Convert.ToString(dtr["Enfermedad"]),
                            habitacion = Convert.ToString(dtr["Habitacion"]),
                            tipoSangre = Convert.ToString(dtr["TipoDeSangre"]),
                            colorOjos = Convert.ToString(dtr["ColorDeOjos"]),
                            peso = Convert.ToInt32(dtr["Peso"]),
                            fechaIngreso = Convert.ToDateTime(dtr["FechaDeIngreso"])
                        };
                        Pacientes.Add(Pacien);
                    }
                    cmd.Dispose();
                }
                conx.Close();
            }
            return Pacientes;
        }

        //BUSQUEDA POR ENFERMEDAD
        public List<EPacientes> AllPacientesEnfermedad(string Enfermedad)
        {
            List<EPacientes> Pacientes = new List<EPacientes>();
            using (OleDbConnection conx = new OleDbConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "SELECT * FROM Paciente WHERE Enfermedad = @Enfermedad";
                using (OleDbCommand cmd = new OleDbCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@Enfer", Enfermedad);
                    OleDbDataReader dtr = cmd.ExecuteReader();
                    while (dtr.Read())
                    {
                        EPacientes Pacien = new EPacientes
                        {
                            rfc = Convert.ToString(dtr["RFC"]),
                            nombre = Convert.ToString(dtr["Nombre"]),
                            domicilio = Convert.ToString(dtr["Domicilio"]),
                            colonia = Convert.ToString(dtr["Colonia"]),
                            sexo = Convert.ToString(dtr["Sexo"]),
                            enfermedad = Convert.ToString(dtr["Enfermedad"]),
                            habitacion = Convert.ToString(dtr["Habitacion"]),
                            tipoSangre = Convert.ToString(dtr["TipoDeSangre"]),
                            colorOjos = Convert.ToString(dtr["ColorDeOjos"]),
                            peso = Convert.ToInt32(dtr["Peso"]),
                            fechaIngreso = Convert.ToDateTime(dtr["FechaDeIngreso"])
                        };
                        Pacientes.Add(Pacien);
                    }
                    cmd.Dispose();
                }
                conx.Close();
            }
            return Pacientes;
        }

        //BUSQUEDA POR TIPO DE SANGRE
        public List<EPacientes> AllPacientesTipoSangre(string TipoSangre)
        {
            List<EPacientes> Pacientes = new List<EPacientes>();
            using (OleDbConnection conx = new OleDbConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "SELECT * FROM Paciente WHERE TipoDeSangre = @TipoSan";
                using (OleDbCommand cmd = new OleDbCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@TipoSan", TipoSangre);
                    OleDbDataReader dtr = cmd.ExecuteReader();
                    while (dtr.Read())
                    {
                        EPacientes Pacien = new EPacientes
                        {
                            rfc = Convert.ToString(dtr["RFC"]),
                            nombre = Convert.ToString(dtr["Nombre"]),
                            domicilio = Convert.ToString(dtr["Domicilio"]),
                            colonia = Convert.ToString(dtr["Colonia"]),
                            sexo = Convert.ToString(dtr["Sexo"]),
                            enfermedad = Convert.ToString(dtr["Enfermedad"]),
                            habitacion = Convert.ToString(dtr["Habitacion"]),
                            tipoSangre = Convert.ToString(dtr["TipoDeSangre"]),
                            colorOjos = Convert.ToString(dtr["ColorDeOjos"]),
                            peso = Convert.ToInt32(dtr["Peso"]),
                            fechaIngreso = Convert.ToDateTime(dtr["FechaDeIngreso"])
                        };
                        Pacientes.Add(Pacien);
                    }
                    cmd.Dispose();
                }
                conx.Close();
            }
            return Pacientes;
        }

        //BUSQUEDA POR COLOR DE OJOS
        public List<EPacientes> AllPacientesColorOjos(string ColorOjos)
        {
            List<EPacientes> Pacientes = new List<EPacientes>();
            using (OleDbConnection conx = new OleDbConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "SELECT * FROM Paciente WHERE ColorDeOjos = @ColOjos";
                using (OleDbCommand cmd = new OleDbCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@ColOjos", ColorOjos);
                    OleDbDataReader dtr = cmd.ExecuteReader();
                    while (dtr.Read())
                    {
                        EPacientes Pacien = new EPacientes
                        {
                            rfc = Convert.ToString(dtr["RFC"]),
                            nombre = Convert.ToString(dtr["Nombre"]),
                            domicilio = Convert.ToString(dtr["Domicilio"]),
                            colonia = Convert.ToString(dtr["Colonia"]),
                            sexo = Convert.ToString(dtr["Sexo"]),
                            enfermedad = Convert.ToString(dtr["Enfermedad"]),
                            habitacion = Convert.ToString(dtr["Habitacion"]),
                            tipoSangre = Convert.ToString(dtr["TipoDeSangre"]),
                            colorOjos = Convert.ToString(dtr["ColorDeOjos"]),
                            peso = Convert.ToInt32(dtr["Peso"]),
                            fechaIngreso = Convert.ToDateTime(dtr["FechaDeIngreso"])
                        };
                        Pacientes.Add(Pacien);
                    }
                    cmd.Dispose();
                }
                conx.Close();
            }
            return Pacientes;
        }

        //BUSQUEDA POR FECHA DE INGRESO
        public List<EPacientes> AllPacientesFechaIngreso(DateTime FechaIngreso)
        {
            List<EPacientes> Pacientes = new List<EPacientes>();
            using (OleDbConnection conx = new OleDbConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "SELECT * FROM Paciente WHERE FechaDeIngreso = @FeIngre";
                using (OleDbCommand cmd = new OleDbCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@FeIngre", FechaIngreso);
                    OleDbDataReader dtr = cmd.ExecuteReader();
                    while (dtr.Read())
                    {
                        EPacientes Pacien = new EPacientes
                        {
                            rfc = Convert.ToString(dtr["RFC"]),
                            nombre = Convert.ToString(dtr["Nombre"]),
                            domicilio = Convert.ToString(dtr["Domicilio"]),
                            colonia = Convert.ToString(dtr["Colonia"]),
                            sexo = Convert.ToString(dtr["Sexo"]),
                            enfermedad = Convert.ToString(dtr["Enfermedad"]),
                            habitacion = Convert.ToString(dtr["Habitacion"]),
                            tipoSangre = Convert.ToString(dtr["TipoDeSangre"]),
                            colorOjos = Convert.ToString(dtr["ColorDeOjos"]),
                            peso = Convert.ToInt32(dtr["Peso"]),
                            fechaIngreso = Convert.ToDateTime(dtr["FechaDeIngreso"])
                        };
                        Pacientes.Add(Pacien);
                    }
                    cmd.Dispose();
                }
                conx.Close();
            }
            return Pacientes;
        }
        #endregion

        public EPacientes GetPacientes(string Rfc)
        {
            using (OleDbConnection conx = new OleDbConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "SELECT * FROM Paciente WHERE  RFC=@rfc ";
                using (OleDbCommand cmd = new OleDbCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@rfc", Rfc );
                    OleDbDataReader dtr = cmd.ExecuteReader();
                    if (dtr.Read())
                    {
                        EPacientes Pacien = new EPacientes
                        {
                            rfc = Convert.ToString(dtr["RFC"]),
                            nombre = Convert.ToString(dtr["Nombre"]),
                            domicilio = Convert.ToString(dtr["Domicilio"]),
                            colonia = Convert.ToString(dtr["Colonia"]),
                            sexo = Convert.ToString(dtr["Sexo"]),
                            enfermedad = Convert.ToString(dtr["Enfermedad"]),
                            habitacion = Convert.ToString(dtr["Habitacion"]),
                            tipoSangre = Convert.ToString(dtr["TipoDeSangre"]),
                            colorOjos = Convert.ToString(dtr["ColorDeOjos"]),
                            peso = Convert.ToInt32(dtr["Peso"]),
                            fechaIngreso = Convert.ToDateTime(dtr["FechaDeIngreso"])
                        };
                        return Pacien;
                    }
                    cmd.Dispose();
                }
                conx.Close();
            }
            return null;
        }

        //METODO BUSQUEDA POR 

        public void UpdatePaciente(EPacientes Pacien)
        {
            using (OleDbConnection conx = new OleDbConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "UPDATE Paciente SET RFC=@rfc, Nombre=@Nom, Domicilio=@Dom, Colonia=@Col , Sexo=@sexo, Enfermedad=@Enfer, Habitacion=@Habi, TipoDeSangre=@TipoSan, ColorDeOjos=@ColOjos, Peso=@Peso, FechaDeIngreso=@FeIngre  WHERE RFC=@rfc";
                using (OleDbCommand cmd = new OleDbCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@rfc", Pacien.rfc);
                    cmd.Parameters.AddWithValue("@Nom", Pacien.nombre);
                    cmd.Parameters.AddWithValue("@Dom", Pacien.domicilio);
                    cmd.Parameters.AddWithValue("@Col", Pacien.colonia);
                    cmd.Parameters.AddWithValue("@Sexo", Pacien.sexo);
                    cmd.Parameters.AddWithValue("@Enfer", Pacien.enfermedad);
                    cmd.Parameters.AddWithValue("@Habi", Pacien.habitacion);
                    cmd.Parameters.AddWithValue("@TipoSan", Pacien.tipoSangre);
                    cmd.Parameters.AddWithValue("@ColOjos", Pacien.colorOjos);
                    cmd.Parameters.AddWithValue("@Peso", Pacien.peso);
                    cmd.Parameters.AddWithValue("@FeIngre", Pacien.fechaIngreso);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                conx.Close();
            }
        }

        public void EliminarPaciente(string Rfc)
        {
            using (OleDbConnection conx = new OleDbConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "DELETE FROM Paciente WHERE RFC=@rfc";
                using (OleDbCommand cmd = new OleDbCommand(sqlquery, conx))
                {
                    cmd.Parameters.AddWithValue("@rfc", Rfc);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                conx.Dispose();
            }
        }
    }
}
