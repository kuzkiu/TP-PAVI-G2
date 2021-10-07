
namespace TP_PAV_3K3_GRUPO2.Formularios.Tipo_Telefono
{
    partial class Frm_BajaTipoTelefono
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
            this.txt_id_tipo_telefono = new TP_PAV_3K3_GRUPO2.Clases.Label_Text();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar Tipo Telefono";
            // 
            // txt_id_tipo_telefono
            // 
            this.txt_id_tipo_telefono._Ancho = 3;
            this.txt_id_tipo_telefono._Decimales = 0;
            this.txt_id_tipo_telefono._Etiqueta = "id Tipo Telefono";
            this.txt_id_tipo_telefono._MensajeError = null;
            this.txt_id_tipo_telefono._Nobre_tabla = null;
            this.txt_id_tipo_telefono._Nombre_campo = null;
            this.txt_id_tipo_telefono._ReadOnly = false;
            this.txt_id_tipo_telefono._Text = "";
            this.txt_id_tipo_telefono._TipoDato = TP_PAV_3K3_GRUPO2.Clases.Label_Text.TipoDato.numero;
            this.txt_id_tipo_telefono._Validable = false;
            this.txt_id_tipo_telefono.Location = new System.Drawing.Point(32, 103);
            this.txt_id_tipo_telefono.Name = "txt_id_tipo_telefono";
            this.txt_id_tipo_telefono.Size = new System.Drawing.Size(224, 28);
            this.txt_id_tipo_telefono.TabIndex = 1;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(116, 154);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(84, 41);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // Frm_BajaTipoTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 251);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.txt_id_tipo_telefono);
            this.Controls.Add(this.label1);
            this.Name = "Frm_BajaTipoTelefono";
            this.Text = "Frm_BajaTipoTelefono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Clases.Label_Text txt_id_tipo_telefono;
        private System.Windows.Forms.Button btn_eliminar;
    }
}