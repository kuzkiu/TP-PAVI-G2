
namespace TP_PAV_3K3_GRUPO2
{
    partial class Frm_RegEmpleado
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
            this.cb_tipoDocE = new System.Windows.Forms.ComboBox();
            this.txt_DocumentoE = new System.Windows.Forms.TextBox();
            this.txt_NombreE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ApellidoE = new System.Windows.Forms.TextBox();
            this.dp_FechaNacE = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dp_FechaIngE = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_cargoE = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_localidadE = new System.Windows.Forms.TextBox();
            this.txt_barrioE = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_deptoE = new System.Windows.Forms.TextBox();
            this.txt_pisoE = new System.Windows.Forms.TextBox();
            this.txt_NumeroE = new System.Windows.Forms.TextBox();
            this.txt_calleE = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Doc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nro Documento";
            // 
            // cb_tipoDocE
            // 
            this.cb_tipoDocE.FormattingEnabled = true;
            this.cb_tipoDocE.Location = new System.Drawing.Point(156, 18);
            this.cb_tipoDocE.Name = "cb_tipoDocE";
            this.cb_tipoDocE.Size = new System.Drawing.Size(121, 21);
            this.cb_tipoDocE.TabIndex = 3;
            this.cb_tipoDocE.SelectedIndexChanged += new System.EventHandler(this.cb_tipoDocE_SelectedIndexChanged);
            // 
            // txt_DocumentoE
            // 
            this.txt_DocumentoE.Location = new System.Drawing.Point(156, 44);
            this.txt_DocumentoE.Name = "txt_DocumentoE";
            this.txt_DocumentoE.Size = new System.Drawing.Size(121, 20);
            this.txt_DocumentoE.TabIndex = 4;
            this.txt_DocumentoE.TextChanged += new System.EventHandler(this.txt_DocumentoE_TextChanged);
            // 
            // txt_NombreE
            // 
            this.txt_NombreE.Location = new System.Drawing.Point(156, 70);
            this.txt_NombreE.Name = "txt_NombreE";
            this.txt_NombreE.Size = new System.Drawing.Size(121, 20);
            this.txt_NombreE.TabIndex = 5;
            this.txt_NombreE.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellido";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_ApellidoE
            // 
            this.txt_ApellidoE.Location = new System.Drawing.Point(156, 97);
            this.txt_ApellidoE.Name = "txt_ApellidoE";
            this.txt_ApellidoE.Size = new System.Drawing.Size(121, 20);
            this.txt_ApellidoE.TabIndex = 7;
            // 
            // dp_FechaNacE
            // 
            this.dp_FechaNacE.Location = new System.Drawing.Point(156, 123);
            this.dp_FechaNacE.Name = "dp_FechaNacE";
            this.dp_FechaNacE.Size = new System.Drawing.Size(121, 20);
            this.dp_FechaNacE.TabIndex = 8;
            this.dp_FechaNacE.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha nacimiento";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha ingreso";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dp_FechaIngE
            // 
            this.dp_FechaIngE.Location = new System.Drawing.Point(156, 148);
            this.dp_FechaIngE.Name = "dp_FechaIngE";
            this.dp_FechaIngE.Size = new System.Drawing.Size(121, 20);
            this.dp_FechaIngE.TabIndex = 11;
            this.dp_FechaIngE.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cargo";
            // 
            // cb_cargoE
            // 
            this.cb_cargoE.FormattingEnabled = true;
            this.cb_cargoE.Location = new System.Drawing.Point(156, 175);
            this.cb_cargoE.Name = "cb_cargoE";
            this.cb_cargoE.Size = new System.Drawing.Size(121, 21);
            this.cb_cargoE.TabIndex = 13;
            this.cb_cargoE.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_localidadE);
            this.groupBox1.Controls.Add(this.txt_barrioE);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_deptoE);
            this.groupBox1.Controls.Add(this.txt_pisoE);
            this.groupBox1.Controls.Add(this.txt_NumeroE);
            this.groupBox1.Controls.Add(this.txt_calleE);
            this.groupBox1.Location = new System.Drawing.Point(53, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 161);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dirección";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_localidadE
            // 
            this.txt_localidadE.Location = new System.Drawing.Point(103, 135);
            this.txt_localidadE.Name = "txt_localidadE";
            this.txt_localidadE.Size = new System.Drawing.Size(121, 20);
            this.txt_localidadE.TabIndex = 11;
            // 
            // txt_barrioE
            // 
            this.txt_barrioE.Location = new System.Drawing.Point(103, 109);
            this.txt_barrioE.Name = "txt_barrioE";
            this.txt_barrioE.Size = new System.Drawing.Size(121, 20);
            this.txt_barrioE.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Localidad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Barrio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Piso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Depto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Calle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Número";
            // 
            // txt_deptoE
            // 
            this.txt_deptoE.Location = new System.Drawing.Point(103, 83);
            this.txt_deptoE.Name = "txt_deptoE";
            this.txt_deptoE.Size = new System.Drawing.Size(121, 20);
            this.txt_deptoE.TabIndex = 3;
            this.txt_deptoE.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txt_pisoE
            // 
            this.txt_pisoE.Location = new System.Drawing.Point(103, 57);
            this.txt_pisoE.Name = "txt_pisoE";
            this.txt_pisoE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_pisoE.Size = new System.Drawing.Size(121, 20);
            this.txt_pisoE.TabIndex = 2;
            this.txt_pisoE.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txt_NumeroE
            // 
            this.txt_NumeroE.Location = new System.Drawing.Point(103, 30);
            this.txt_NumeroE.Name = "txt_NumeroE";
            this.txt_NumeroE.Size = new System.Drawing.Size(121, 20);
            this.txt_NumeroE.TabIndex = 1;
            // 
            // txt_calleE
            // 
            this.txt_calleE.Location = new System.Drawing.Point(103, 3);
            this.txt_calleE.Name = "txt_calleE";
            this.txt_calleE.Size = new System.Drawing.Size(121, 20);
            this.txt_calleE.TabIndex = 0;
            this.txt_calleE.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_RegEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb_cargoE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dp_FechaIngE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dp_FechaNacE);
            this.Controls.Add(this.txt_ApellidoE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_NombreE);
            this.Controls.Add(this.txt_DocumentoE);
            this.Controls.Add(this.cb_tipoDocE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_RegEmpleado";
            this.Text = "Registrar empleado";
            this.Load += new System.EventHandler(this.Frm_RegEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_tipoDocE;
        private System.Windows.Forms.TextBox txt_DocumentoE;
        private System.Windows.Forms.TextBox txt_NombreE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ApellidoE;
        private System.Windows.Forms.DateTimePicker dp_FechaNacE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dp_FechaIngE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_cargoE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_calleE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_deptoE;
        private System.Windows.Forms.TextBox txt_pisoE;
        private System.Windows.Forms.TextBox txt_NumeroE;
        private System.Windows.Forms.TextBox txt_localidadE;
        private System.Windows.Forms.TextBox txt_barrioE;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}