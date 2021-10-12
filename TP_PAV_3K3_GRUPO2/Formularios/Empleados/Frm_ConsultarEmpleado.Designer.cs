
namespace TP_PAV_3K3_GRUPO2.Formularios.Empleados
{
    partial class Frm_ConsultarEmpleado
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
            this.txt_DocumentoE = new System.Windows.Forms.TextBox();
            this.cb_tipoDocE = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Data_Empleados = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_DocumentoE
            // 
            this.txt_DocumentoE.Location = new System.Drawing.Point(106, 52);
            this.txt_DocumentoE.Name = "txt_DocumentoE";
            this.txt_DocumentoE.Size = new System.Drawing.Size(121, 20);
            this.txt_DocumentoE.TabIndex = 0;
            // 
            // cb_tipoDocE
            // 
            this.cb_tipoDocE.FormattingEnabled = true;
            this.cb_tipoDocE.Location = new System.Drawing.Point(106, 25);
            this.cb_tipoDocE.Name = "cb_tipoDocE";
            this.cb_tipoDocE.Size = new System.Drawing.Size(121, 21);
            this.cb_tipoDocE.TabIndex = 1;
            this.cb_tipoDocE.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de documento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Documento:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Data_Empleados
            // 
            this.Data_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Empleados.Location = new System.Drawing.Point(43, 161);
            this.Data_Empleados.Name = "Data_Empleados";
            this.Data_Empleados.Size = new System.Drawing.Size(240, 150);
            this.Data_Empleados.TabIndex = 5;
            this.Data_Empleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Frm_ConsultarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this.Data_Empleados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_tipoDocE);
            this.Controls.Add(this.txt_DocumentoE);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ConsultarEmpleado";
            this.Text = "Frm_ConsultarEmpleado";
            this.Load += new System.EventHandler(this.Frm_ConsultarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_DocumentoE;
        private System.Windows.Forms.ComboBox cb_tipoDocE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Data_Empleados;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}