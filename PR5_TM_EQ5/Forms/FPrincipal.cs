using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR5_TM_EQ5.Forms
{
    public partial class FPrincipal : Form
    {
        private FCGeneral myFCG;
        private FPaciente myFPP;

        public FPrincipal()
        {
            InitializeComponent();
        }

        private void pbxMenu_Click(object sender, EventArgs e)
        {
            if(pnlLmenu.Location == new Point(0,0))
            {
                pnlLmenu.Location = new Point(-250, 0);
                pnlCcont.Location = new Point(0, 0);
            }
            else
            {
                pnlLmenu.Location = new Point(0, 0);
                pnlCcont.Location = new Point(250, 0);
            }
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {
            Open_FCG();
            myFCG.ConsultasEspecificas("Consultas generales");
        }

        private void Busqueda_Especifica_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            string name = lbl.Text;

            Clear();

            if (name == "Registrar paciente")
            {
                Open_FPP();
            }
            else
            {
                Open_FCG();
                myFCG.ConsultasEspecificas(name);
            }
        }

        public void Modificar_Paciente(string srfc)
        {
            Clear();
            Open_FPP();
            myFPP.lblTipo.Text = "Modificación de " + srfc;
            myFPP.Srfc = srfc;
            myFPP.BuscarPaciente();
        }

        private void Open_FCG() 
        {
            myFCG = new FCGeneral();
            myFCG.TopLevel = false;
            myFCG.AutoScroll = true;
            pnlCForm.Controls.Add(myFCG);
            myFCG.Show();
        }

        private void Open_FPP()
        {
            myFPP = new FPaciente();
            myFPP.TopLevel = false;
            myFPP.AutoScroll = true;
            pnlCForm.Controls.Add(myFPP);
            myFPP.Show();
        }

        private void Clear()
        {
            pnlCForm.Controls.Clear();
            myFCG.Close();
            //myFPP.Close();
        }
    }
}