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
                    rfc = tbxRFC.Text.ToUpper(), //1 string
                    nombre = tbxNombre.Text.ToUpper(), // 2 string
                    domicilio = tbxDomicilio.Text.ToUpper(), // 3 string
                    colonia = cbxColonia.SelectedItem.ToString().ToUpper(), // 4 string item
                    sexo = cbxSexo.SelectedItem.ToString().ToUpper(), // 5 string item
                    enfermedad = cbxEnfermedad.SelectedItem.ToString().ToUpper(), // 6 string item
                    habitacion = tbxHabitacion.Text.ToUpper(), // 7 string
                    tipoSangre = cbxTipoSangre.SelectedItem.ToString().ToUpper(), // 8 string item
                    colorOjos = cbxColorOjos.SelectedItem.ToString().ToUpper(), // 9 string item
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
                rfc = tbxRFC.Text.ToUpper(),
                nombre = tbxNombre.Text.ToUpper(),
                domicilio = tbxDomicilio.Text.ToUpper(),
                colonia = cbxColonia.SelectedItem.ToString().ToUpper(),
                sexo = cbxSexo.SelectedItem.ToString().ToUpper(),
                enfermedad = cbxEnfermedad.SelectedItem.ToString().ToUpper(),
                habitacion = tbxHabitacion.Text.ToUpper(),
                tipoSangre = cbxTipoSangre.SelectedItem.ToString().ToUpper(),
                colorOjos = cbxColorOjos.SelectedItem.ToString().ToUpper(),
                peso = Convert.ToInt32(tbxPeso.Text),
                fechaIngreso = dtpFechaIngreso.Value.Date
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