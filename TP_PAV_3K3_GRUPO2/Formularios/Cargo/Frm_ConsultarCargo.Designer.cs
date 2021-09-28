
namespace TP_PAV_3K3_GRUPO2.Formularios.Cargo
{
    partial class Frm_ConsultarCargo
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
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_denominacion = new System.Windows.Forms.TextBox();
            this.DGV_cargo = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_cargo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Cargo";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(40, 90);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo Cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "denominacion";
            // 
            // txt_denominacion
            // 
            this.txt_denominacion.Location = new System.Drawing.Point(40, 126);
            this.txt_denominacion.Name = "txt_denominacion";
            this.txt_denominacion.Size = new System.Drawing.Size(100, 20);
            this.txt_denominacion.TabIndex = 4;
            // 
            // DGV_cargo
            // 
            this.DGV_cargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_cargo.Location = new System.Drawing.Point(40, 170);
            this.DGV_cargo.Name = "DGV_cargo";
            this.DGV_cargo.Size = new System.Drawing.Size(256, 148);
            this.DGV_cargo.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(220, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_ConsultarCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 426);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGV_cargo);
            this.Controls.Add(this.txt_denominacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ConsultarCargo";
            this.Text = "Frm_ConsultarCargo";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_cargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_denominacion;
        private System.Windows.Forms.DataGridView DGV_cargo;
        private System.Windows.Forms.Button button1;
    }
}