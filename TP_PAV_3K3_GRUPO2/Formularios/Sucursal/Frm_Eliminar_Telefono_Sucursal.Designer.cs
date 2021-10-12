
namespace TP_PAV_3K3_GRUPO2.Formularios.Sucursal
{
    partial class Frm_Eliminar_Telefono_Sucursal
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
            this.cmb_numtel = new System.Windows.Forms.ComboBox();
            this.txt_idsede = new System.Windows.Forms.TextBox();
            this.txt_tipotel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Sede:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Telefono:";
            // 
            // cmb_numtel
            // 
            this.cmb_numtel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_numtel.FormattingEnabled = true;
            this.cmb_numtel.Location = new System.Drawing.Point(144, 60);
            this.cmb_numtel.Name = "cmb_numtel";
            this.cmb_numtel.Size = new System.Drawing.Size(121, 28);
            this.cmb_numtel.TabIndex = 3;
            this.cmb_numtel.SelectedIndexChanged += new System.EventHandler(this.cmb_numtel_SelectedIndexChanged);
            // 
            // txt_idsede
            // 
            this.txt_idsede.Enabled = false;
            this.txt_idsede.Location = new System.Drawing.Point(144, 28);
            this.txt_idsede.Name = "txt_idsede";
            this.txt_idsede.Size = new System.Drawing.Size(121, 26);
            this.txt_idsede.TabIndex = 4;
            // 
            // txt_tipotel
            // 
            this.txt_tipotel.Enabled = false;
            this.txt_tipotel.Location = new System.Drawing.Point(144, 94);
            this.txt_tipotel.Name = "txt_tipotel";
            this.txt_tipotel.Size = new System.Drawing.Size(121, 26);
            this.txt_tipotel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numero Telefono:";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(291, 120);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(82, 35);
            this.btn_Eliminar.TabIndex = 7;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // Frm_Eliminar_Telefono_Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 167);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tipotel);
            this.Controls.Add(this.txt_idsede);
            this.Controls.Add(this.cmb_numtel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Eliminar_Telefono_Sucursal";
            this.Text = "Frm_Eliminar_Telefono_Sucursal";
            this.Load += new System.EventHandler(this.Frm_Eliminar_Telefono_Sucursal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_numtel;
        private System.Windows.Forms.TextBox txt_tipotel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Eliminar;
        public System.Windows.Forms.TextBox txt_idsede;
    }
}