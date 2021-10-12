
namespace TP_PAV_3K3_GRUPO2.Formularios.Sucursal
{
    partial class Frm_AdministrarSucursal
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.btn_Consulta = new System.Windows.Forms.Button();
            this.dgv_sucursales = new System.Windows.Forms.DataGridView();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Sucursal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion: ";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(158, 29);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(172, 26);
            this.txt_id.TabIndex = 2;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(158, 74);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(172, 26);
            this.txt_descripcion.TabIndex = 3;
            // 
            // btn_Consulta
            // 
            this.btn_Consulta.Location = new System.Drawing.Point(343, 72);
            this.btn_Consulta.Name = "btn_Consulta";
            this.btn_Consulta.Size = new System.Drawing.Size(86, 31);
            this.btn_Consulta.TabIndex = 4;
            this.btn_Consulta.Text = "Consultar";
            this.btn_Consulta.UseVisualStyleBackColor = true;
            this.btn_Consulta.Click += new System.EventHandler(this.btn_Consulta_Click);
            // 
            // dgv_sucursales
            // 
            this.dgv_sucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sucursales.Location = new System.Drawing.Point(32, 122);
            this.dgv_sucursales.Name = "dgv_sucursales";
            this.dgv_sucursales.RowHeadersWidth = 62;
            this.dgv_sucursales.RowTemplate.Height = 28;
            this.dgv_sucursales.Size = new System.Drawing.Size(397, 188);
            this.dgv_sucursales.TabIndex = 5;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(32, 337);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(91, 49);
            this.btn_Registrar.TabIndex = 6;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(184, 337);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(96, 49);
            this.btn_Modificar.TabIndex = 7;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(343, 337);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(86, 49);
            this.btn_Eliminar.TabIndex = 8;
            this.btn_Eliminar.Text = " Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // Frm_AdministrarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 398);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.dgv_sucursales);
            this.Controls.Add(this.btn_Consulta);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_AdministrarSucursal";
            this.Text = "Administrar Sucursal";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sucursales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Button btn_Consulta;
        private System.Windows.Forms.DataGridView dgv_sucursales;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
    }
}