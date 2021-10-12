
namespace TP_PAV_3K3_GRUPO2.Formularios.Empleados
{
    partial class Frm_ModificarEmpleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NombreE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ApellidoE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dp_FechaIngE = new System.Windows.Forms.DateTimePicker();
            this.dp_FechaNacE = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_deptoE = new System.Windows.Forms.TextBox();
            this.txt_pisoE = new System.Windows.Forms.TextBox();
            this.txt_numeroE = new System.Windows.Forms.TextBox();
            this.txt_calleE = new System.Windows.Forms.TextBox();
            this.cb_barrioE = new TP_PAV_3K3_GRUPO2.Clases.ComboBox01();
            this.cb_localidadE = new TP_PAV_3K3_GRUPO2.Clases.ComboBox01();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Piso = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_CargoE = new TP_PAV_3K3_GRUPO2.Clases.ComboBox01();
            this.cb_documentoE = new TP_PAV_3K3_GRUPO2.Clases.ComboBox01();
            this.cb_tipoDocE = new TP_PAV_3K3_GRUPO2.Clases.ComboBox01();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo Documento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Documento:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // txt_NombreE
            // 
            this.txt_NombreE.Location = new System.Drawing.Point(116, 64);
            this.txt_NombreE.Name = "txt_NombreE";
            this.txt_NombreE.Size = new System.Drawing.Size(121, 20);
            this.txt_NombreE.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido:";
            // 
            // txt_ApellidoE
            // 
            this.txt_ApellidoE.Location = new System.Drawing.Point(116, 88);
            this.txt_ApellidoE.Name = "txt_ApellidoE";
            this.txt_ApellidoE.Size = new System.Drawing.Size(121, 20);
            this.txt_ApellidoE.TabIndex = 9;
            this.txt_ApellidoE.TextChanged += new System.EventHandler(this.txt_ApellidoE_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha de nacimiento:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dp_FechaIngE
            // 
            this.dp_FechaIngE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_FechaIngE.Location = new System.Drawing.Point(116, 146);
            this.dp_FechaIngE.Name = "dp_FechaIngE";
            this.dp_FechaIngE.Size = new System.Drawing.Size(121, 20);
            this.dp_FechaIngE.TabIndex = 11;
            // 
            // dp_FechaNacE
            // 
            this.dp_FechaNacE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_FechaNacE.Location = new System.Drawing.Point(116, 117);
            this.dp_FechaNacE.Name = "dp_FechaNacE";
            this.dp_FechaNacE.Size = new System.Drawing.Size(121, 20);
            this.dp_FechaNacE.TabIndex = 12;
            this.dp_FechaNacE.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha de ingreso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cargo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_deptoE);
            this.groupBox1.Controls.Add(this.txt_pisoE);
            this.groupBox1.Controls.Add(this.txt_numeroE);
            this.groupBox1.Controls.Add(this.txt_calleE);
            this.groupBox1.Controls.Add(this.cb_barrioE);
            this.groupBox1.Controls.Add(this.cb_localidadE);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Piso);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(38, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 199);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dirección";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_deptoE
            // 
            this.txt_deptoE.Location = new System.Drawing.Point(81, 113);
            this.txt_deptoE.Name = "txt_deptoE";
            this.txt_deptoE.Size = new System.Drawing.Size(121, 20);
            this.txt_deptoE.TabIndex = 30;
            // 
            // txt_pisoE
            // 
            this.txt_pisoE.Location = new System.Drawing.Point(81, 84);
            this.txt_pisoE.Name = "txt_pisoE";
            this.txt_pisoE.Size = new System.Drawing.Size(121, 20);
            this.txt_pisoE.TabIndex = 29;
            // 
            // txt_numeroE
            // 
            this.txt_numeroE.Location = new System.Drawing.Point(81, 53);
            this.txt_numeroE.Name = "txt_numeroE";
            this.txt_numeroE.Size = new System.Drawing.Size(121, 20);
            this.txt_numeroE.TabIndex = 28;
            // 
            // txt_calleE
            // 
            this.txt_calleE.Location = new System.Drawing.Point(81, 26);
            this.txt_calleE.Name = "txt_calleE";
            this.txt_calleE.Size = new System.Drawing.Size(120, 20);
            this.txt_calleE.TabIndex = 27;
            // 
            // cb_barrioE
            // 
            this.cb_barrioE._ComboSinSeleccion = false;
            this.cb_barrioE._MensajeError = null;
            this.cb_barrioE._Nombre_campo = null;
            this.cb_barrioE._Nombre_tabla = null;
            this.cb_barrioE._tabla_cargar_combo = null;
            this.cb_barrioE._tabla_cargar_descriptor = null;
            this.cb_barrioE._tabla_cargar_pk = null;
            this.cb_barrioE._Validable = false;
            this.cb_barrioE.FormattingEnabled = true;
            this.cb_barrioE.Location = new System.Drawing.Point(81, 178);
            this.cb_barrioE.Name = "cb_barrioE";
            this.cb_barrioE.Size = new System.Drawing.Size(121, 21);
            this.cb_barrioE.TabIndex = 25;
            // 
            // cb_localidadE
            // 
            this.cb_localidadE._ComboSinSeleccion = false;
            this.cb_localidadE._MensajeError = null;
            this.cb_localidadE._Nombre_campo = null;
            this.cb_localidadE._Nombre_tabla = null;
            this.cb_localidadE._tabla_cargar_combo = null;
            this.cb_localidadE._tabla_cargar_descriptor = null;
            this.cb_localidadE._tabla_cargar_pk = null;
            this.cb_localidadE._Validable = false;
            this.cb_localidadE.FormattingEnabled = true;
            this.cb_localidadE.Location = new System.Drawing.Point(81, 147);
            this.cb_localidadE.Name = "cb_localidadE";
            this.cb_localidadE.Size = new System.Drawing.Size(121, 21);
            this.cb_localidadE.TabIndex = 24;
            this.cb_localidadE.SelectedIndexChanged += new System.EventHandler(this.cb_localidadE_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Barrio:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Localidad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Depto";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Piso
            // 
            this.Piso.AutoSize = true;
            this.Piso.Location = new System.Drawing.Point(45, 87);
            this.Piso.Name = "Piso";
            this.Piso.Size = new System.Drawing.Size(30, 13);
            this.Piso.TabIndex = 20;
            this.Piso.Text = "Piso:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Calle:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Número:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cb_CargoE
            // 
            this.cb_CargoE._ComboSinSeleccion = false;
            this.cb_CargoE._MensajeError = null;
            this.cb_CargoE._Nombre_campo = null;
            this.cb_CargoE._Nombre_tabla = null;
            this.cb_CargoE._tabla_cargar_combo = null;
            this.cb_CargoE._tabla_cargar_descriptor = null;
            this.cb_CargoE._tabla_cargar_pk = null;
            this.cb_CargoE._Validable = false;
            this.cb_CargoE.FormattingEnabled = true;
            this.cb_CargoE.Location = new System.Drawing.Point(116, 172);
            this.cb_CargoE.Name = "cb_CargoE";
            this.cb_CargoE.Size = new System.Drawing.Size(121, 21);
            this.cb_CargoE.TabIndex = 14;
            this.cb_CargoE.SelectedIndexChanged += new System.EventHandler(this.cb_CargoE_SelectedIndexChanged);
            // 
            // cb_documentoE
            // 
            this.cb_documentoE._ComboSinSeleccion = false;
            this.cb_documentoE._MensajeError = null;
            this.cb_documentoE._Nombre_campo = null;
            this.cb_documentoE._Nombre_tabla = null;
            this.cb_documentoE._tabla_cargar_combo = null;
            this.cb_documentoE._tabla_cargar_descriptor = null;
            this.cb_documentoE._tabla_cargar_pk = null;
            this.cb_documentoE._Validable = false;
            this.cb_documentoE.FormattingEnabled = true;
            this.cb_documentoE.Location = new System.Drawing.Point(116, 37);
            this.cb_documentoE.Name = "cb_documentoE";
            this.cb_documentoE.Size = new System.Drawing.Size(121, 21);
            this.cb_documentoE.TabIndex = 4;
            this.cb_documentoE.SelectedIndexChanged += new System.EventHandler(this.cb_documentoE_SelectedIndexChanged);
            // 
            // cb_tipoDocE
            // 
            this.cb_tipoDocE._ComboSinSeleccion = false;
            this.cb_tipoDocE._MensajeError = null;
            this.cb_tipoDocE._Nombre_campo = null;
            this.cb_tipoDocE._Nombre_tabla = null;
            this.cb_tipoDocE._tabla_cargar_combo = null;
            this.cb_tipoDocE._tabla_cargar_descriptor = null;
            this.cb_tipoDocE._tabla_cargar_pk = null;
            this.cb_tipoDocE._Validable = false;
            this.cb_tipoDocE.FormattingEnabled = true;
            this.cb_tipoDocE.Location = new System.Drawing.Point(116, 12);
            this.cb_tipoDocE.Name = "cb_tipoDocE";
            this.cb_tipoDocE.Size = new System.Drawing.Size(121, 21);
            this.cb_tipoDocE.TabIndex = 0;
            this.cb_tipoDocE.SelectedIndexChanged += new System.EventHandler(this.comboBox011_SelectedIndexChanged);
            // 
            // Frm_ModificarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_CargoE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dp_FechaNacE);
            this.Controls.Add(this.dp_FechaIngE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ApellidoE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NombreE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_documentoE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_tipoDocE);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ModificarEmpleado";
            this.Text = "Frm_ModificarEmpleado";
            this.Load += new System.EventHandler(this.Frm_ModificarEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.ComboBox01 cb_tipoDocE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Clases.ComboBox01 cb_documentoE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NombreE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ApellidoE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dp_FechaIngE;
        private System.Windows.Forms.DateTimePicker dp_FechaNacE;
        private System.Windows.Forms.Label label6;
        private Clases.ComboBox01 cb_CargoE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_deptoE;
        private System.Windows.Forms.TextBox txt_pisoE;
        private System.Windows.Forms.TextBox txt_numeroE;
        private System.Windows.Forms.TextBox txt_calleE;
        private Clases.ComboBox01 cb_barrioE;
        private Clases.ComboBox01 cb_localidadE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Piso;
    }
}