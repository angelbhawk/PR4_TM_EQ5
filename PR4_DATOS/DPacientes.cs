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
        string Cnx = ConfigurationManager.ConnectionStrings["CnxPr4Oldb"].ToString();
        public void Insertar(EPacientes Pacien)
        {
            using (OleDbConnection conx = new OleDbConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "INSERT INTO Paciente(RFC, Nombre, Domicilio, Colonia, Sexo, Enfermedad, Habitación, Tipo de sangre, Color de ojos, Peso, Fecha de ingreso) VALUES (@rfc, @Nom, @Dom, @Col, @Sexo, @Enfer, @Habi, @TipoSan, @ColOjos, @Peso, @FeIngre)";
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
                            rfc = Convert.ToString(dtr["rfc"]),
                            nombre = Convert.ToString(dtr["Nombre"]),
                            domicilio = Convert.ToString(dtr["Domicilio"]),
                            colonia = Convert.ToString(dtr["Colonia"]),
                            sexo = Convert.ToString(dtr["Sexo"]),
                            enfermedad = Convert.ToString(dtr["Enfermedad"]),
                            habitacion = Convert.ToString(dtr["Habitación"]),
                            tipoSangre = Convert.ToString(dtr["Tipo de sangre"]),
                            colorOjos = Convert.ToString(dtr["Color de ojos"]),
                            peso = Convert.ToInt32(dtr["Peso"]),
                            fechaIngreso = Convert.ToDateTime(dtr["Fecha de ingreso"])


                        };
                        Pacientes.Add(Pacien);
                    }
                    cmd.Dispose();
                }
                conx.Close();
            }
            return Pacientes;
        }
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
                            rfc = Convert.ToString(dtr["rfc"]),
                            nombre = Convert.ToString(dtr["Nombre"]),
                            domicilio = Convert.ToString(dtr["Domicilio"]),
                            colonia = Convert.ToString(dtr["Colonia"]),
                            sexo = Convert.ToString(dtr["Sexo"]),
                            enfermedad = Convert.ToString(dtr["Enfermedad"]),
                            habitacion = Convert.ToString(dtr["Habitación"]),
                            tipoSangre = Convert.ToString(dtr["Tipo de sangre"]),
                            colorOjos = Convert.ToString(dtr["Color de ojos"]),
                            peso = Convert.ToInt32(dtr["Peso"]),
                            fechaIngreso = Convert.ToDateTime(dtr["Fecha de ingreso"])
                        };
                        return Pacien;
                    }
                    cmd.Dispose();
                }
                conx.Close();
            }
            return null;
        }
        public void UpdatePaciente(EPacientes Pacien)
        {
            using (OleDbConnection conx = new OleDbConnection(Cnx))
            {
                conx.Open();
                string sqlquery = "UPDATE Paciente SET Nombre=@Nom, Domicilio=@Dom, Colonia=@Col , Sexo=@sexo, Enfermedad=@Enfer, Habitación=@Habi, Tipo de sangre=@TipoSan, Color de ojos=@ColOjos, Peso=@Peso  WHERE RFC=@rfc";
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
                conx.Dispose();
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
