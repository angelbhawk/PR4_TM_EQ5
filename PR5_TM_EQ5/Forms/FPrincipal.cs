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
                pictureBox1.Location = new Point(853, 0);

            }
            else
            {
                pnlLmenu.Location = new Point(0, 0);
                pnlCcont.Location = new Point(250, 0);
                pictureBox1.Location = new Point(603, 0);
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
                //myFCG.ConsultaIndividual(name);
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
        // controles negros
        private void Boton_MouseEnter_Negro(object sender, EventArgs e)
        {
            Color Col= System.Drawing.Color.FromArgb(50, 50, 50);
            Control Cont = sender as Control;
            if (Cont != null)
            {
                Cont.BackColor = Col;

                if (Cont == pictureBox5 || Cont == lblColonia || Cont.Contains(lblColonia))
                {
                    panel4.BackColor = Col;
                    lblColonia.BackColor = Col;
                    pictureBox5.BackColor = Col;

                }
                if (Cont == pictureBox7 || Cont == label4 || Cont.Contains(label4))
                {
                    panel5.BackColor = Col;
                    label4.BackColor = Col;
                    pictureBox7.BackColor = Col;

                }
                if (Cont == pictureBox9 || Cont == label5 || Cont.Contains(label5))
                {
                    panel6.BackColor = Col;
                    label5.BackColor = Col;
                    pictureBox9.BackColor = Col;

                }
                if (Cont == pictureBox11 || Cont == label6 || Cont.Contains(label6))
                {
                    panel7.BackColor = Col;
                    label6.BackColor = Col;
                    pictureBox11.BackColor = Col;

                }
                if (Cont == pictureBox4 || Cont == label7 || Cont.Contains(label7))
                {
                    panel8.BackColor = Col;
                    label7.BackColor = Col;
                    pictureBox4.BackColor = Col;

                }
                if (Cont == pictureBox6 || Cont == label8 || Cont.Contains(label8))
                {
                    panel9.BackColor = Col;
                    label8.BackColor = Col;
                    pictureBox6.BackColor = Col;

                }
                if (Cont == pictureBox8 || Cont == lblRegistro || Cont.Contains(lblRegistro))
                {
                    panel10.BackColor = Col;
                    lblRegistro.BackColor = Col;
                    pictureBox8.BackColor = Col;

                }
                if (Cont == pictureBox3 || Cont == label2 || Cont.Contains(label2))
                {
                    panel2.BackColor = Col;
                    label2.BackColor = Col;
                    pictureBox3.BackColor = Col;

                }


            }

        }
        private void Boton_MouseLeave_Negro(object sender, EventArgs e)
        {
            Color Col = System.Drawing.Color.FromArgb(21, 21, 21);
            Color Col2 = System.Drawing.Color.FromArgb(16,16,16);
            Control Cont = sender as Control;
            if (Cont != null)
            {
                Cont.BackColor = Cont.BackColor = System.Drawing.Color.FromArgb(16, 16, 16);
                if (Cont == pictureBox5 || Cont == lblColonia || Cont.Contains(lblColonia))
                {
                    panel4.BackColor  = System.Drawing.Color.FromArgb(16, 16, 16);
                    lblColonia.BackColor  = System.Drawing.Color.FromArgb(21, 21, 21);
                    pictureBox5.BackColor = System.Drawing.Color.FromArgb(21, 21, 21);

                }
                if (Cont == pictureBox7 || Cont == label4 || Cont.Contains(label4))
                {
                    panel5.BackColor = Col2;
                    label4.BackColor = Col;
                    pictureBox7.BackColor = Col;

                }

                if (Cont == pictureBox9 || Cont == label5 || Cont.Contains(label5))
                {
                    panel6.BackColor = Col2;
                    label5.BackColor = Col;
                    pictureBox9.BackColor = Col;

                }
                if (Cont == pictureBox11 || Cont == label6 || Cont.Contains(label6))
                {
                    panel7.BackColor = Col2;
                    label6.BackColor = Col;
                    pictureBox11.BackColor = Col;

                }
                if (Cont == pictureBox4 || Cont == label7 || Cont.Contains(label7))
                {
                    panel8.BackColor = Col2;
                    label7.BackColor = Col;
                    pictureBox4.BackColor = Col;

                }
                if (Cont == pictureBox6 || Cont == label8 || Cont.Contains(label8))
                {
                    panel9.BackColor = Col2;
                    label8.BackColor = Col;
                    pictureBox6.BackColor = Col;

                }
                if (Cont == pictureBox8 || Cont == lblRegistro || Cont.Contains(lblRegistro))
                {
                    panel10.BackColor = Col2;
                    lblRegistro.BackColor = Col;
                    pictureBox8.BackColor = Col;

                }
                if (Cont == pictureBox3 || Cont == label2 || Cont.Contains(label2))
                {
                    panel2.BackColor = Col;
                    label2.BackColor = Col;
                    pictureBox3.BackColor = Col;

                }
            }
        }

        private void Boton_MouseDown_Negro(object sender, MouseEventArgs e)
        {
            Color Col = System.Drawing.Color.FromArgb(80, 80, 80);
            Control Cont = sender as Control;
            if (Cont != null)
            {
                Cont.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
                if (Cont == pictureBox5 || Cont == lblColonia || Cont.Contains(lblColonia))
                {
                    panel4.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
                    lblColonia.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
                    pictureBox5.BackColor  = System.Drawing.Color.FromArgb(80, 80, 80);

                }
                if (Cont == pictureBox7 || Cont == label4 || Cont.Contains(label4))
                {
                    panel5.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
                    label4.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
                    pictureBox7.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);

                }
                if (Cont == pictureBox9 || Cont == label5 || Cont.Contains(label5))
                {
                    panel6.BackColor = Col;
                    label5.BackColor = Col;
                    pictureBox9.BackColor = Col;

                }
                if (Cont == pictureBox11 || Cont == label6 || Cont.Contains(label6))
                {
                    panel7.BackColor = Col;
                    label6.BackColor = Col;
                    pictureBox11.BackColor = Col;

                }
                if (Cont == pictureBox4 || Cont == label7 || Cont.Contains(label7))
                {
                    panel8.BackColor = Col;
                    label7.BackColor = Col;
                    pictureBox4.BackColor = Col;

                }
                if (Cont == pictureBox6 || Cont == label8 || Cont.Contains(label8))
                {
                    panel9.BackColor = Col;
                    label8.BackColor = Col;
                    pictureBox6.BackColor = Col;

                }
                if (Cont == pictureBox8 || Cont == lblRegistro || Cont.Contains(lblRegistro))
                {
                    panel10.BackColor = Col;
                    lblRegistro.BackColor = Col;
                    pictureBox8.BackColor = Col;

                }
                if (Cont == pictureBox3 || Cont == label2 || Cont.Contains(label2))
                {
                    panel2.BackColor = Col;
                    label2.BackColor = Col;
                    pictureBox3.BackColor = Col;

                }
            }
        }
        //controles azules
        private void Boton_MouseEnter_Azul(object sender, EventArgs e)
        {
            Control Cont = sender as Control;
            if (Cont != null)
            {
                Cont.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
                if (Cont.Contains(pbxMenu))
                {
                    pbxMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
                }
                if (Cont == pbxMenu)
                {
                    panel11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
                }


            }
            
        }
        private void Boton_MouseLeave_Azul(object sender, EventArgs e)
        {
            Control Cont = sender as Control;
            if (Cont != null)
            {
                Cont.BackColor = System.Drawing.SystemColors.Highlight;
                if (Cont.Contains(pbxMenu))
                {
                    pbxMenu.BackColor = System.Drawing.SystemColors.Highlight;
                }
                if (Cont == pbxMenu)
                {
                    panel11.BackColor = System.Drawing.SystemColors.Highlight;
                }

            }
        }

        private void Boton_MouseDown_Azul(object sender, MouseEventArgs e)
        {
            Control Cont = sender as Control;
            if (Cont != null)
            {
                Cont.BackColor = System.Drawing.Color.CornflowerBlue;
                if (Cont.Contains(pbxMenu))
                {
                    pbxMenu.BackColor = System.Drawing.Color.CornflowerBlue;
                }
                if (Cont == pbxMenu)
                {
                    panel11.BackColor = System.Drawing.Color.CornflowerBlue;
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}