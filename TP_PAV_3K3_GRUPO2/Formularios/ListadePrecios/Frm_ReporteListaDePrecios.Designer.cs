
namespace TP_PAV_3K3_GRUPO2.Formularios.ListadePrecios
{
    partial class Frm_ReporteListaDePrecios
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Reporte = new System.Windows.Forms.Button();
            this.txt_razon = new System.Windows.Forms.TextBox();
            this.cmb_cuil = new System.Windows.Forms.ComboBox();
            this.rpv_listasCliente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.txt_RazonSocial = new System.Windows.Forms.TextBox();
            this.cmb_cuils = new System.Windows.Forms.ComboBox();
            this.rpv_listaactual = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1117, 614);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_Reporte);
            this.tabPage1.Controls.Add(this.txt_razon);
            this.tabPage1.Controls.Add(this.cmb_cuil);
            this.tabPage1.Controls.Add(this.rpv_listasCliente);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1109, 581);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listas de un Cliente";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Razon Social:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cuil:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(129, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // btn_Reporte
            // 
            this.btn_Reporte.Enabled = false;
            this.btn_Reporte.Location = new System.Drawing.Point(665, 57);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(84, 39);
            this.btn_Reporte.TabIndex = 5;
            this.btn_Reporte.Text = "Reporte";
            this.btn_Reporte.UseVisualStyleBackColor = true;
            this.btn_Reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // txt_razon
            // 
            this.txt_razon.Enabled = false;
            this.txt_razon.Location = new System.Drawing.Point(336, 63);
            this.txt_razon.Name = "txt_razon";
            this.txt_razon.Size = new System.Drawing.Size(159, 26);
            this.txt_razon.TabIndex = 4;
            // 
            // cmb_cuil
            // 
            this.cmb_cuil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cuil.FormattingEnabled = true;
            this.cmb_cuil.Location = new System.Drawing.Point(336, 23);
            this.cmb_cuil.Name = "cmb_cuil";
            this.cmb_cuil.Size = new System.Drawing.Size(159, 28);
            this.cmb_cuil.TabIndex = 2;
            this.cmb_cuil.SelectedValueChanged += new System.EventHandler(this.cmb_cuil_SelectedValueChanged);
            // 
            // rpv_listasCliente
            // 
            this.rpv_listasCliente.Location = new System.Drawing.Point(16, 102);
            this.rpv_listasCliente.Name = "rpv_listasCliente";
            this.rpv_listasCliente.ServerReport.BearerToken = null;
            this.rpv_listasCliente.Size = new System.Drawing.Size(1071, 442);
            this.rpv_listasCliente.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btn_generar);
            this.tabPage2.Controls.Add(this.txt_RazonSocial);
            this.tabPage2.Controls.Add(this.cmb_cuils);
            this.tabPage2.Controls.Add(this.rpv_listaactual);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1109, 581);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista Activa de un cliente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Razon Social:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cuil:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 7;
            // 
            // btn_generar
            // 
            this.btn_generar.Enabled = false;
            this.btn_generar.Location = new System.Drawing.Point(668, 50);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(84, 39);
            this.btn_generar.TabIndex = 11;
            this.btn_generar.Text = "Reporte";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // txt_RazonSocial
            // 
            this.txt_RazonSocial.Enabled = false;
            this.txt_RazonSocial.Location = new System.Drawing.Point(339, 56);
            this.txt_RazonSocial.Name = "txt_RazonSocial";
            this.txt_RazonSocial.Size = new System.Drawing.Size(159, 26);
            this.txt_RazonSocial.TabIndex = 10;
            // 
            // cmb_cuils
            // 
            this.cmb_cuils.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cuils.FormattingEnabled = true;
            this.cmb_cuils.Location = new System.Drawing.Point(339, 16);
            this.cmb_cuils.Name = "cmb_cuils";
            this.cmb_cuils.Size = new System.Drawing.Size(159, 28);
            this.cmb_cuils.TabIndex = 8;
            this.cmb_cuils.SelectedValueChanged += new System.EventHandler(this.cmb_cuils_SelectedValueChanged);
            // 
            // rpv_listaactual
            // 
            this.rpv_listaactual.Location = new System.Drawing.Point(22, 98);
            this.rpv_listaactual.Name = "rpv_listaactual";
            this.rpv_listaactual.ServerReport.BearerToken = null;
            this.rpv_listaactual.Size = new System.Drawing.Size(1045, 436);
            this.rpv_listaactual.TabIndex = 6;
            // 
            // Frm_ReporteListaDePrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 665);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_ReporteListaDePrecios";
            this.Text = "Frm_ReporteListaDePrecios";
            this.Load += new System.EventHandler(this.Frm_ReporteListaDePrecios_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Reporte;
        private System.Windows.Forms.TextBox txt_razon;
        private System.Windows.Forms.ComboBox cmb_cuil;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_listasCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.TextBox txt_RazonSocial;
        private System.Windows.Forms.ComboBox cmb_cuils;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_listaactual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}