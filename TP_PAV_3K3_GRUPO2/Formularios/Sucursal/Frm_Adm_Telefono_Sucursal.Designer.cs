
namespace TP_PAV_3K3_GRUPO2.Formularios.Sucursal
{
    partial class Frm_Adm_Telefono_Sucursal
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
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.dgv_telefonos = new System.Windows.Forms.DataGridView();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_telefonos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(183, 275);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(94, 55);
            this.btn_Modificar.TabIndex = 0;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Sucursal:";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(128, 20);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(137, 26);
            this.txt_id.TabIndex = 2;
            // 
            // dgv_telefonos
            // 
            this.dgv_telefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_telefonos.Location = new System.Drawing.Point(30, 71);
            this.dgv_telefonos.Name = "dgv_telefonos";
            this.dgv_telefonos.RowHeadersWidth = 62;
            this.dgv_telefonos.RowTemplate.Height = 28;
            this.dgv_telefonos.Size = new System.Drawing.Size(388, 177);
            this.dgv_telefonos.TabIndex = 3;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(304, 16);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(114, 42);
            this.btn_actualizar.TabIndex = 4;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(30, 275);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(92, 55);
            this.btn_Registrar.TabIndex = 5;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(332, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 55);
            this.button4.TabIndex = 6;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Frm_Adm_Telefono_Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 351);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.dgv_telefonos);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Modificar);
            this.Name = "Frm_Adm_Telefono_Sucursal";
            this.Text = "Telefonos de la Sucursal";
            this.Load += new System.EventHandler(this.Frm_Adm_Telefono_Sucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_telefonos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_telefonos;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.TextBox txt_id;
    }
}