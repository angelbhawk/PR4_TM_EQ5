using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PR4_LOGICA;
using PR4_ENTIDAD;

namespace PR5_TM_EQ5
{
    public partial class Acceso : Form
    {
        private EPacientes Pacientes;
        private readonly LPacientes LogPacientes = new LPacientes();

        public Acceso()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            rfc.Text = "RFC";
            nombre.Text = "Nombre";
            domicilio.Text = "Domicilio";
            colonia.Text = "Colonia";
            sexo.Text = "Sexo";
            enfermedad.Text = "Enfermedad";
            habitacion.Text = "Habitación";
            tipoSangre.Text = "Tipo de Sangre";
            colorOjos.Text = "Color de Ojos";
            peso.Value = 70;
            fechaIngreso.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ren = 0;
            List<EPacientes> ListPaciente = LogPacientes.ListaPacientes();
            if (ListPaciente.Count > 0)
            {
                DgvDatos.RowCount = ListPaciente.Count;
                foreach (EPacientes Pa in ListPaciente)
                {
                    DgvDatos[0, ren].Value = Pa.rfc;
                    DgvDatos[1, ren].Value = Pa.nombre;
                    DgvDatos[2, ren].Value = Pa.domicilio;
                    DgvDatos[3, ren].Value = Pa.colonia;
                    DgvDatos[4, ren].Value = Pa.sexo;
                    DgvDatos[5, ren].Value = Pa.enfermedad;
                    DgvDatos[6, ren].Value = Pa.habitacion;
                    DgvDatos[7, ren].Value = Pa.tipoSangre;
                    DgvDatos[8, ren].Value = Pa.colorOjos;
                    DgvDatos[9, ren].Value = Pa.peso;
                    DgvDatos[10, ren].Value = Pa.fechaIngreso;
                    ren++;
                }
            }
            else
                MessageBox.Show("No hay pacientes registrados actualente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (cSelecciona.Text == "(Selecciona)")
                {
                    MessageBox.Show("Selecciona una opcion");
                }
                if (cSelecciona.Text == "Insertar")
                {
                    Pacientes = new EPacientes
                    {
                        rfc = rfc.Text,
                        nombre = nombre.Text,
                        domicilio = domicilio.Text,
                        colonia = colonia.Text,
                        sexo = sexo.Text,
                        enfermedad = enfermedad.Text,
                        habitacion = habitacion.Text,
                        tipoSangre = tipoSangre.Text,
                        colorOjos = colorOjos.Text,
                        peso = (int)peso.Value,
                        fechaIngreso = fechaIngreso.Value
                    };
                    LogPacientes.RegistrarPaciente(Pacientes);
                    if (LogPacientes.Mensaje.Length != 0)
                    {
                        MessageBox.Show(LogPacientes.Mensaje.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Paciente registrado exitosamente");
                        Limpiar();
                    }
                }
                if (cSelecciona.Text == "Eliminar")
                {
                    if (rfc.Text == "RFC")
                        MessageBox.Show("Indica un RFC valido");
                    else
                    {
                        LogPacientes.EliminarPaciente(rfc.Text);
                        if (LogPacientes.Mensaje.Length != 0)
                        {
                            MessageBox.Show(LogPacientes.Mensaje.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Paciente eliminado exitosamente");
                            Limpiar();
                        }
                    }
                }
                if (cSelecciona.Text == "Modificar")
                {
                    Pacientes = new EPacientes
                    {
                        rfc = rfc.Text,
                        nombre = nombre.Text,
                        domicilio = domicilio.Text,
                        colonia = colonia.Text,
                        sexo = sexo.Text,
                        enfermedad = enfermedad.Text,
                        habitacion = habitacion.Text,
                        tipoSangre = tipoSangre.Text,
                        colorOjos = colorOjos.Text,
                        peso = (int)peso.Value,
                        fechaIngreso = fechaIngreso.Value
                    };
                    LogPacientes.ModificarPacientes(Pacientes);
                    if (LogPacientes.Mensaje.Length != 0)
                        MessageBox.Show(LogPacientes.Mensaje.ToString());
                    else
                    {
                        MessageBox.Show("Paciente modificado exitosamente");
                        Limpiar();
                    }
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(string.Format("Error : {0}", ms.Message, "Error Inesperado"));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pacientes = LogPacientes.ObtenerPacientes(rfc.Text);
            try
            {
                DgvDatos.Rows.Clear();
                DgvDatos.Rows.Add(Pacientes.rfc, Pacientes.nombre, Pacientes.domicilio,
                Pacientes.colonia, Pacientes.sexo, Pacientes.enfermedad, Pacientes.habitacion,
                Pacientes.tipoSangre, Pacientes.colorOjos, Pacientes.peso, Pacientes.fechaIngreso);

                rfc.Text = Pacientes.rfc;
                nombre.Text = Pacientes.nombre;
                domicilio.Text = Pacientes.domicilio;
                colonia.Text = Pacientes.colonia;
                sexo.Text = Pacientes.sexo;
                enfermedad.Text = Pacientes.enfermedad;
                habitacion.Text = Pacientes.habitacion;
                tipoSangre.Text = Pacientes.tipoSangre;
                colorOjos.Text = Pacientes.colorOjos;
                peso.Value = Pacientes.peso;
                fechaIngreso.Value = Pacientes.fechaIngreso;
            }
            catch (Exception ms)
            {
                MessageBox.Show("RFC no registrado o no encontrado",ms.Message);
            }
        }
    }
}