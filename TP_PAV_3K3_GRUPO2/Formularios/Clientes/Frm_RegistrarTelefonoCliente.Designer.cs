
namespace TP_PAV_3K3_GRUPO2.Formularios.Clientes
{
    partial class Frm_RegistrarTelefonoCliente
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
            this.txt_numtel = new System.Windows.Forms.TextBox();
            this.cmb_tipotel = new System.Windows.Forms.ComboBox();
            this.btn_RegistrarTelefonoCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cuil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Telefono";
            // 
            // txt_numtel
            // 
            this.txt_numtel.Location = new System.Drawing.Point(171, 87);
            this.txt_numtel.Name = "txt_numtel";
            this.txt_numtel.Size = new System.Drawing.Size(132, 26);
            this.txt_numtel.TabIndex = 2;
            this.txt_numtel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // cmb_tipotel
            // 
            this.cmb_tipotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipotel.FormattingEnabled = true;
            this.cmb_tipotel.Location = new System.Drawing.Point(171, 126);
            this.cmb_tipotel.Name = "cmb_tipotel";
            this.cmb_tipotel.Size = new System.Drawing.Size(132, 28);
            this.cmb_tipotel.TabIndex = 3;
            // 
            // btn_RegistrarTelefonoCliente
            // 
            this.btn_RegistrarTelefonoCliente.Location = new System.Drawing.Point(323, 161);
            this.btn_RegistrarTelefonoCliente.Name = "btn_RegistrarTelefonoCliente";
            this.btn_RegistrarTelefonoCliente.Size = new System.Drawing.Size(98, 33);
            this.btn_RegistrarTelefonoCliente.TabIndex = 4;
            this.btn_RegistrarTelefonoCliente.Text = "Registrar";
            this.btn_RegistrarTelefonoCliente.UseVisualStyleBackColor = true;
            this.btn_RegistrarTelefonoCliente.Click += new System.EventHandler(this.btn_RegistrarTelefonoCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cuil";
            // 
            // txt_cuil
            // 
            this.txt_cuil.Enabled = false;
            this.txt_cuil.Location = new System.Drawing.Point(171, 47);
            this.txt_cuil.Name = "txt_cuil";
            this.txt_cuil.Size = new System.Drawing.Size(132, 26);
            this.txt_cuil.TabIndex = 6;
            // 
            // Frm_RegistrarTelefonoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 206);
            this.Controls.Add(this.txt_cuil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_RegistrarTelefonoCliente);
            this.Controls.Add(this.cmb_tipotel);
            this.Controls.Add(this.txt_numtel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_RegistrarTelefonoCliente";
            this.Text = "Registrar Telefono de Cliente";
            this.Load += new System.EventHandler(this.Frm_RegistrarTelefonoCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_numtel;
        private System.Windows.Forms.ComboBox cmb_tipotel;
        private System.Windows.Forms.Button btn_RegistrarTelefonoCliente;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_cuil;
    }
}