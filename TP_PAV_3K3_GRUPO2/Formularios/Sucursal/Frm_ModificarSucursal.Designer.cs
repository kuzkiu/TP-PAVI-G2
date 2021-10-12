
namespace TP_PAV_3K3_GRUPO2.Formularios.Sucursal
{
    partial class Frm_ModificarSucursal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_piso = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.txt_depto = new System.Windows.Forms.TextBox();
            this.cmb_Localidad = new System.Windows.Forms.ComboBox();
            this.cmb_barrio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_idsede = new System.Windows.Forms.ComboBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_telefonos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Sucursal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_piso);
            this.groupBox1.Controls.Add(this.txt_numero);
            this.groupBox1.Controls.Add(this.txt_calle);
            this.groupBox1.Controls.Add(this.txt_depto);
            this.groupBox1.Controls.Add(this.cmb_Localidad);
            this.groupBox1.Controls.Add(this.cmb_barrio);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(51, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 244);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direccion";
            // 
            // txt_piso
            // 
            this.txt_piso.Enabled = false;
            this.txt_piso.Location = new System.Drawing.Point(102, 89);
            this.txt_piso.Name = "txt_piso";
            this.txt_piso.Size = new System.Drawing.Size(121, 26);
            this.txt_piso.TabIndex = 13;
            this.txt_piso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_piso_KeyPress);
            // 
            // txt_numero
            // 
            this.txt_numero.Enabled = false;
            this.txt_numero.Location = new System.Drawing.Point(102, 57);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(121, 26);
            this.txt_numero.TabIndex = 12;
            this.txt_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero_KeyPress);
            // 
            // txt_calle
            // 
            this.txt_calle.Enabled = false;
            this.txt_calle.Location = new System.Drawing.Point(102, 25);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(121, 26);
            this.txt_calle.TabIndex = 11;
            // 
            // txt_depto
            // 
            this.txt_depto.Enabled = false;
            this.txt_depto.Location = new System.Drawing.Point(102, 121);
            this.txt_depto.Name = "txt_depto";
            this.txt_depto.Size = new System.Drawing.Size(121, 26);
            this.txt_depto.TabIndex = 10;
            this.txt_depto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_depto_KeyPress);
            // 
            // cmb_Localidad
            // 
            this.cmb_Localidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Localidad.Location = new System.Drawing.Point(102, 187);
            this.cmb_Localidad.Name = "cmb_Localidad";
            this.cmb_Localidad.Size = new System.Drawing.Size(121, 28);
            this.cmb_Localidad.TabIndex = 9;
            this.cmb_Localidad.SelectedValueChanged += new System.EventHandler(this.cmb_Localidad_SelectedValueChanged);
            // 
            // cmb_barrio
            // 
            this.cmb_barrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_barrio.Location = new System.Drawing.Point(102, 153);
            this.cmb_barrio.Name = "cmb_barrio";
            this.cmb_barrio.Size = new System.Drawing.Size(121, 28);
            this.cmb_barrio.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Localidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Barrio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Piso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Depto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Calle:";
            // 
            // cmb_idsede
            // 
            this.cmb_idsede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_idsede.FormattingEnabled = true;
            this.cmb_idsede.Location = new System.Drawing.Point(153, 29);
            this.cmb_idsede.Name = "cmb_idsede";
            this.cmb_idsede.Size = new System.Drawing.Size(121, 28);
            this.cmb_idsede.TabIndex = 3;
            this.cmb_idsede.SelectedValueChanged += new System.EventHandler(this.cmb_idsede_SelectedValueChanged);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Enabled = false;
            this.txt_descripcion.Location = new System.Drawing.Point(153, 64);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(121, 26);
            this.txt_descripcion.TabIndex = 11;
            this.txt_descripcion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(285, 344);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(97, 38);
            this.btn_Modificar.TabIndex = 12;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_telefonos
            // 
            this.btn_telefonos.Enabled = false;
            this.btn_telefonos.Location = new System.Drawing.Point(12, 344);
            this.btn_telefonos.Name = "btn_telefonos";
            this.btn_telefonos.Size = new System.Drawing.Size(100, 38);
            this.btn_telefonos.TabIndex = 13;
            this.btn_telefonos.Text = "Telefonos";
            this.btn_telefonos.UseVisualStyleBackColor = true;
            this.btn_telefonos.Click += new System.EventHandler(this.btn_telefonos_Click);
            // 
            // Frm_ModificarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 394);
            this.Controls.Add(this.btn_telefonos);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.cmb_idsede);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ModificarSucursal";
            this.Text = "Modificar Sucursal";
            this.Load += new System.EventHandler(this.Frm_ModificarSucursal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_piso;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.TextBox txt_depto;
        private System.Windows.Forms.ComboBox cmb_Localidad;
        private System.Windows.Forms.ComboBox cmb_barrio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_idsede;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_telefonos;
    }
}