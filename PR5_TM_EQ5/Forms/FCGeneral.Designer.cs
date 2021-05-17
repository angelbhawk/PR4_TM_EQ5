
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvDatos = new System.Windows.Forms.DataGridView();
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxOpciones = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvDatos
            // 
            this.DgvDatos.AllowUserToAddRows = false;
            this.DgvDatos.AllowUserToDeleteRows = false;
            this.DgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.DgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
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
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDatos.DefaultCellStyle = dataGridViewCellStyle32;
            this.DgvDatos.EnableHeadersVisualStyles = false;
            this.DgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.DgvDatos.Location = new System.Drawing.Point(16, 70);
            this.DgvDatos.MultiSelect = false;
            this.DgvDatos.Name = "DgvDatos";
            this.DgvDatos.ReadOnly = true;
            this.DgvDatos.RowHeadersVisible = false;
            this.DgvDatos.RowHeadersWidth = 51;
            this.DgvDatos.RowTemplate.Height = 32;
            this.DgvDatos.Size = new System.Drawing.Size(876, 405);
            this.DgvDatos.TabIndex = 0;
            this.DgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ButtonEvent_CellContentClick);
            // 
            // cRFC
            // 
            this.cRFC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cRFC.DefaultCellStyle = dataGridViewCellStyle26;
            this.cRFC.HeaderText = "RFC";
            this.cRFC.MinimumWidth = 6;
            this.cRFC.Name = "cRFC";
            this.cRFC.ReadOnly = true;
            this.cRFC.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cRFC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cRFC.Width = 6;
            // 
            // cNombre
            // 
            this.cNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cNombre.DefaultCellStyle = dataGridViewCellStyle27;
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.MinimumWidth = 6;
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cNombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cNombre.Width = 6;
            // 
            // cDomicilio
            // 
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cDomicilio.DefaultCellStyle = dataGridViewCellStyle28;
            this.cDomicilio.HeaderText = "Domicilio";
            this.cDomicilio.MinimumWidth = 6;
            this.cDomicilio.Name = "cDomicilio";
            this.cDomicilio.ReadOnly = true;
            this.cDomicilio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cDomicilio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cDomicilio.Width = 125;
            // 
            // cColonia
            // 
            this.cColonia.HeaderText = "Colonia";
            this.cColonia.MinimumWidth = 6;
            this.cColonia.Name = "cColonia";
            this.cColonia.ReadOnly = true;
            this.cColonia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cColonia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cColonia.Width = 125;
            // 
            // cSexo
            // 
            this.cSexo.HeaderText = "Sexo";
            this.cSexo.MinimumWidth = 6;
            this.cSexo.Name = "cSexo";
            this.cSexo.ReadOnly = true;
            this.cSexo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cSexo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cSexo.Width = 125;
            // 
            // cEnfermedad
            // 
            this.cEnfermedad.HeaderText = "Enfermedad";
            this.cEnfermedad.MinimumWidth = 6;
            this.cEnfermedad.Name = "cEnfermedad";
            this.cEnfermedad.ReadOnly = true;
            this.cEnfermedad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cEnfermedad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cEnfermedad.Width = 125;
            // 
            // cHabitacion
            // 
            this.cHabitacion.HeaderText = "Habitacion";
            this.cHabitacion.MinimumWidth = 6;
            this.cHabitacion.Name = "cHabitacion";
            this.cHabitacion.ReadOnly = true;
            this.cHabitacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cHabitacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cHabitacion.Width = 125;
            // 
            // ctSangre
            // 
            this.ctSangre.HeaderText = "Tipo sangre";
            this.ctSangre.MinimumWidth = 6;
            this.ctSangre.Name = "ctSangre";
            this.ctSangre.ReadOnly = true;
            this.ctSangre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ctSangre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ctSangre.Width = 125;
            // 
            // ccOjos
            // 
            this.ccOjos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.ccOjos.HeaderText = "Color ojos";
            this.ccOjos.MinimumWidth = 6;
            this.ccOjos.Name = "ccOjos";
            this.ccOjos.ReadOnly = true;
            this.ccOjos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ccOjos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ccOjos.Width = 6;
            // 
            // cPeso
            // 
            this.cPeso.HeaderText = "Peso";
            this.cPeso.MinimumWidth = 6;
            this.cPeso.Name = "cPeso";
            this.cPeso.ReadOnly = true;
            this.cPeso.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cPeso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cPeso.Width = 125;
            // 
            // cfIngreso
            // 
            this.cfIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cfIngreso.DefaultCellStyle = dataGridViewCellStyle29;
            this.cfIngreso.HeaderText = "Fecha ingreso";
            this.cfIngreso.MinimumWidth = 6;
            this.cfIngreso.Name = "cfIngreso";
            this.cfIngreso.ReadOnly = true;
            this.cfIngreso.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cfIngreso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cfIngreso.Width = 6;
            // 
            // cEliminar
            // 
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            this.cEliminar.DefaultCellStyle = dataGridViewCellStyle30;
            this.cEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cEliminar.HeaderText = "Eliminar";
            this.cEliminar.MinimumWidth = 6;
            this.cEliminar.Name = "cEliminar";
            this.cEliminar.ReadOnly = true;
            this.cEliminar.Text = "Eliminar";
            this.cEliminar.UseColumnTextForButtonValue = true;
            this.cEliminar.Width = 125;
            // 
            // cModificar
            // 
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.White;
            this.cModificar.DefaultCellStyle = dataGridViewCellStyle31;
            this.cModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cModificar.HeaderText = "Modificar";
            this.cModificar.MinimumWidth = 6;
            this.cModificar.Name = "cModificar";
            this.cModificar.ReadOnly = true;
            this.cModificar.Text = "Modificar";
            this.cModificar.UseColumnTextForButtonValue = true;
            this.cModificar.Width = 125;
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
            this.panel2.Controls.Add(this.fecha);
            this.panel2.Controls.Add(this.cbxOpciones);
            this.panel2.Location = new System.Drawing.Point(3, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 32);
            this.panel2.TabIndex = 6;
            // 
            // cbxOpciones
            // 
            this.cbxOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.cbxOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbxOpciones.FormattingEnabled = true;
            this.cbxOpciones.Items.AddRange(new object[] {
            "DIABETES",
            "CORAZÓN",
            "RIÑONES",
            "HÍGADO",
            "PULMONAR",
            "FRACTURAS"});
            this.cbxOpciones.Location = new System.Drawing.Point(3, 3);
            this.cbxOpciones.Name = "cbxOpciones";
            this.cbxOpciones.Size = new System.Drawing.Size(117, 24);
            this.cbxOpciones.TabIndex = 20;
            this.cbxOpciones.Text = "DIABETES";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(127, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(3, 7);
            this.fecha.MaxDate = new System.DateTime(2021, 5, 17, 0, 0, 0, 0);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(117, 20);
            this.fecha.TabIndex = 6;
            this.fecha.Value = new System.DateTime(2021, 5, 17, 0, 0, 0, 0);
            this.fecha.Visible = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lblTipo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTipo.Location = new System.Drawing.Point(185, 11);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(87, 16);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Por colonia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consultas Generales  /";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.White;
            this.pnlTitulo.Controls.Add(this.label1);
            this.pnlTitulo.Controls.Add(this.lblTipo);
            this.pnlTitulo.Location = new System.Drawing.Point(16, 12);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(876, 42);
            this.pnlTitulo.TabIndex = 9;
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
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDatos;
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
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTitulo;
    }
}