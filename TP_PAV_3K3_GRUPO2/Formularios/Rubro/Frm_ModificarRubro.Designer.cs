
namespace TP_PAV_3K3_GRUPO2.Formularios.Rubro
{
    partial class Frm_ModificarRubro
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
            this.txt_idRubro = new TP_PAV_3K3_GRUPO2.Clases.Label_Text();
            this.txt_nomRubro = new TP_PAV_3K3_GRUPO2.Clases.Label_Text();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Rubro";
            // 
            // txt_idRubro
            // 
            this.txt_idRubro._Ancho = 3;
            this.txt_idRubro._Decimales = 0;
            this.txt_idRubro._Etiqueta = "id_Rubro";
            this.txt_idRubro._MensajeError = null;
            this.txt_idRubro._Nobre_tabla = null;
            this.txt_idRubro._Nombre_campo = null;
            this.txt_idRubro._ReadOnly = false;
            this.txt_idRubro._Text = "";
            this.txt_idRubro._TipoDato = TP_PAV_3K3_GRUPO2.Clases.Label_Text.TipoDato.numero;
            this.txt_idRubro._Validable = false;
            this.txt_idRubro.Location = new System.Drawing.Point(46, 87);
            this.txt_idRubro.Name = "txt_idRubro";
            this.txt_idRubro.Size = new System.Drawing.Size(177, 28);
            this.txt_idRubro.TabIndex = 1;
            // 
            // txt_nomRubro
            // 
            this.txt_nomRubro._Ancho = 30;
            this.txt_nomRubro._Decimales = 0;
            this.txt_nomRubro._Etiqueta = "nombre";
            this.txt_nomRubro._MensajeError = null;
            this.txt_nomRubro._Nobre_tabla = null;
            this.txt_nomRubro._Nombre_campo = null;
            this.txt_nomRubro._ReadOnly = false;
            this.txt_nomRubro._Text = "";
            this.txt_nomRubro._TipoDato = TP_PAV_3K3_GRUPO2.Clases.Label_Text.TipoDato.texto;
            this.txt_nomRubro._Validable = false;
            this.txt_nomRubro.Location = new System.Drawing.Point(46, 131);
            this.txt_nomRubro.Name = "txt_nomRubro";
            this.txt_nomRubro.Size = new System.Drawing.Size(166, 28);
            this.txt_nomRubro.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(131, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_ModificarRubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_nomRubro);
            this.Controls.Add(this.txt_idRubro);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ModificarRubro";
            this.Text = "Frm_ModificarRubro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Clases.Label_Text txt_idRubro;
        private Clases.Label_Text txt_nomRubro;
        private System.Windows.Forms.Button button1;
    }
}