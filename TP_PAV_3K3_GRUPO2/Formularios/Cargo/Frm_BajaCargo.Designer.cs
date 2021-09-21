
namespace TP_PAV_3K3_GRUPO2.Formularios.Cargo
{
    partial class Frm_BajaCargo
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
            this.txt_codigo_cargo = new TP_PAV_3K3_GRUPO2.Clases.Label_Text();
            this.txt_denominacion = new TP_PAV_3K3_GRUPO2.Clases.Label_Text();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar Cargo";
            // 
            // txt_codigo_cargo
            // 
            this.txt_codigo_cargo._Ancho = 3;
            this.txt_codigo_cargo._Decimales = 0;
            this.txt_codigo_cargo._Etiqueta = "Codigo Cargo";
            this.txt_codigo_cargo._MensajeError = null;
            this.txt_codigo_cargo._Nobre_tabla = null;
            this.txt_codigo_cargo._Nombre_campo = null;
            this.txt_codigo_cargo._ReadOnly = false;
            this.txt_codigo_cargo._Text = "";
            this.txt_codigo_cargo._TipoDato = TP_PAV_3K3_GRUPO2.Clases.Label_Text.TipoDato.numero;
            this.txt_codigo_cargo._Validable = false;
            this.txt_codigo_cargo.Location = new System.Drawing.Point(37, 70);
            this.txt_codigo_cargo.Name = "txt_codigo_cargo";
            this.txt_codigo_cargo.Size = new System.Drawing.Size(205, 28);
            this.txt_codigo_cargo.TabIndex = 1;
            // 
            // txt_denominacion
            // 
            this.txt_denominacion._Ancho = 20;
            this.txt_denominacion._Decimales = 0;
            this.txt_denominacion._Etiqueta = "Denominacion";
            this.txt_denominacion._MensajeError = null;
            this.txt_denominacion._Nobre_tabla = null;
            this.txt_denominacion._Nombre_campo = null;
            this.txt_denominacion._ReadOnly = false;
            this.txt_denominacion._Text = "";
            this.txt_denominacion._TipoDato = TP_PAV_3K3_GRUPO2.Clases.Label_Text.TipoDato.texto;
            this.txt_denominacion._Validable = false;
            this.txt_denominacion.Location = new System.Drawing.Point(37, 105);
            this.txt_denominacion.Name = "txt_denominacion";
            this.txt_denominacion.Size = new System.Drawing.Size(205, 28);
            this.txt_denominacion.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(94, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_BajaCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 217);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_denominacion);
            this.Controls.Add(this.txt_codigo_cargo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Frm_BajaCargo";
            this.Text = "Frm_BajaCargo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Clases.Label_Text txt_codigo_cargo;
        private Clases.Label_Text txt_denominacion;
        private System.Windows.Forms.Button button1;
    }
}