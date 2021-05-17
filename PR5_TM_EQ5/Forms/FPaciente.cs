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

namespace PR5_TM_EQ5.Forms
{
    public partial class FPaciente : Form
    {
        private EPacientes Pacientes;
        private readonly LPacientes LogPacientes = new LPacientes();
        private string srfc;

        public string Srfc { get => srfc; set => srfc = value; }

        public FPaciente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lblTipo.Text == "Registrar paciente")
            {
                Registrar();
            }
            else
            {
                Modificar();
            }
        }

        private void Registrar()
        {
            try
            {
                Pacientes = new EPacientes
                {
                    rfc = tbxRFC.Text, //1 string
                    nombre = tbxNombre.Text, // 2 string
                    domicilio = tbxDomicilio.Text, // 3 string
                    colonia = cbxColonia.SelectedItem.ToString(), // 4 string item
                    sexo = cbxSexo.SelectedItem.ToString(), // 5 string item
                    enfermedad = cbxEnfermedad.SelectedItem.ToString(), // 6 string item
                    habitacion = tbxHabitacion.Text, // 7 string
                    tipoSangre = cbxTipoSangre.SelectedItem.ToString(), // 8 string item
                    colorOjos = cbxColorOjos.SelectedItem.ToString(), // 9 string item
                    peso = Convert.ToInt32(tbxPeso.Text), // 10 int
                    fechaIngreso = dtpFechaIngreso.Value // 11 date
                };
                LogPacientes.RegistrarPaciente(Pacientes);

                if (LogPacientes.Mensaje.Length != 0)
                {
                    MessageBox.Show(LogPacientes.Mensaje.ToString());
                }
                else
                {
                    MessageBox.Show("Paciente registrado exitosamente");
                }
            }
            catch (Exception ms)
            {
                MessageBox.Show(string.Format("Error : {0}", ms.Message, "Error Inesperado"));
            }
        }

        private void Modificar()
        {
            Pacientes = new EPacientes
            {
                rfc = tbxRFC.Text,
                nombre = tbxNombre.Text,
                domicilio = tbxDomicilio.Text,
                colonia = cbxColonia.SelectedItem.ToString(),
                sexo = cbxSexo.SelectedItem.ToString(),
                enfermedad = cbxEnfermedad.SelectedItem.ToString(),
                habitacion = tbxHabitacion.Text,
                tipoSangre = cbxTipoSangre.SelectedItem.ToString(),
                colorOjos = cbxColorOjos.SelectedItem.ToString(),
                peso = Convert.ToInt32(tbxPeso.Text),
                fechaIngreso = dtpFechaIngreso.Value
            };
            LogPacientes.ModificarPacientes(Pacientes);
            if (LogPacientes.Mensaje.Length != 0)
                MessageBox.Show(LogPacientes.Mensaje.ToString());
            else
            {
                MessageBox.Show("Paciente modificado exitosamente");
            }
        }

        public void BuscarPaciente()
        {
            Pacientes = LogPacientes.ObtenerPacientes(srfc);
            try
            {
                tbxRFC.Text = Pacientes.rfc;
                tbxNombre.Text = Pacientes.nombre;
                tbxDomicilio.Text = Pacientes.domicilio;
                cbxColonia.Text = Pacientes.colonia;
                cbxSexo.Text = Pacientes.sexo;
                cbxEnfermedad.Text = Pacientes.enfermedad;
                tbxHabitacion.Text = Pacientes.habitacion;
                cbxTipoSangre.Text = Pacientes.tipoSangre;
                cbxColorOjos.Text = Pacientes.colorOjos;
                tbxPeso.Text = Pacientes.peso.ToString();
                dtpFechaIngreso.Value = Pacientes.fechaIngreso;
            }
            catch (Exception ms)
            {
                MessageBox.Show("RFC no registrado o no encontrado", ms.Message);
            }
        }

        private void FPaciente_Load(object sender, EventArgs e)
        {
            if(lblTipo.Text != "Registrar paciente")
            {
                BuscarPaciente();
            }
            else
            {

            }
        }
        //controles azules
        private void Boton_MouseEnter_Azul(object sender, EventArgs e)
        {
            Control Cont = sender as Control;
            if (Cont != null)
            {
                Cont.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            }

        }
        private void Boton_MouseLeave_Azul(object sender, EventArgs e)
        {
            Control Cont = sender as Control;
            if (Cont != null)
            {
                Cont.BackColor = System.Drawing.SystemColors.Highlight;
            }
        }

        private void Boton_MouseDown_Azul(object sender, MouseEventArgs e)
        {
            Control Cont = sender as Control;
            if (Cont != null)
            {
                Cont.BackColor = System.Drawing.SystemColors.HotTrack;
            }
        }
    }
}