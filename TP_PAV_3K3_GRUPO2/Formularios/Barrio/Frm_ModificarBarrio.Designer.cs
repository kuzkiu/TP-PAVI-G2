
namespace TP_PAV_3K3_GRUPO2.Formularios.Barrio
{
    partial class Frm_ModificarBarrio
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
            this.txt_nombreB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_idbarrio = new TP_PAV_3K3_GRUPO2.Clases.ComboBox01();
            this.cb_localidadB = new TP_PAV_3K3_GRUPO2.Clases.ComboBox01();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id barrio:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Localidad:";
            // 
            // txt_nombreB
            // 
            this.txt_nombreB.Location = new System.Drawing.Point(161, 100);
            this.txt_nombreB.Name = "txt_nombreB";
            this.txt_nombreB.Size = new System.Drawing.Size(121, 20);
            this.txt_nombreB.TabIndex = 4;
            this.txt_nombreB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_idbarrio
            // 
            this.cb_idbarrio._ComboSinSeleccion = false;
            this.cb_idbarrio._MensajeError = null;
            this.cb_idbarrio._Nombre_campo = null;
            this.cb_idbarrio._Nombre_tabla = null;
            this.cb_idbarrio._tabla_cargar_combo = null;
            this.cb_idbarrio._tabla_cargar_descriptor = null;
            this.cb_idbarrio._tabla_cargar_pk = null;
            this.cb_idbarrio._Validable = false;
            this.cb_idbarrio.FormattingEnabled = true;
            this.cb_idbarrio.Location = new System.Drawing.Point(161, 66);
            this.cb_idbarrio.Name = "cb_idbarrio";
            this.cb_idbarrio.Size = new System.Drawing.Size(121, 21);
            this.cb_idbarrio.TabIndex = 7;
            this.cb_idbarrio.SelectedIndexChanged += new System.EventHandler(this.cb_idbarrio_SelectedIndexChanged);
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
            this.cb_localidadB.Location = new System.Drawing.Point(161, 137);
            this.cb_localidadB.Name = "cb_localidadB";
            this.cb_localidadB.Size = new System.Drawing.Size(121, 21);
            this.cb_localidadB.TabIndex = 5;
            // 
            // Frm_ModificarBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.cb_idbarrio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_localidadB);
            this.Controls.Add(this.txt_nombreB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ModificarBarrio";
            this.Text = "Frm_ModificarBarrio";
            this.Load += new System.EventHandler(this.Frm_ModificarBarrio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombreB;
        private Clases.ComboBox01 cb_localidadB;
        private System.Windows.Forms.Button button1;
        private Clases.ComboBox01 cb_idbarrio;
    }
}