
namespace TP_PAV_3K3_GRUPO2.Formularios.Empleados
{
    partial class Frm_BajaEmpleado
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dp_FechaNac_E = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dp_FechaIng_E = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_nombreE = new System.Windows.Forms.TextBox();
            this.txt_apellidoE = new System.Windows.Forms.TextBox();
            this.txt_cargoE = new System.Windows.Forms.TextBox();
            this.txt_calleE = new System.Windows.Forms.TextBox();
            this.txt_numeroE = new System.Windows.Forms.TextBox();
            this.txt_pisoE = new System.Windows.Forms.TextBox();
            this.txt_deptoE = new System.Windows.Forms.TextBox();
            this.txt_localidadE = new System.Windows.Forms.TextBox();
            this.txt_barrioE = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_documentoE = new TP_PAV_3K3_GRUPO2.Clases.ComboBox01();
            this.cb_tipoDocE = new TP_PAV_3K3_GRUPO2.Clases.ComboBox01();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido:";
            // 
            // dp_FechaNac_E
            // 
            this.dp_FechaNac_E.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_FechaNac_E.Location = new System.Drawing.Point(139, 131);
            this.dp_FechaNac_E.Name = "dp_FechaNac_E";
            this.dp_FechaNac_E.Size = new System.Drawing.Size(123, 20);
            this.dp_FechaNac_E.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha de nacimiento:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha de ingreso:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dp_FechaIng_E
            // 
            this.dp_FechaIng_E.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_FechaIng_E.Location = new System.Drawing.Point(139, 158);
            this.dp_FechaIng_E.Name = "dp_FechaIng_E";
            this.dp_FechaIng_E.Size = new System.Drawing.Size(123, 20);
            this.dp_FechaIng_E.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cargo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_barrioE);
            this.groupBox1.Controls.Add(this.txt_localidadE);
            this.groupBox1.Controls.Add(this.txt_deptoE);
            this.groupBox1.Controls.Add(this.txt_pisoE);
            this.groupBox1.Controls.Add(this.txt_numeroE);
            this.groupBox1.Controls.Add(this.txt_calleE);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(62, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 167);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direccion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Calle:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Numero:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Piso:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Depto:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Localidad:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Barrio:";
            // 
            // txt_nombreE
            // 
            this.txt_nombreE.Location = new System.Drawing.Point(138, 82);
            this.txt_nombreE.Name = "txt_nombreE";
            this.txt_nombreE.Size = new System.Drawing.Size(124, 20);
            this.txt_nombreE.TabIndex = 12;
            this.txt_nombreE.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_apellidoE
            // 
            this.txt_apellidoE.Location = new System.Drawing.Point(138, 105);
            this.txt_apellidoE.Name = "txt_apellidoE";
            this.txt_apellidoE.Size = new System.Drawing.Size(124, 20);
            this.txt_apellidoE.TabIndex = 13;
            // 
            // txt_cargoE
            // 
            this.txt_cargoE.Location = new System.Drawing.Point(139, 183);
            this.txt_cargoE.Name = "txt_cargoE";
            this.txt_cargoE.Size = new System.Drawing.Size(123, 20);
            this.txt_cargoE.TabIndex = 14;
            // 
            // txt_calleE
            // 
            this.txt_calleE.Location = new System.Drawing.Point(77, 18);
            this.txt_calleE.Name = "txt_calleE";
            this.txt_calleE.Size = new System.Drawing.Size(123, 20);
            this.txt_calleE.TabIndex = 6;
            // 
            // txt_numeroE
            // 
            this.txt_numeroE.Location = new System.Drawing.Point(76, 44);
            this.txt_numeroE.Name = "txt_numeroE";
            this.txt_numeroE.Size = new System.Drawing.Size(124, 20);
            this.txt_numeroE.TabIndex = 7;
            // 
            // txt_pisoE
            // 
            this.txt_pisoE.Location = new System.Drawing.Point(76, 70);
            this.txt_pisoE.Name = "txt_pisoE";
            this.txt_pisoE.Size = new System.Drawing.Size(124, 20);
            this.txt_pisoE.TabIndex = 8;
            // 
            // txt_deptoE
            // 
            this.txt_deptoE.Location = new System.Drawing.Point(76, 96);
            this.txt_deptoE.Name = "txt_deptoE";
            this.txt_deptoE.Size = new System.Drawing.Size(124, 20);
            this.txt_deptoE.TabIndex = 15;
            // 
            // txt_localidadE
            // 
            this.txt_localidadE.Location = new System.Drawing.Point(76, 122);
            this.txt_localidadE.Name = "txt_localidadE";
            this.txt_localidadE.Size = new System.Drawing.Size(124, 20);
            this.txt_localidadE.TabIndex = 16;
            // 
            // txt_barrioE
            // 
            this.txt_barrioE.Location = new System.Drawing.Point(76, 147);
            this.txt_barrioE.Name = "txt_barrioE";
            this.txt_barrioE.Size = new System.Drawing.Size(124, 20);
            this.txt_barrioE.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.cb_documentoE.Location = new System.Drawing.Point(138, 54);
            this.cb_documentoE.Name = "cb_documentoE";
            this.cb_documentoE.Size = new System.Drawing.Size(124, 21);
            this.cb_documentoE.TabIndex = 11;
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
            this.cb_tipoDocE.Location = new System.Drawing.Point(138, 29);
            this.cb_tipoDocE.Name = "cb_tipoDocE";
            this.cb_tipoDocE.Size = new System.Drawing.Size(124, 21);
            this.cb_tipoDocE.TabIndex = 10;
            this.cb_tipoDocE.SelectedIndexChanged += new System.EventHandler(this.cb_tipoDocE_SelectedIndexChanged);
            // 
            // Frm_BajaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_cargoE);
            this.Controls.Add(this.txt_apellidoE);
            this.Controls.Add(this.txt_nombreE);
            this.Controls.Add(this.cb_documentoE);
            this.Controls.Add(this.cb_tipoDocE);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dp_FechaIng_E);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dp_FechaNac_E);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_BajaEmpleado";
            this.Text = "Frm_BajaEmpleado";
            this.Load += new System.EventHandler(this.Frm_BajaEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dp_FechaNac_E;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dp_FechaIng_E;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Clases.ComboBox01 cb_tipoDocE;
        private Clases.ComboBox01 cb_documentoE;
        private System.Windows.Forms.TextBox txt_nombreE;
        private System.Windows.Forms.TextBox txt_apellidoE;
        private System.Windows.Forms.TextBox txt_cargoE;
        private System.Windows.Forms.TextBox txt_barrioE;
        private System.Windows.Forms.TextBox txt_localidadE;
        private System.Windows.Forms.TextBox txt_deptoE;
        private System.Windows.Forms.TextBox txt_pisoE;
        private System.Windows.Forms.TextBox txt_numeroE;
        private System.Windows.Forms.TextBox txt_calleE;
        private System.Windows.Forms.Button button1;
    }
}