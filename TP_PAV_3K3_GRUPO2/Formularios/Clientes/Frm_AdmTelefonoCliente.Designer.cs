
namespace TP_PAV_3K3_GRUPO2.Formularios.Clientes
{
    partial class Frm_AdmTelefonoCliente
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
            this.btn_agregartelefono = new System.Windows.Forms.Button();
            this.btn_modificartelefono = new System.Windows.Forms.Button();
            this.btn_eliminartelefono = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cuil = new System.Windows.Forms.TextBox();
            this.dgv_telefonocliente = new System.Windows.Forms.DataGridView();
            this.btn_actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_telefonocliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregartelefono
            // 
            this.btn_agregartelefono.Location = new System.Drawing.Point(24, 295);
            this.btn_agregartelefono.Name = "btn_agregartelefono";
            this.btn_agregartelefono.Size = new System.Drawing.Size(102, 61);
            this.btn_agregartelefono.TabIndex = 0;
            this.btn_agregartelefono.Text = "Registrar Telefono";
            this.btn_agregartelefono.UseVisualStyleBackColor = true;
            this.btn_agregartelefono.Click += new System.EventHandler(this.btn_agregartelefono_Click);
            // 
            // btn_modificartelefono
            // 
            this.btn_modificartelefono.Location = new System.Drawing.Point(178, 295);
            this.btn_modificartelefono.Name = "btn_modificartelefono";
            this.btn_modificartelefono.Size = new System.Drawing.Size(100, 61);
            this.btn_modificartelefono.TabIndex = 1;
            this.btn_modificartelefono.Text = "Modificar Telefono";
            this.btn_modificartelefono.UseVisualStyleBackColor = true;
            this.btn_modificartelefono.Click += new System.EventHandler(this.btn_modificartelefono_Click);
            // 
            // btn_eliminartelefono
            // 
            this.btn_eliminartelefono.Location = new System.Drawing.Point(329, 295);
            this.btn_eliminartelefono.Name = "btn_eliminartelefono";
            this.btn_eliminartelefono.Size = new System.Drawing.Size(93, 61);
            this.btn_eliminartelefono.TabIndex = 2;
            this.btn_eliminartelefono.Text = "Eliminar Telefono";
            this.btn_eliminartelefono.UseVisualStyleBackColor = true;
            this.btn_eliminartelefono.Click += new System.EventHandler(this.btn_eliminartelefono_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cuil Cliente:";
            // 
            // txt_cuil
            // 
            this.txt_cuil.Enabled = false;
            this.txt_cuil.Location = new System.Drawing.Point(118, 26);
            this.txt_cuil.Name = "txt_cuil";
            this.txt_cuil.Size = new System.Drawing.Size(142, 26);
            this.txt_cuil.TabIndex = 4;
            // 
            // dgv_telefonocliente
            // 
            this.dgv_telefonocliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_telefonocliente.Location = new System.Drawing.Point(24, 78);
            this.dgv_telefonocliente.Name = "dgv_telefonocliente";
            this.dgv_telefonocliente.RowHeadersWidth = 62;
            this.dgv_telefonocliente.RowTemplate.Height = 28;
            this.dgv_telefonocliente.Size = new System.Drawing.Size(398, 194);
            this.dgv_telefonocliente.TabIndex = 5;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(298, 17);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(124, 44);
            this.btn_actualizar.TabIndex = 6;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // Frm_AdmTelefonoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 368);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.dgv_telefonocliente);
            this.Controls.Add(this.txt_cuil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_eliminartelefono);
            this.Controls.Add(this.btn_modificartelefono);
            this.Controls.Add(this.btn_agregartelefono);
            this.Name = "Frm_AdmTelefonoCliente";
            this.Text = "Frm_AdmTelefonoCliente";
            this.Load += new System.EventHandler(this.Frm_AdmTelefonoCliente_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_telefonocliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregartelefono;
        private System.Windows.Forms.Button btn_modificartelefono;
        private System.Windows.Forms.Button btn_eliminartelefono;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_cuil;
        public System.Windows.Forms.DataGridView dgv_telefonocliente;
        private System.Windows.Forms.Button btn_actualizar;
    }
}