
namespace TP_PAV_3K3_GRUPO2.Formularios.Barrio
{
    partial class Frm_ConsultarBarrio
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
            this.button1 = new System.Windows.Forms.Button();
            this.Data_Barrio = new System.Windows.Forms.DataGridView();
            this.txt_idbarrio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombreBarrio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Barrio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id barrio:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Data_Barrio
            // 
            this.Data_Barrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Barrio.Location = new System.Drawing.Point(60, 135);
            this.Data_Barrio.Name = "Data_Barrio";
            this.Data_Barrio.Size = new System.Drawing.Size(240, 150);
            this.Data_Barrio.TabIndex = 2;
            this.Data_Barrio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_idbarrio
            // 
            this.txt_idbarrio.Location = new System.Drawing.Point(111, 39);
            this.txt_idbarrio.Name = "txt_idbarrio";
            this.txt_idbarrio.Size = new System.Drawing.Size(146, 20);
            this.txt_idbarrio.TabIndex = 3;
            this.txt_idbarrio.TextChanged += new System.EventHandler(this.txt_idbarrio_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // txt_nombreBarrio
            // 
            this.txt_nombreBarrio.Location = new System.Drawing.Point(111, 73);
            this.txt_nombreBarrio.Name = "txt_nombreBarrio";
            this.txt_nombreBarrio.Size = new System.Drawing.Size(146, 20);
            this.txt_nombreBarrio.TabIndex = 5;
            this.txt_nombreBarrio.TextChanged += new System.EventHandler(this.txt_nombreBarrio_TextChanged);
            // 
            // Frm_ConsultarBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.txt_nombreBarrio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_idbarrio);
            this.Controls.Add(this.Data_Barrio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ConsultarBarrio";
            this.Text = "Frm_ConsultarBarrio";
            this.Load += new System.EventHandler(this.Frm_ConsultarBarrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Barrio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Data_Barrio;
        private System.Windows.Forms.TextBox txt_idbarrio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombreBarrio;
    }
}