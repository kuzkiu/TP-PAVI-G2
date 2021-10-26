
namespace TP_PAV_3K3_GRUPO2.Formularios.Estadisticas.Ventas
{
    partial class Frm_EstVentas
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mes01 = new System.Windows.Forms.TextBox();
            this.txt_anio01 = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.rv01 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mes02 = new System.Windows.Forms.TextBox();
            this.txt_anio02 = new System.Windows.Forms.TextBox();
            this.btn_buscar2 = new System.Windows.Forms.Button();
            this.rv02 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 42);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(874, 566);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rv01);
            this.tabPage1.Controls.Add(this.btn_buscar);
            this.tabPage1.Controls.Add(this.txt_anio01);
            this.tabPage1.Controls.Add(this.txt_mes01);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(866, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ventas por Sucursal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rv02);
            this.tabPage2.Controls.Add(this.btn_buscar2);
            this.tabPage2.Controls.Add(this.txt_anio02);
            this.tabPage2.Controls.Add(this.txt_mes02);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(866, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ventas por Empleado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gráficos estadísticos de Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Año";
            // 
            // txt_mes01
            // 
            this.txt_mes01.Location = new System.Drawing.Point(127, 10);
            this.txt_mes01.MaxLength = 2;
            this.txt_mes01.Name = "txt_mes01";
            this.txt_mes01.Size = new System.Drawing.Size(81, 22);
            this.txt_mes01.TabIndex = 2;
            this.txt_mes01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_mes01.TextChanged += new System.EventHandler(this.txt_mes01_TextChanged);
            this.txt_mes01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mes01_KeyPress);
            // 
            // txt_anio01
            // 
            this.txt_anio01.Location = new System.Drawing.Point(127, 42);
            this.txt_anio01.MaxLength = 4;
            this.txt_anio01.Name = "txt_anio01";
            this.txt_anio01.Size = new System.Drawing.Size(81, 22);
            this.txt_anio01.TabIndex = 3;
            this.txt_anio01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_anio01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mes02_KeyPress);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(251, 30);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(178, 34);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // rv01
            // 
            this.rv01.Location = new System.Drawing.Point(7, 78);
            this.rv01.Name = "rv01";
            this.rv01.ServerReport.BearerToken = null;
            this.rv01.Size = new System.Drawing.Size(848, 452);
            this.rv01.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Año";
            // 
            // txt_mes02
            // 
            this.txt_mes02.Location = new System.Drawing.Point(107, 23);
            this.txt_mes02.MaxLength = 2;
            this.txt_mes02.Name = "txt_mes02";
            this.txt_mes02.Size = new System.Drawing.Size(85, 22);
            this.txt_mes02.TabIndex = 2;
            this.txt_mes02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_mes02.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mes02_KeyPress_1);
            // 
            // txt_anio02
            // 
            this.txt_anio02.Location = new System.Drawing.Point(107, 53);
            this.txt_anio02.MaxLength = 4;
            this.txt_anio02.Name = "txt_anio02";
            this.txt_anio02.Size = new System.Drawing.Size(85, 22);
            this.txt_anio02.TabIndex = 3;
            this.txt_anio02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_anio02.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_anio02_KeyPress);
            // 
            // btn_buscar2
            // 
            this.btn_buscar2.Location = new System.Drawing.Point(244, 41);
            this.btn_buscar2.Name = "btn_buscar2";
            this.btn_buscar2.Size = new System.Drawing.Size(150, 34);
            this.btn_buscar2.TabIndex = 4;
            this.btn_buscar2.Text = "Buscar";
            this.btn_buscar2.UseVisualStyleBackColor = true;
            this.btn_buscar2.Click += new System.EventHandler(this.btn_buscar2_Click);
            // 
            // rv02
            // 
            this.rv02.Location = new System.Drawing.Point(7, 81);
            this.rv02.Name = "rv02";
            this.rv02.ServerReport.BearerToken = null;
            this.rv02.Size = new System.Drawing.Size(852, 444);
            this.rv02.TabIndex = 5;
            // 
            // Frm_EstVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 621);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_EstVentas";
            this.Text = "Estadísticas de ventas";
            this.Load += new System.EventHandler(this.Frm_EstVentas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_anio01;
        private System.Windows.Forms.TextBox txt_mes01;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer rv01;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Microsoft.Reporting.WinForms.ReportViewer rv02;
        private System.Windows.Forms.Button btn_buscar2;
        private System.Windows.Forms.TextBox txt_anio02;
        private System.Windows.Forms.TextBox txt_mes02;
    }
}