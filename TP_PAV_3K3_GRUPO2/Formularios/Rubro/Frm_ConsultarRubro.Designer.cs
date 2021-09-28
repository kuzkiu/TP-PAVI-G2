
namespace TP_PAV_3K3_GRUPO2.Formularios.Rubro
{
    partial class Frm_ConsultarRubro
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
            this.txt_idrubro = new System.Windows.Forms.TextBox();
            this.txt_nombrerubro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DGV_Rubro = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rubro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Rubro";
            // 
            // txt_idrubro
            // 
            this.txt_idrubro.Location = new System.Drawing.Point(42, 78);
            this.txt_idrubro.Name = "txt_idrubro";
            this.txt_idrubro.Size = new System.Drawing.Size(100, 20);
            this.txt_idrubro.TabIndex = 1;
            // 
            // txt_nombrerubro
            // 
            this.txt_nombrerubro.Location = new System.Drawing.Point(42, 117);
            this.txt_nombrerubro.Name = "txt_nombrerubro";
            this.txt_nombrerubro.Size = new System.Drawing.Size(100, 20);
            this.txt_nombrerubro.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "id Rubro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "nombre";
            // 
            // DGV_Rubro
            // 
            this.DGV_Rubro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Rubro.Location = new System.Drawing.Point(42, 168);
            this.DGV_Rubro.Name = "DGV_Rubro";
            this.DGV_Rubro.Size = new System.Drawing.Size(247, 149);
            this.DGV_Rubro.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(213, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_ConsultarRubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGV_Rubro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombrerubro);
            this.Controls.Add(this.txt_idrubro);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ConsultarRubro";
            this.Text = "Frm_ConsultarRubro";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rubro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idrubro;
        private System.Windows.Forms.TextBox txt_nombrerubro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGV_Rubro;
        private System.Windows.Forms.Button button1;
    }
}