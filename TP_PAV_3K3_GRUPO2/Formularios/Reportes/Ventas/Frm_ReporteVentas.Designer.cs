
namespace TP_PAV_3K3_GRUPO2.Formularios.Reportes.Ventas
{
    partial class Frm_ReporteVentas
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
            this.txt_mes = new System.Windows.Forms.TextBox();
            this.txt_anio = new System.Windows.Forms.TextBox();
            this.btn_generar01 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rv01 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_sucursal = new TP_PAV_3K3_GRUPO2.Clases.ComboBox01();
            this.label5 = new System.Windows.Forms.Label();
            this.rv02 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmb_empleado = new TP_PAV_3K3_GRUPO2.Clases.ComboBox01();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mes2 = new System.Windows.Forms.TextBox();
            this.txt_anio2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(17, 37);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 598);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cmb_sucursal);
            this.tabPage1.Controls.Add(this.rv01);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_generar01);
            this.tabPage1.Controls.Add(this.txt_anio);
            this.tabPage1.Controls.Add(this.txt_mes);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(756, 569);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reporte de ventas mensuales por Sucursal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txt_anio2);
            this.tabPage2.Controls.Add(this.txt_mes2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cmb_empleado);
            this.tabPage2.Controls.Add(this.rv02);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(756, 569);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reporte de ventas mensuales por Empleado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas";
            // 
            // txt_mes
            // 
            this.txt_mes.Location = new System.Drawing.Point(433, 29);
            this.txt_mes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_mes.MaxLength = 2;
            this.txt_mes.Name = "txt_mes";
            this.txt_mes.Size = new System.Drawing.Size(124, 22);
            this.txt_mes.TabIndex = 0;
            this.txt_mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_mes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_mes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txt_anio
            // 
            this.txt_anio.Location = new System.Drawing.Point(433, 64);
            this.txt_anio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_anio.MaxLength = 4;
            this.txt_anio.Name = "txt_anio";
            this.txt_anio.Size = new System.Drawing.Size(124, 22);
            this.txt_anio.TabIndex = 1;
            this.txt_anio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_anio.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txt_anio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // btn_generar01
            // 
            this.btn_generar01.Location = new System.Drawing.Point(588, 58);
            this.btn_generar01.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_generar01.Name = "btn_generar01";
            this.btn_generar01.Size = new System.Drawing.Size(144, 28);
            this.btn_generar01.TabIndex = 2;
            this.btn_generar01.Text = "Generar Reporte";
            this.btn_generar01.UseVisualStyleBackColor = true;
            this.btn_generar01.Click += new System.EventHandler(this.btn_generar01_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Año";
            // 
            // rv01
            // 
            this.rv01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rv01.Location = new System.Drawing.Point(15, 106);
            this.rv01.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rv01.Name = "rv01";
            this.rv01.ServerReport.BearerToken = null;
            this.rv01.Size = new System.Drawing.Size(725, 452);
            this.rv01.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sucursal";
            // 
            // cmb_sucursal
            // 
            this.cmb_sucursal._ComboSinSeleccion = false;
            this.cmb_sucursal._MensajeError = null;
            this.cmb_sucursal._Nombre_campo = null;
            this.cmb_sucursal._Nombre_tabla = null;
            this.cmb_sucursal._tabla_cargar_combo = "Sucursal";
            this.cmb_sucursal._tabla_cargar_descriptor = "descripcion";
            this.cmb_sucursal._tabla_cargar_pk = "id_sucursal";
            this.cmb_sucursal._Validable = false;
            this.cmb_sucursal.FormattingEnabled = true;
            this.cmb_sucursal.Location = new System.Drawing.Point(89, 62);
            this.cmb_sucursal.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_sucursal.Name = "cmb_sucursal";
            this.cmb_sucursal.Size = new System.Drawing.Size(246, 24);
            this.cmb_sucursal.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Empleado";
            // 
            // rv02
            // 
            this.rv02.Location = new System.Drawing.Point(11, 94);
            this.rv02.Name = "rv02";
            this.rv02.ServerReport.BearerToken = null;
            this.rv02.Size = new System.Drawing.Size(742, 468);
            this.rv02.TabIndex = 1;
            // 
            // cmb_empleado
            // 
            this.cmb_empleado._ComboSinSeleccion = false;
            this.cmb_empleado._MensajeError = null;
            this.cmb_empleado._Nombre_campo = null;
            this.cmb_empleado._Nombre_tabla = null;
            this.cmb_empleado._tabla_cargar_combo = "Empleado";
            this.cmb_empleado._tabla_cargar_descriptor = "nombre";
            this.cmb_empleado._tabla_cargar_pk = "nro_doc_emp";
            this.cmb_empleado._Validable = false;
            this.cmb_empleado.FormattingEnabled = true;
            this.cmb_empleado.Location = new System.Drawing.Point(118, 51);
            this.cmb_empleado.Name = "cmb_empleado";
            this.cmb_empleado.Size = new System.Drawing.Size(184, 24);
            this.cmb_empleado.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(420, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Año";
            // 
            // txt_mes2
            // 
            this.txt_mes2.Location = new System.Drawing.Point(471, 25);
            this.txt_mes2.MaxLength = 2;
            this.txt_mes2.Name = "txt_mes2";
            this.txt_mes2.Size = new System.Drawing.Size(82, 22);
            this.txt_mes2.TabIndex = 5;
            this.txt_mes2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mes2_KeyPress);
            // 
            // txt_anio2
            // 
            this.txt_anio2.Location = new System.Drawing.Point(471, 53);
            this.txt_anio2.MaxLength = 4;
            this.txt_anio2.Name = "txt_anio2";
            this.txt_anio2.Size = new System.Drawing.Size(82, 22);
            this.txt_anio2.TabIndex = 6;
            this.txt_anio2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_anio2_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Generar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_ReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 637);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_ReporteVentas";
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.Frm_ReporteVentas_Load_1);
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
        private Microsoft.Reporting.WinForms.ReportViewer rv01;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_generar01;
        private System.Windows.Forms.TextBox txt_anio;
        private System.Windows.Forms.TextBox txt_mes;
        private Clases.ComboBox01 cmb_sucursal;
        private System.Windows.Forms.Label label4;
        private Microsoft.Reporting.WinForms.ReportViewer rv02;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_anio2;
        private System.Windows.Forms.TextBox txt_mes2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Clases.ComboBox01 cmb_empleado;
        private System.Windows.Forms.Button button1;
    }
}