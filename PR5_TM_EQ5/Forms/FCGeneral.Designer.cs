﻿
namespace PR5_TM_EQ5.Forms
{
    partial class FCGeneral
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvDatos = new System.Windows.Forms.DataGridView();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxOpciones = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cRFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cColonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEnfermedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctSangre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccOjos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvDatos
            // 
            this.DgvDatos.AllowUserToAddRows = false;
            this.DgvDatos.AllowUserToDeleteRows = false;
            this.DgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.DgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sora", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cRFC,
            this.cNombre,
            this.cDomicilio,
            this.cColonia,
            this.cSexo,
            this.cEnfermedad,
            this.cHabitacion,
            this.ctSangre,
            this.ccOjos,
            this.cPeso,
            this.cfIngreso,
            this.cEliminar,
            this.cModificar});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Sora Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDatos.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvDatos.EnableHeadersVisualStyles = false;
            this.DgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.DgvDatos.Location = new System.Drawing.Point(12, 68);
            this.DgvDatos.MultiSelect = false;
            this.DgvDatos.Name = "DgvDatos";
            this.DgvDatos.ReadOnly = true;
            this.DgvDatos.RowHeadersVisible = false;
            this.DgvDatos.RowTemplate.Height = 32;
            this.DgvDatos.Size = new System.Drawing.Size(876, 405);
            this.DgvDatos.TabIndex = 0;
            this.DgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ButtonEvent_CellContentClick);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.White;
            this.pnlTitulo.Controls.Add(this.label1);
            this.pnlTitulo.Controls.Add(this.lblTipo);
            this.pnlTitulo.Location = new System.Drawing.Point(12, 12);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(876, 42);
            this.pnlTitulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sora SemiBold", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consultas Generales  /";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Sora SemiBold", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lblTipo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTipo.Location = new System.Drawing.Point(172, 11);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(85, 20);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Por colonia";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(628, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(260, 42);
            this.panel5.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.cbxOpciones);
            this.panel2.Location = new System.Drawing.Point(3, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 31);
            this.panel2.TabIndex = 6;
            // 
            // cbxOpciones
            // 
            this.cbxOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.cbxOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxOpciones.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.cbxOpciones.FormattingEnabled = true;
            this.cbxOpciones.Items.AddRange(new object[] {
            "DIABETES",
            "CORAZÓN",
            "RIÑONES",
            "HÍGADO",
            "PULMONAR",
            "FRACTURAS"});
            this.cbxOpciones.Location = new System.Drawing.Point(2, 4);
            this.cbxOpciones.Name = "cbxOpciones";
            this.cbxOpciones.Size = new System.Drawing.Size(117, 23);
            this.cbxOpciones.TabIndex = 20;
            this.cbxOpciones.Text = "DIABETES";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sora SemiBold", 9.749999F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(127, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cRFC
            // 
            this.cRFC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cRFC.DefaultCellStyle = dataGridViewCellStyle2;
            this.cRFC.HeaderText = "RFC";
            this.cRFC.Name = "cRFC";
            this.cRFC.ReadOnly = true;
            this.cRFC.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cRFC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cRFC.Width = 5;
            // 
            // cNombre
            // 
            this.cNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cNombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cNombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cNombre.Width = 5;
            // 
            // cDomicilio
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cDomicilio.DefaultCellStyle = dataGridViewCellStyle4;
            this.cDomicilio.HeaderText = "Domicilio";
            this.cDomicilio.Name = "cDomicilio";
            this.cDomicilio.ReadOnly = true;
            this.cDomicilio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cDomicilio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cColonia
            // 
            this.cColonia.HeaderText = "Colonia";
            this.cColonia.Name = "cColonia";
            this.cColonia.ReadOnly = true;
            this.cColonia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cColonia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cSexo
            // 
            this.cSexo.HeaderText = "Sexo";
            this.cSexo.Name = "cSexo";
            this.cSexo.ReadOnly = true;
            this.cSexo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cSexo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cEnfermedad
            // 
            this.cEnfermedad.HeaderText = "Enfermedad";
            this.cEnfermedad.Name = "cEnfermedad";
            this.cEnfermedad.ReadOnly = true;
            this.cEnfermedad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cEnfermedad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cHabitacion
            // 
            this.cHabitacion.HeaderText = "Habitacion";
            this.cHabitacion.Name = "cHabitacion";
            this.cHabitacion.ReadOnly = true;
            this.cHabitacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cHabitacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ctSangre
            // 
            this.ctSangre.HeaderText = "Tipo sangre";
            this.ctSangre.Name = "ctSangre";
            this.ctSangre.ReadOnly = true;
            this.ctSangre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ctSangre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ccOjos
            // 
            this.ccOjos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.ccOjos.HeaderText = "Color ojos";
            this.ccOjos.Name = "ccOjos";
            this.ccOjos.ReadOnly = true;
            this.ccOjos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ccOjos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ccOjos.Width = 5;
            // 
            // cPeso
            // 
            this.cPeso.HeaderText = "Peso";
            this.cPeso.Name = "cPeso";
            this.cPeso.ReadOnly = true;
            this.cPeso.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cPeso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cfIngreso
            // 
            this.cfIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cfIngreso.DefaultCellStyle = dataGridViewCellStyle5;
            this.cfIngreso.HeaderText = "Fecha ingreso";
            this.cfIngreso.Name = "cfIngreso";
            this.cfIngreso.ReadOnly = true;
            this.cfIngreso.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cfIngreso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cfIngreso.Width = 5;
            // 
            // cEliminar
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.cEliminar.DefaultCellStyle = dataGridViewCellStyle6;
            this.cEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cEliminar.HeaderText = "Eliminar";
            this.cEliminar.Name = "cEliminar";
            this.cEliminar.ReadOnly = true;
            this.cEliminar.Text = "Eliminar";
            this.cEliminar.UseColumnTextForButtonValue = true;
            // 
            // cModificar
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.cModificar.DefaultCellStyle = dataGridViewCellStyle7;
            this.cModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cModificar.HeaderText = "Modificar";
            this.cModificar.Name = "cModificar";
            this.cModificar.ReadOnly = true;
            this.cModificar.Text = "Modificar";
            this.cModificar.UseColumnTextForButtonValue = true;
            // 
            // FCGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 485);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.DgvDatos);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCGeneral";
            this.Text = "FCGeneral";
            this.Load += new System.EventHandler(this.FCGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDatos;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxOpciones;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cColonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEnfermedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctSangre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccOjos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfIngreso;
        private System.Windows.Forms.DataGridViewButtonColumn cEliminar;
        private System.Windows.Forms.DataGridViewButtonColumn cModificar;
    }
}