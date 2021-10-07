
namespace TP_PAV_3K3_GRUPO2.Formularios.Tipo_Telefono
{
    partial class Frm_ModificarTipoTelefono
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
            this.txt_nombre_tipo_tel = new TP_PAV_3K3_GRUPO2.Clases.Label_Text();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Tipo Telefono";
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
            this.txt_id_tipo_telefono.Location = new System.Drawing.Point(34, 87);
            this.txt_id_tipo_telefono.Name = "txt_id_tipo_telefono";
            this.txt_id_tipo_telefono.Size = new System.Drawing.Size(221, 28);
            this.txt_id_tipo_telefono.TabIndex = 1;
            // 
            // txt_nombre_tipo_tel
            // 
            this.txt_nombre_tipo_tel._Ancho = 30;
            this.txt_nombre_tipo_tel._Decimales = 0;
            this.txt_nombre_tipo_tel._Etiqueta = "nombre";
            this.txt_nombre_tipo_tel._MensajeError = null;
            this.txt_nombre_tipo_tel._Nobre_tabla = null;
            this.txt_nombre_tipo_tel._Nombre_campo = null;
            this.txt_nombre_tipo_tel._ReadOnly = false;
            this.txt_nombre_tipo_tel._Text = "";
            this.txt_nombre_tipo_tel._TipoDato = TP_PAV_3K3_GRUPO2.Clases.Label_Text.TipoDato.texto;
            this.txt_nombre_tipo_tel._Validable = false;
            this.txt_nombre_tipo_tel.Location = new System.Drawing.Point(34, 122);
            this.txt_nombre_tipo_tel.Name = "txt_nombre_tipo_tel";
            this.txt_nombre_tipo_tel.Size = new System.Drawing.Size(166, 28);
            this.txt_nombre_tipo_tel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(125, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_ModificarTipoTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 249);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_nombre_tipo_tel);
            this.Controls.Add(this.txt_id_tipo_telefono);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ModificarTipoTelefono";
            this.Text = "Frm_ModificarTipoTelefono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Clases.Label_Text txt_id_tipo_telefono;
        private Clases.Label_Text txt_nombre_tipo_tel;
        private System.Windows.Forms.Button button1;
    }
}