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

        private EPacientes Pacientes;
        private readonly LPacientes LogPacientes = new LPacientes();

        public FCGeneral()
        {
            InitializeComponent();
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
                pnlTitulo.Width = 610;
            }

            MostrarParametros();
        }

        private void MostrarParametros()
        {

        }
    }
}