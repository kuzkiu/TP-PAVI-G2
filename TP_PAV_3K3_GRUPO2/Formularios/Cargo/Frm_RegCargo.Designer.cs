
namespace TP_PAV_3K3_GRUPO2.Formularios.Cargo
{
    partial class Frm_RegCargo
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
            this.label_titulo = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.txt_denominacion = new TP_PAV_3K3_GRUPO2.Clases.Label_Text();
            this.txt_codigo_cargo = new TP_PAV_3K3_GRUPO2.Clases.Label_Text();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(20, 31);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(148, 25);
            this.label_titulo.TabIndex = 2;
            this.label_titulo.Text = "Registrar Cargo";
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.Location = new System.Drawing.Point(93, 156);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(75, 36);
            this.btn_registrar.TabIndex = 3;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // txt_denominacion
            // 
            this.txt_denominacion._Ancho = 10;
            this.txt_denominacion._Decimales = 0;
            this.txt_denominacion._Etiqueta = "Denominacion";
            this.txt_denominacion._MensajeError = "falta completar la denominacion";
            this.txt_denominacion._Nobre_tabla = null;
            this.txt_denominacion._Nombre_campo = "denominacion";
            this.txt_denominacion._ReadOnly = false;
            this.txt_denominacion._Text = "";
            this.txt_denominacion._TipoDato = TP_PAV_3K3_GRUPO2.Clases.Label_Text.TipoDato.texto;
            this.txt_denominacion._Validable = false;
            this.txt_denominacion.Location = new System.Drawing.Point(25, 112);
            this.txt_denominacion.Name = "txt_denominacion";
            this.txt_denominacion.Size = new System.Drawing.Size(211, 28);
            this.txt_denominacion.TabIndex = 1;
            this.txt_denominacion.Load += new System.EventHandler(this.label_Text2_Load);
            // 
            // txt_codigo_cargo
            // 
            this.txt_codigo_cargo._Ancho = 3;
            this.txt_codigo_cargo._Decimales = 0;
            this.txt_codigo_cargo._Etiqueta = "Codigo De Cargo";
            this.txt_codigo_cargo._MensajeError = "falta completar codigo de fcargo";
            this.txt_codigo_cargo._Nobre_tabla = null;
            this.txt_codigo_cargo._Nombre_campo = "Cod_cargo";
            this.txt_codigo_cargo._ReadOnly = false;
            this.txt_codigo_cargo._Text = "";
            this.txt_codigo_cargo._TipoDato = TP_PAV_3K3_GRUPO2.Clases.Label_Text.TipoDato.numero;
            this.txt_codigo_cargo._Validable = false;
            this.txt_codigo_cargo.Location = new System.Drawing.Point(25, 77);
            this.txt_codigo_cargo.Name = "txt_codigo_cargo";
            this.txt_codigo_cargo.Size = new System.Drawing.Size(227, 28);
            this.txt_codigo_cargo.TabIndex = 0;
            // 
            // Frm_RegCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 234);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.txt_denominacion);
            this.Controls.Add(this.txt_codigo_cargo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_RegCargo";
            this.Text = "Frm_RegCargo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.Label_Text txt_codigo_cargo;
        private Clases.Label_Text txt_denominacion;
        public System.Windows.Forms.Button btn_registrar;
        public System.Windows.Forms.Label label_titulo;
    }
}