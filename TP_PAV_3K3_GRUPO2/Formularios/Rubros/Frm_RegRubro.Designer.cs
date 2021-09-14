
namespace TP_PAV_3K3_GRUPO2.Formularios.Articulos
{
    partial class Frm_RegRubro
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
            this.txt_idRubro = new System.Windows.Forms.TextBox();
            this.txt_nomRubro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id_Rubro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nombre:";
            // 
            // txt_idRubro
            // 
            this.txt_idRubro.Location = new System.Drawing.Point(65, 9);
            this.txt_idRubro.Name = "txt_idRubro";
            this.txt_idRubro.Size = new System.Drawing.Size(61, 20);
            this.txt_idRubro.TabIndex = 2;
            // 
            // txt_nomRubro
            // 
            this.txt_nomRubro.Location = new System.Drawing.Point(65, 40);
            this.txt_nomRubro.Name = "txt_nomRubro";
            this.txt_nomRubro.Size = new System.Drawing.Size(100, 20);
            this.txt_nomRubro.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_RegRubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 99);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_nomRubro);
            this.Controls.Add(this.txt_idRubro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_RegRubro";
            this.Text = "Frm_RegRubro";
            this.Load += new System.EventHandler(this.Frm_RegRubro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_idRubro;
        private System.Windows.Forms.TextBox txt_nomRubro;
        private System.Windows.Forms.Button button1;
    }
}