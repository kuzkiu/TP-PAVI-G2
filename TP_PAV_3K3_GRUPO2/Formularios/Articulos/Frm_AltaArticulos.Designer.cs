
namespace TP_PAV_3K3_GRUPO2
{
    partial class Frm_AltaArticulos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_venta = new System.Windows.Forms.TextBox();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.cmb_marca = new TP_PAV_3K3_GRUPO2.Clases.ComboBox01();
            this.cmb_rubro = new TP_PAV_3K3_GRUPO2.Clases.ComboBox01();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio venta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio costo:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(120, 34);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(274, 24);
            this.txt_descripcion.TabIndex = 0;
            this.txt_descripcion.TextChanged += new System.EventHandler(this.txt_descripcion_TextChanged);
            this.txt_descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descripcion_KeyPress);
            // 
            // txt_venta
            // 
            this.txt_venta.Location = new System.Drawing.Point(188, 182);
            this.txt_venta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_venta.Name = "txt_venta";
            this.txt_venta.Size = new System.Drawing.Size(206, 24);
            this.txt_venta.TabIndex = 4;
            this.txt_venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_venta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_venta_KeyPress);
            // 
            // txt_costo
            // 
            this.txt_costo.Location = new System.Drawing.Point(188, 146);
            this.txt_costo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(206, 24);
            this.txt_costo.TabIndex = 3;
            this.txt_costo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costo_KeyPress);
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(188, 218);
            this.txt_stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(206, 24);
            this.txt_stock.TabIndex = 5;
            this.txt_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stock_KeyPress);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(188, 272);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(86, 35);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rubro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Marca:";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(308, 272);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(86, 35);
            this.btn_Limpiar.TabIndex = 7;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // cmb_marca
            // 
            this.cmb_marca._ComboSinSeleccion = false;
            this.cmb_marca._MensajeError = null;
            this.cmb_marca._Nombre_campo = null;
            this.cmb_marca._Nombre_tabla = null;
            this.cmb_marca._tabla_cargar_combo = "Marca";
            this.cmb_marca._tabla_cargar_descriptor = "nombre";
            this.cmb_marca._tabla_cargar_pk = "id_marca";
            this.cmb_marca._Validable = false;
            this.cmb_marca.FormattingEnabled = true;
            this.cmb_marca.Location = new System.Drawing.Point(190, 107);
            this.cmb_marca.Name = "cmb_marca";
            this.cmb_marca.Size = new System.Drawing.Size(203, 26);
            this.cmb_marca.TabIndex = 13;
            // 
            // cmb_rubro
            // 
            this.cmb_rubro._ComboSinSeleccion = false;
            this.cmb_rubro._MensajeError = null;
            this.cmb_rubro._Nombre_campo = null;
            this.cmb_rubro._Nombre_tabla = null;
            this.cmb_rubro._tabla_cargar_combo = "Rubro";
            this.cmb_rubro._tabla_cargar_descriptor = "nombre";
            this.cmb_rubro._tabla_cargar_pk = "id_rubro";
            this.cmb_rubro._Validable = false;
            this.cmb_rubro.FormattingEnabled = true;
            this.cmb_rubro.Location = new System.Drawing.Point(188, 71);
            this.cmb_rubro.Name = "cmb_rubro";
            this.cmb_rubro.Size = new System.Drawing.Size(206, 26);
            this.cmb_rubro.TabIndex = 12;
            // 
            // Frm_AltaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 344);
            this.Controls.Add(this.cmb_marca);
            this.Controls.Add(this.cmb_rubro);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.txt_costo);
            this.Controls.Add(this.txt_venta);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AltaArticulos";
            this.Text = " Registrar Artículo";
            this.Load += new System.EventHandler(this.Frm_AltaArticulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_venta;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Limpiar;
        private Clases.ComboBox01 cmb_rubro;
        private Clases.ComboBox01 cmb_marca;
    }
}