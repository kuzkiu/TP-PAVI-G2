
namespace TP_PAV_3K3_GRUPO2.Formularios.Sucursal
{
    partial class Frm_Reg_Telefono_Sucursal
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
            this.cmb_tipotel = new System.Windows.Forms.ComboBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Sucursal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Telefono:";
            // 
            // cmb_tipotel
            // 
            this.cmb_tipotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipotel.FormattingEnabled = true;
            this.cmb_tipotel.Location = new System.Drawing.Point(147, 114);
            this.cmb_tipotel.Name = "cmb_tipotel";
            this.cmb_tipotel.Size = new System.Drawing.Size(121, 28);
            this.cmb_tipotel.TabIndex = 3;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(148, 38);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(120, 26);
            this.txt_id.TabIndex = 4;
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(148, 76);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(120, 26);
            this.txt_num.TabIndex = 5;
            this.txt_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num_KeyPress);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(236, 148);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(106, 39);
            this.btn_Registrar.TabIndex = 6;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // Frm_Reg_Telefono_Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 199);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.cmb_tipotel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Reg_Telefono_Sucursal";
            this.Text = "Registrar Telefono";
            this.Load += new System.EventHandler(this.Frm_Reg_Telefono_Sucursal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_tipotel;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Button btn_Registrar;
        public System.Windows.Forms.TextBox txt_id;
    }
}