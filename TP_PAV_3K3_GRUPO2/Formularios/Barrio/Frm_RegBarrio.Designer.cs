
namespace TP_PAV_3K3_GRUPO2.Formularios.Barrio
{
    partial class Frm_RegBarrio
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
            this.txt_idbarrio = new System.Windows.Forms.TextBox();
            this.txt_nombrebarrio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_localidadB = new TP_PAV_3K3_GRUPO2.Clases.ComboBox01();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id barrio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Localidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // txt_idbarrio
            // 
            this.txt_idbarrio.Location = new System.Drawing.Point(137, 68);
            this.txt_idbarrio.Name = "txt_idbarrio";
            this.txt_idbarrio.Size = new System.Drawing.Size(121, 20);
            this.txt_idbarrio.TabIndex = 4;
            this.txt_idbarrio.TextChanged += new System.EventHandler(this.txt_idbarrio_TextChanged);
            this.txt_idbarrio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idbarrio_KeyPress);
            // 
            // txt_nombrebarrio
            // 
            this.txt_nombrebarrio.Location = new System.Drawing.Point(137, 99);
            this.txt_nombrebarrio.Name = "txt_nombrebarrio";
            this.txt_nombrebarrio.Size = new System.Drawing.Size(121, 20);
            this.txt_nombrebarrio.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_localidadB
            // 
            this.cb_localidadB._ComboSinSeleccion = false;
            this.cb_localidadB._MensajeError = null;
            this.cb_localidadB._Nombre_campo = null;
            this.cb_localidadB._Nombre_tabla = null;
            this.cb_localidadB._tabla_cargar_combo = null;
            this.cb_localidadB._tabla_cargar_descriptor = null;
            this.cb_localidadB._tabla_cargar_pk = null;
            this.cb_localidadB._Validable = false;
            this.cb_localidadB.FormattingEnabled = true;
            this.cb_localidadB.Location = new System.Drawing.Point(137, 37);
            this.cb_localidadB.Name = "cb_localidadB";
            this.cb_localidadB.Size = new System.Drawing.Size(121, 21);
            this.cb_localidadB.TabIndex = 1;
            // 
            // Frm_RegBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 456);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_nombrebarrio);
            this.Controls.Add(this.txt_idbarrio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_localidadB);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_RegBarrio";
            this.Text = "Frm_RegBarrio";
            this.Load += new System.EventHandler(this.Frm_RegBarrio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Clases.ComboBox01 cb_localidadB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_idbarrio;
        private System.Windows.Forms.TextBox txt_nombrebarrio;
        private System.Windows.Forms.Button button1;
    }
}