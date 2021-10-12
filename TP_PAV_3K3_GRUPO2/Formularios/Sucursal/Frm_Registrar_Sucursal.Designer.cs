
namespace TP_PAV_3K3_GRUPO2.Formularios.Sucursal
{
    partial class Frm_Registrar_Sucursal
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_Localidad = new System.Windows.Forms.ComboBox();
            this.cmb_Barrio = new System.Windows.Forms.ComboBox();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.txt_depto = new System.Windows.Forms.TextBox();
            this.txt_piso = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.txt_numtel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_tipotel = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Calle:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Piso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Depto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Localidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Barrio:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_Localidad);
            this.groupBox1.Controls.Add(this.cmb_Barrio);
            this.groupBox1.Controls.Add(this.txt_calle);
            this.groupBox1.Controls.Add(this.txt_depto);
            this.groupBox1.Controls.Add(this.txt_piso);
            this.groupBox1.Controls.Add(this.txt_numero);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(98, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 265);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direccion";
            // 
            // cmb_Localidad
            // 
            this.cmb_Localidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Localidad.FormattingEnabled = true;
            this.cmb_Localidad.Location = new System.Drawing.Point(103, 212);
            this.cmb_Localidad.Name = "cmb_Localidad";
            this.cmb_Localidad.Size = new System.Drawing.Size(127, 28);
            this.cmb_Localidad.TabIndex = 16;
            this.cmb_Localidad.SelectedValueChanged += new System.EventHandler(this.cmb_Localidad_SelectedValueChanged);
            // 
            // cmb_Barrio
            // 
            this.cmb_Barrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Barrio.Enabled = false;
            this.cmb_Barrio.FormattingEnabled = true;
            this.cmb_Barrio.Location = new System.Drawing.Point(103, 178);
            this.cmb_Barrio.Name = "cmb_Barrio";
            this.cmb_Barrio.Size = new System.Drawing.Size(127, 28);
            this.cmb_Barrio.TabIndex = 15;
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(103, 50);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(127, 26);
            this.txt_calle.TabIndex = 14;
            // 
            // txt_depto
            // 
            this.txt_depto.Location = new System.Drawing.Point(103, 146);
            this.txt_depto.Name = "txt_depto";
            this.txt_depto.Size = new System.Drawing.Size(127, 26);
            this.txt_depto.TabIndex = 11;
            this.txt_depto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_depto_KeyPress);
            // 
            // txt_piso
            // 
            this.txt_piso.Location = new System.Drawing.Point(103, 114);
            this.txt_piso.Name = "txt_piso";
            this.txt_piso.Size = new System.Drawing.Size(127, 26);
            this.txt_piso.TabIndex = 12;
            this.txt_piso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_piso_KeyPress);
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(103, 82);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(127, 26);
            this.txt_numero.TabIndex = 10;
            this.txt_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero_KeyPress);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(201, 38);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(127, 26);
            this.txt_id.TabIndex = 9;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(496, 38);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(201, 73);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(127, 26);
            this.txt_Descripcion.TabIndex = 13;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(380, 450);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(104, 35);
            this.btn_Registrar.TabIndex = 14;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // txt_numtel
            // 
            this.txt_numtel.Location = new System.Drawing.Point(201, 105);
            this.txt_numtel.Name = "txt_numtel";
            this.txt_numtel.Size = new System.Drawing.Size(127, 26);
            this.txt_numtel.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Telefono:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(86, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tipo Telefono:";
            // 
            // cmb_tipotel
            // 
            this.cmb_tipotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipotel.FormattingEnabled = true;
            this.cmb_tipotel.Location = new System.Drawing.Point(201, 140);
            this.cmb_tipotel.Name = "cmb_tipotel";
            this.cmb_tipotel.Size = new System.Drawing.Size(127, 28);
            this.cmb_tipotel.TabIndex = 19;
            // 
            // Frm_Registrar_Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 497);
            this.Controls.Add(this.cmb_tipotel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_numtel);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Registrar_Sucursal";
            this.Text = "Registrar Sucursal";
            this.Load += new System.EventHandler(this.Frm_Registrar_Sucursal_Load);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_Localidad;
        private System.Windows.Forms.ComboBox cmb_Barrio;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.TextBox txt_depto;
        private System.Windows.Forms.TextBox txt_piso;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.TextBox txt_numtel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_tipotel;
    }
}