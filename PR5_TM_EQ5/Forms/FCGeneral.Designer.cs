
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvDatos = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.cbxOpciones = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
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
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
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
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Verdana", 9.75F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDatos.DefaultCellStyle = dataGridViewCellStyle24;
            this.DgvDatos.EnableHeadersVisualStyles = false;
            this.DgvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.DgvDatos.Location = new System.Drawing.Point(12, 70);
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(592, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(296, 42);
            this.panel5.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.fecha);
            this.panel2.Controls.Add(this.cbxOpciones);
            this.panel2.Location = new System.Drawing.Point(37, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 32);
            this.panel2.TabIndex = 6;
            // 
            // fecha
            // 
            this.fecha.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(2, 5);
            this.fecha.MaxDate = new System.DateTime(2021, 5, 17, 0, 0, 0, 0);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(117, 23);
            this.fecha.TabIndex = 6;
            this.fecha.Value = new System.DateTime(2021, 5, 17, 0, 0, 0, 0);
            this.fecha.Visible = false;
            // 
            // cbxOpciones
            // 
            this.cbxOpciones.BackColor = System.Drawing.Color.White;
            this.cbxOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxOpciones.Font = new System.Drawing.Font("Verdana", 9.75F);
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
            this.cbxOpciones.Size = new System.Drawing.Size(117, 24);
            this.cbxOpciones.TabIndex = 20;
            this.cbxOpciones.Text = "DIABETES";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(161, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTipo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTipo.Location = new System.Drawing.Point(182, 12);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(91, 19);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Por colonia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consultas Generales  /";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.White;
            this.pnlTitulo.Controls.Add(this.label1);
            this.pnlTitulo.Controls.Add(this.lblTipo);
            this.pnlTitulo.Location = new System.Drawing.Point(12, 12);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(876, 42);
            this.pnlTitulo.TabIndex = 9;
            // 
            // cRFC
            // 
            this.cRFC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cRFC.DefaultCellStyle = dataGridViewCellStyle18;
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cNombre.DefaultCellStyle = dataGridViewCellStyle19;
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
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cDomicilio.DefaultCellStyle = dataGridViewCellStyle20;
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
            this.cfIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cfIngreso.DefaultCellStyle = dataGridViewCellStyle21;
            this.cfIngreso.HeaderText = "Fecha ingreso";
            this.cfIngreso.MinimumWidth = 6;
            this.cfIngreso.Name = "cfIngreso";
            this.cfIngreso.ReadOnly = true;
            this.cfIngreso.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cfIngreso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cfIngreso.Width = 94;
            // 
            // cEliminar
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            this.cEliminar.DefaultCellStyle = dataGridViewCellStyle22;
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
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            this.cModificar.DefaultCellStyle = dataGridViewCellStyle23;
            this.cModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cModificar.HeaderText = "Modificar";
            this.cModificar.MinimumWidth = 6;
            this.cModificar.Name = "cModificar";
            this.cModificar.ReadOnly = true;
            this.cModificar.Text = "Modificar";
            this.cModificar.UseColumnTextForButtonValue = true;
            this.cModificar.Width = 125;
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
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTitulo;
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