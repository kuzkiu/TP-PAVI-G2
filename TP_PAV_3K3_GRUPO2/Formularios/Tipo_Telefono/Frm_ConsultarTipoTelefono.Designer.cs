
namespace TP_PAV_3K3_GRUPO2.Formularios.Tipo_Telefono
{
    partial class Frm_ConsultarTipoTelefono
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
            this.txt_id_tipo_telefono = new System.Windows.Forms.TextBox();
            this.txt_nombre_tipo_tel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DGV_TipoTel_consulta = new System.Windows.Forms.DataGridView();
            this.btn_consultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TipoTel_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Tipo Telefono";
            // 
            // txt_id_tipo_telefono
            // 
            this.txt_id_tipo_telefono.Location = new System.Drawing.Point(35, 98);
            this.txt_id_tipo_telefono.Name = "txt_id_tipo_telefono";
            this.txt_id_tipo_telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_id_tipo_telefono.TabIndex = 1;
            // 
            // txt_nombre_tipo_tel
            // 
            this.txt_nombre_tipo_tel.Location = new System.Drawing.Point(35, 137);
            this.txt_nombre_tipo_tel.Name = "txt_nombre_tipo_tel";
            this.txt_nombre_tipo_tel.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_tipo_tel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "id Tipo Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "nombre";
            // 
            // DGV_TipoTel_consulta
            // 
            this.DGV_TipoTel_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TipoTel_consulta.Location = new System.Drawing.Point(35, 187);
            this.DGV_TipoTel_consulta.Name = "DGV_TipoTel_consulta";
            this.DGV_TipoTel_consulta.Size = new System.Drawing.Size(269, 168);
            this.DGV_TipoTel_consulta.TabIndex = 5;
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Location = new System.Drawing.Point(201, 392);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(81, 41);
            this.btn_consultar.TabIndex = 6;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // Frm_ConsultarTipoTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 467);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.DGV_TipoTel_consulta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre_tipo_tel);
            this.Controls.Add(this.txt_id_tipo_telefono);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ConsultarTipoTelefono";
            this.Text = "Frm_ConsultarTipoTelefono";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TipoTel_consulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id_tipo_telefono;
        private System.Windows.Forms.TextBox txt_nombre_tipo_tel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGV_TipoTel_consulta;
        private System.Windows.Forms.Button btn_consultar;
    }
}