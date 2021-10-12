
namespace TP_PAV_3K3_GRUPO2.Formularios.Sucursal
{
    partial class Frm_Modificar_Telefono_Sucursal
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
            this.txt_idsede = new System.Windows.Forms.TextBox();
            this.txt_numnuevo = new System.Windows.Forms.TextBox();
            this.cmb_tipotel = new System.Windows.Forms.ComboBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.cmb_telefono = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Sucursal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero Nuevo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero viejo:";
            // 
            // txt_idsede
            // 
            this.txt_idsede.Enabled = false;
            this.txt_idsede.Location = new System.Drawing.Point(159, 41);
            this.txt_idsede.Name = "txt_idsede";
            this.txt_idsede.Size = new System.Drawing.Size(140, 26);
            this.txt_idsede.TabIndex = 4;
            // 
            // txt_numnuevo
            // 
            this.txt_numnuevo.Location = new System.Drawing.Point(159, 120);
            this.txt_numnuevo.Name = "txt_numnuevo";
            this.txt_numnuevo.Size = new System.Drawing.Size(140, 26);
            this.txt_numnuevo.TabIndex = 5;
            // 
            // cmb_tipotel
            // 
            this.cmb_tipotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipotel.FormattingEnabled = true;
            this.cmb_tipotel.Location = new System.Drawing.Point(159, 163);
            this.cmb_tipotel.Name = "cmb_tipotel";
            this.cmb_tipotel.Size = new System.Drawing.Size(140, 28);
            this.cmb_tipotel.TabIndex = 7;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(317, 211);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(109, 46);
            this.btn_modificar.TabIndex = 8;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // cmb_telefono
            // 
            this.cmb_telefono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_telefono.FormattingEnabled = true;
            this.cmb_telefono.Location = new System.Drawing.Point(159, 81);
            this.cmb_telefono.Name = "cmb_telefono";
            this.cmb_telefono.Size = new System.Drawing.Size(139, 28);
            this.cmb_telefono.TabIndex = 9;
            this.cmb_telefono.SelectedValueChanged += new System.EventHandler(this.cmb_telefono_SelectedValueChanged);
            // 
            // Frm_Modificar_Telefono_Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 269);
            this.Controls.Add(this.cmb_telefono);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.cmb_tipotel);
            this.Controls.Add(this.txt_numnuevo);
            this.Controls.Add(this.txt_idsede);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Modificar_Telefono_Sucursal";
            this.Text = "Modificar Telefono de Sucursal";
            this.Load += new System.EventHandler(this.Frm_Modificar_Telefono_Sucursal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_idsede;
        private System.Windows.Forms.TextBox txt_numnuevo;
        private System.Windows.Forms.ComboBox cmb_tipotel;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.ComboBox cmb_telefono;
    }
}