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
    public partial class FCGeneral : Form
    {
        private string[] Opciones;
        private EPacientes Pacientes;
        private readonly LPacientes LogPacientes = new LPacientes();
        private FPrincipal gate;

        public FCGeneral()
        {
            InitializeComponent();
            gate = Application.OpenForms.OfType<FPrincipal>().FirstOrDefault();
        }

        private void FCGeneral_Load(object sender, EventArgs e)
        {
            ConsultaGeneral();
        }

        private void ConsultaGeneral()
        {
            int ren = 0;
            List<EPacientes> ListPaciente = LogPacientes.ListaPacientes();
            if (ListPaciente.Count > 0)
            {
                DgvDatos.RowCount = ListPaciente.Count;
                foreach (EPacientes Pa in ListPaciente)
                {
                    DgvDatos[0, ren].Value =  Pa.rfc;
                    DgvDatos[1, ren].Value =  Pa.nombre;
                    DgvDatos[2, ren].Value =  Pa.domicilio;
                    DgvDatos[3, ren].Value =  Pa.colonia;
                    DgvDatos[4, ren].Value =  Pa.sexo;
                    DgvDatos[5, ren].Value =  Pa.enfermedad;
                    DgvDatos[6, ren].Value =  Pa.habitacion;
                    DgvDatos[7, ren].Value =  Pa.tipoSangre;
                    DgvDatos[8, ren].Value =  Pa.colorOjos;
                    DgvDatos[9, ren].Value =  Pa.peso;
                    DgvDatos[10, ren].Value = Pa.fechaIngreso;
                    ren++;
                }
            }
            else
                MessageBox.Show("No hay pacientes registrados actualente");
        }

        public void ConsultasEspecificas(string atributo)
        {
            if(atributo == "Consultas generales")
            {
                lblTipo.Text = "";
                pnlTitulo.Width = 876;
            }
            else
            {
                lblTipo.Text = atributo;
                cbxOpciones.Items.Clear();

                switch (atributo)
                {
                    case "Por colonia":

                        Opciones = new string[6];
                        Opciones[0] = "LOS OLIVOS";
                        Opciones[1] = "GUERRERO";
                        Opciones[2] = "8 DE OCTUBRE";
                        Opciones[3] = "INDECO";
                        Opciones[4] = "CENTRO";
                        Opciones[5] = "ESTERITO";
                        cbxOpciones.Text = "LOS OLIVOS";

                        MostrarParametros();
                        break;

                    case "Por sexo":

                        Opciones = new string[2];
                        Opciones[0] = "MASCULINO";
                        Opciones[1] = "FEMENINO";
                        cbxOpciones.Text = "MASCULINO";

                        MostrarParametros();
                        break;

                    case "Por enfermedad":

                        Opciones = new string[6];
                        Opciones[0] = "DIABETES";
                        Opciones[1] = "CORAZÓN";
                        Opciones[2] = "RIÑONES";
                        Opciones[3] = "HÍGADO";
                        Opciones[4] = "PULMONAR";
                        Opciones[5] = "FRACTURAS";
                        cbxOpciones.Text = "DIABETES";

                        MostrarParametros();
                        break;

                    case "Por tipo de sangre":

                        Opciones = new string[6];
                        Opciones[0] = "ORH+";
                        Opciones[1] = "BRH+";
                        Opciones[2] = "BRH-";
                        Opciones[3] = "ARH+";
                        Opciones[4] = "ARH-";
                        Opciones[5] = "ABRH+";
                        cbxOpciones.Text = "ORH+";

                        MostrarParametros();
                        break;

                    case "Por color de ojos":

                        Opciones = new string[6];
                        Opciones[0] = "ORH+";
                        Opciones[1] = "BRH+";
                        Opciones[2] = "BRH-";
                        Opciones[3] = "ARH+";
                        Opciones[4] = "ARH-";
                        Opciones[5] = "ABRH+";
                        cbxOpciones.Text = "ORH+";

                        MostrarParametros();
                        break;

                    case "Por peso":

                        Opciones = new string[8];
                        Opciones[0] = "MENOS DE 20";
                        Opciones[1] = "ENTRE 20 Y 30";
                        Opciones[2] = "ENTRE 30 Y 40";
                        Opciones[3] = "ENTRE 40 Y 50";
                        Opciones[4] = "ENTRE 50 Y 60";
                        Opciones[5] = "ENTRE 60 Y 70";
                        Opciones[6] = "ENTRE 70 Y 80";
                        Opciones[7] = "MAS DE 80";
                        cbxOpciones.Text = "MENOS DE 20";

                        MostrarParametros();
                        break;

                    default:

                        break;
                }
                pnlTitulo.Width = 610;
            }
        }

        private void MostrarParametros()
        {
            for (int i = 0; i < Opciones.Length; i++)
            {
                cbxOpciones.Items.Add(Opciones[i]);
            }
        }

        private void ButtonEvent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                //MessageBox.Show("<: " + e.ColumnIndex + " " + e.RowIndex);

                if(e.ColumnIndex == 11) // Eliminar
                {
                    int col = e.RowIndex;
                    string srfc = ""+DgvDatos[0, col].Value;

                    if (srfc == "RFC")
                        MessageBox.Show("Indica un RFC valido");
                    else
                    {
                        LogPacientes.EliminarPaciente(srfc);
                        if (LogPacientes.Mensaje.Length != 0)
                        {
                            MessageBox.Show(LogPacientes.Mensaje.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Paciente eliminado exitosamente");
                            ConsultaGeneral();
                        }
                    }
                }

                if (e.ColumnIndex == 12) // Modificar
                {
                    int col = e.RowIndex;
                    string srfc = "" + DgvDatos[0, col].Value;

                    gate.Modificar_Paciente(srfc);
                }

            }
        }
    }
}