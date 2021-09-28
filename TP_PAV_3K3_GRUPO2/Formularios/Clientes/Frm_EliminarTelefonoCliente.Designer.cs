
namespace TP_PAV_3K3_GRUPO2.Formularios.Clientes
{
    partial class Frm_EliminarTelefonoCliente
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
            this.txt_cuil = new System.Windows.Forms.TextBox();
            this.txt_tipotel = new System.Windows.Forms.TextBox();
            this.cmb_numtel = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuil:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Teléfono:";
            // 
            // txt_cuil
            // 
            this.txt_cuil.Location = new System.Drawing.Point(163, 37);
            this.txt_cuil.Name = "txt_cuil";
            this.txt_cuil.Size = new System.Drawing.Size(141, 26);
            this.txt_cuil.TabIndex = 3;
            // 
            // txt_tipotel
            // 
            this.txt_tipotel.Enabled = false;
            this.txt_tipotel.Location = new System.Drawing.Point(163, 140);
            this.txt_tipotel.Name = "txt_tipotel";
            this.txt_tipotel.Size = new System.Drawing.Size(141, 26);
            this.txt_tipotel.TabIndex = 4;
            // 
            // cmb_numtel
            // 
            this.cmb_numtel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_numtel.FormattingEnabled = true;
            this.cmb_numtel.Location = new System.Drawing.Point(163, 89);
            this.cmb_numtel.Name = "cmb_numtel";
            this.cmb_numtel.Size = new System.Drawing.Size(141, 28);
            this.cmb_numtel.TabIndex = 5;
            this.cmb_numtel.SelectedValueChanged += new System.EventHandler(this.cmb_numtel_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_EliminarTelefonoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 213);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_numtel);
            this.Controls.Add(this.txt_tipotel);
            this.Controls.Add(this.txt_cuil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_EliminarTelefonoCliente";
            this.Text = "Eliminar Telefono de Cliente";
            this.Load += new System.EventHandler(this.Frm_EliminarTelefonoCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tipotel;
        private System.Windows.Forms.ComboBox cmb_numtel;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txt_cuil;
    }
}