
namespace PR5_TM_EQ5
{
    partial class Acceso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvDatos = new System.Windows.Forms.DataGridView();
            this.cRFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cColonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEnfermedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTipoSangre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cColorOjos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cSelecciona = new System.Windows.Forms.ComboBox();
            this.rfc = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.domicilio = new System.Windows.Forms.TextBox();
            this.colonia = new System.Windows.Forms.ComboBox();
            this.sexo = new System.Windows.Forms.ComboBox();
            this.enfermedad = new System.Windows.Forms.ComboBox();
            this.habitacion = new System.Windows.Forms.TextBox();
            this.tipoSangre = new System.Windows.Forms.ComboBox();
            this.colorOjos = new System.Windows.Forms.ComboBox();
            this.peso = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peso)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDatos
            // 
            this.DgvDatos.AllowUserToAddRows = false;
            this.DgvDatos.AllowUserToDeleteRows = false;
            this.DgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cRFC,
            this.cNombre,
            this.cDomicilio,
            this.cColonia,
            this.cSexo,
            this.cEnfermedad,
            this.cHabitacion,
            this.cTipoSangre,
            this.cColorOjos,
            this.cPeso,
            this.cFechaIngreso});
            this.DgvDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.DgvDatos.Location = new System.Drawing.Point(0, 0);
            this.DgvDatos.Name = "DgvDatos";
            this.DgvDatos.ReadOnly = true;
            this.DgvDatos.RowHeadersVisible = false;
            this.DgvDatos.Size = new System.Drawing.Size(873, 157);
            this.DgvDatos.TabIndex = 1;
            // 
            // cRFC
            // 
            this.cRFC.HeaderText = "RFC";
            this.cRFC.Name = "cRFC";
            this.cRFC.ReadOnly = true;
            // 
            // cNombre
            // 
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            // 
            // cDomicilio
            // 
            this.cDomicilio.HeaderText = "Domicilio";
            this.cDomicilio.Name = "cDomicilio";
            this.cDomicilio.ReadOnly = true;
            // 
            // cColonia
            // 
            this.cColonia.HeaderText = "Colonia";
            this.cColonia.Name = "cColonia";
            this.cColonia.ReadOnly = true;
            // 
            // cSexo
            // 
            this.cSexo.HeaderText = "Sexo";
            this.cSexo.Name = "cSexo";
            this.cSexo.ReadOnly = true;
            // 
            // cEnfermedad
            // 
            this.cEnfermedad.HeaderText = "Enfermedad";
            this.cEnfermedad.Name = "cEnfermedad";
            this.cEnfermedad.ReadOnly = true;
            // 
            // cHabitacion
            // 
            this.cHabitacion.HeaderText = "Habitación";
            this.cHabitacion.Name = "cHabitacion";
            this.cHabitacion.ReadOnly = true;
            // 
            // cTipoSangre
            // 
            this.cTipoSangre.HeaderText = "Tipo de Sangre";
            this.cTipoSangre.Name = "cTipoSangre";
            this.cTipoSangre.ReadOnly = true;
            // 
            // cColorOjos
            // 
            this.cColorOjos.HeaderText = "Color de Ojos";
            this.cColorOjos.Name = "cColorOjos";
            this.cColorOjos.ReadOnly = true;
            // 
            // cPeso
            // 
            this.cPeso.HeaderText = "Peso";
            this.cPeso.Name = "cPeso";
            this.cPeso.ReadOnly = true;
            // 
            // cFechaIngreso
            // 
            this.cFechaIngreso.HeaderText = "Fecha de Ingreso";
            this.cFechaIngreso.Name = "cFechaIngreso";
            this.cFechaIngreso.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Consulta General";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(798, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(211, 410);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cSelecciona
            // 
            this.cSelecciona.FormattingEnabled = true;
            this.cSelecciona.Items.AddRange(new object[] {
            "Insertar",
            "Eliminar",
            "Modificar"});
            this.cSelecciona.Location = new System.Drawing.Point(22, 290);
            this.cSelecciona.Name = "cSelecciona";
            this.cSelecciona.Size = new System.Drawing.Size(121, 21);
            this.cSelecciona.TabIndex = 6;
            this.cSelecciona.Text = "(Selecciona)";
            // 
            // rfc
            // 
            this.rfc.Location = new System.Drawing.Point(22, 332);
            this.rfc.MaxLength = 13;
            this.rfc.Name = "rfc";
            this.rfc.Size = new System.Drawing.Size(100, 20);
            this.rfc.TabIndex = 7;
            this.rfc.Text = "RFC";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(128, 332);
            this.nombre.MaxLength = 30;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 8;
            this.nombre.Text = "Nombre";
            // 
            // domicilio
            // 
            this.domicilio.Location = new System.Drawing.Point(234, 332);
            this.domicilio.MaxLength = 30;
            this.domicilio.Name = "domicilio";
            this.domicilio.Size = new System.Drawing.Size(100, 20);
            this.domicilio.TabIndex = 9;
            this.domicilio.Text = "Domicilio";
            // 
            // colonia
            // 
            this.colonia.FormattingEnabled = true;
            this.colonia.Items.AddRange(new object[] {
            "Los Olivos",
            "Guerrero",
            "8 de Octubre",
            "Indeco",
            "Centro",
            "Esterito"});
            this.colonia.Location = new System.Drawing.Point(340, 331);
            this.colonia.Name = "colonia";
            this.colonia.Size = new System.Drawing.Size(100, 21);
            this.colonia.TabIndex = 17;
            this.colonia.Text = "Colonia";
            // 
            // sexo
            // 
            this.sexo.FormattingEnabled = true;
            this.sexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.sexo.Location = new System.Drawing.Point(446, 331);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(100, 21);
            this.sexo.TabIndex = 18;
            this.sexo.Text = "Sexo";
            // 
            // enfermedad
            // 
            this.enfermedad.FormattingEnabled = true;
            this.enfermedad.Items.AddRange(new object[] {
            "Diabetes",
            "Corazón",
            "Riñones",
            "Higado",
            "Pulmonar",
            "Fracturas"});
            this.enfermedad.Location = new System.Drawing.Point(552, 332);
            this.enfermedad.Name = "enfermedad";
            this.enfermedad.Size = new System.Drawing.Size(100, 21);
            this.enfermedad.TabIndex = 19;
            this.enfermedad.Text = "Enfermedad";
            // 
            // habitacion
            // 
            this.habitacion.Location = new System.Drawing.Point(658, 332);
            this.habitacion.MaxLength = 3;
            this.habitacion.Name = "habitacion";
            this.habitacion.Size = new System.Drawing.Size(100, 20);
            this.habitacion.TabIndex = 13;
            this.habitacion.Text = "Habitacion";
            // 
            // tipoSangre
            // 
            this.tipoSangre.FormattingEnabled = true;
            this.tipoSangre.Items.AddRange(new object[] {
            "ORH+",
            "BRH+",
            "BRH-",
            "ARH+",
            "ARH-",
            "ABRH+"});
            this.tipoSangre.Location = new System.Drawing.Point(764, 331);
            this.tipoSangre.Name = "tipoSangre";
            this.tipoSangre.Size = new System.Drawing.Size(100, 21);
            this.tipoSangre.TabIndex = 20;
            this.tipoSangre.Text = "Tipo de Sangre";
            // 
            // colorOjos
            // 
            this.colorOjos.FormattingEnabled = true;
            this.colorOjos.Items.AddRange(new object[] {
            "Azules",
            "Verdes",
            "Cafés oscuro",
            "Cafés claro",
            "Grises",
            "Negros"});
            this.colorOjos.Location = new System.Drawing.Point(22, 358);
            this.colorOjos.Name = "colorOjos";
            this.colorOjos.Size = new System.Drawing.Size(100, 21);
            this.colorOjos.TabIndex = 21;
            this.colorOjos.Text = "Color de Ojos";
            // 
            // peso
            // 
            this.peso.Location = new System.Drawing.Point(128, 359);
            this.peso.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(78, 20);
            this.peso.TabIndex = 22;
            this.peso.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Kg";
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaIngreso.Location = new System.Drawing.Point(234, 358);
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.Size = new System.Drawing.Size(100, 20);
            this.fechaIngreso.TabIndex = 24;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 410);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Colonia",
            "Sexo",
            "Enfermedad",
            "Tipo de Sangre",
            "Color de ojos",
            "Fecha de ingreso"});
            this.comboBox1.Location = new System.Drawing.Point(340, 290);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.Text = "(Busqueda por)";
            // 
            // Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 489);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.fechaIngreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.colorOjos);
            this.Controls.Add(this.tipoSangre);
            this.Controls.Add(this.enfermedad);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.colonia);
            this.Controls.Add(this.habitacion);
            this.Controls.Add(this.domicilio);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.rfc);
            this.Controls.Add(this.cSelecciona);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DgvDatos);
            this.Name = "Acceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cColonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEnfermedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTipoSangre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cColorOjos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFechaIngreso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cSelecciona;
        private System.Windows.Forms.TextBox rfc;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox domicilio;
        private System.Windows.Forms.ComboBox colonia;
        private System.Windows.Forms.ComboBox sexo;
        private System.Windows.Forms.ComboBox enfermedad;
        private System.Windows.Forms.TextBox habitacion;
        private System.Windows.Forms.ComboBox tipoSangre;
        private System.Windows.Forms.ComboBox colorOjos;
        private System.Windows.Forms.NumericUpDown peso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaIngreso;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

