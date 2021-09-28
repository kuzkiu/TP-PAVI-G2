
namespace TP_PAV_3K3_GRUPO2.Formularios.Clientes
{
    partial class Frm_ModificarTelefonoCliente
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
            this.btn_modificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cuil = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.cmb_numero = new System.Windows.Forms.ComboBox();
            this.cmb_tipotel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(306, 214);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(108, 33);
            this.btn_modificar.TabIndex = 0;
            this.btn_modificar.Text = "Confirmar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cuil:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "NumeroActual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nuevo Numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "TipoTelefono";
            // 
            // txt_cuil
            // 
            this.txt_cuil.Location = new System.Drawing.Point(163, 34);
            this.txt_cuil.Name = "txt_cuil";
            this.txt_cuil.Size = new System.Drawing.Size(121, 26);
            this.txt_cuil.TabIndex = 5;
            // 
            // txt_numero
            // 
            this.txt_numero.Enabled = false;
            this.txt_numero.Location = new System.Drawing.Point(163, 132);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(121, 26);
            this.txt_numero.TabIndex = 6;
            this.txt_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero_KeyPress);
            // 
            // cmb_numero
            // 
            this.cmb_numero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_numero.FormattingEnabled = true;
            this.cmb_numero.Location = new System.Drawing.Point(163, 82);
            this.cmb_numero.Name = "cmb_numero";
            this.cmb_numero.Size = new System.Drawing.Size(121, 28);
            this.cmb_numero.TabIndex = 7;
            this.cmb_numero.SelectionChangeCommitted += new System.EventHandler(this.cmb_numero_SelectionChangeCommitted);
            // 
            // cmb_tipotel
            // 
            this.cmb_tipotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipotel.Enabled = false;
            this.cmb_tipotel.FormattingEnabled = true;
            this.cmb_tipotel.Location = new System.Drawing.Point(163, 175);
            this.cmb_tipotel.Name = "cmb_tipotel";
            this.cmb_tipotel.Size = new System.Drawing.Size(121, 28);
            this.cmb_tipotel.TabIndex = 8;
            // 
            // Frm_ModificarTelefonoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 259);
            this.Controls.Add(this.cmb_tipotel);
            this.Controls.Add(this.cmb_numero);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.txt_cuil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_modificar);
            this.Name = "Frm_ModificarTelefonoCliente";
            this.Text = "Modificar Telefono de Cliente";
            this.Load += new System.EventHandler(this.Frm_ModificarTelefonoCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.ComboBox cmb_tipotel;
        public System.Windows.Forms.TextBox txt_cuil;
        private System.Windows.Forms.ComboBox cmb_numero;
    }
}