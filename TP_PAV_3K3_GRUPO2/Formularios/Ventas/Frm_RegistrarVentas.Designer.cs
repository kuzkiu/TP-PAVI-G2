
namespace TP_PAV_3K3_GRUPO2.Formularios.Ventas
{
    partial class Frm_RegistrarVentas
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
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Subtotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.cmb_fpagos = new TP_PAV_3K3_GRUPO2.Clases.ComboBox01();
            this.grid_Venta = new TP_PAV_3K3_GRUPO2.Clases.Grilla();
            this.cmb_empleados = new TP_PAV_3K3_GRUPO2.Clases.ComboBox01();
            this.cmb_sucursales = new TP_PAV_3K3_GRUPO2.Clases.ComboBox01();
            this.cmb_clientes = new TP_PAV_3K3_GRUPO2.Clases.ComboBox01();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.grid_Articulos = new TP_PAV_3K3_GRUPO2.Clases.Grilla();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_idarticulo = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Venta)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vendedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sucursal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "N° de Factura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 24);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(145, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 24);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Location = new System.Drawing.Point(16, 64);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(106, 18);
            this.Subtotal.TabIndex = 12;
            this.Subtotal.Text = "Precio Unitario";
            this.Subtotal.Click += new System.EventHandler(this.Subtotal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cantidad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_fpagos);
            this.groupBox1.Location = new System.Drawing.Point(543, 431);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 64);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma de pago";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Location = new System.Drawing.Point(543, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 49);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(128, 14);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(142, 29);
            this.textBox4.TabIndex = 0;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(544, 501);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(121, 45);
            this.btn_guardar.TabIndex = 20;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(699, 501);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(121, 45);
            this.btn_limpiar.TabIndex = 21;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // cmb_fpagos
            // 
            this.cmb_fpagos._ComboSinSeleccion = false;
            this.cmb_fpagos._MensajeError = null;
            this.cmb_fpagos._Nombre_campo = null;
            this.cmb_fpagos._Nombre_tabla = "";
            this.cmb_fpagos._tabla_cargar_combo = "Forma_De_Pago";
            this.cmb_fpagos._tabla_cargar_descriptor = "nombre";
            this.cmb_fpagos._tabla_cargar_pk = "id_formaDePago";
            this.cmb_fpagos._Validable = false;
            this.cmb_fpagos.FormattingEnabled = true;
            this.cmb_fpagos.Location = new System.Drawing.Point(52, 23);
            this.cmb_fpagos.Name = "cmb_fpagos";
            this.cmb_fpagos.Size = new System.Drawing.Size(218, 26);
            this.cmb_fpagos.TabIndex = 18;
            // 
            // grid_Venta
            // 
            this.grid_Venta._formatoLetraHeader = System.Drawing.FontStyle.Regular;
            this.grid_Venta._tamannoLetraHeader = 9;
            this.grid_Venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Venta.Location = new System.Drawing.Point(12, 239);
            this.grid_Venta.Name = "grid_Venta";
            this.grid_Venta.Size = new System.Drawing.Size(511, 307);
            this.grid_Venta.TabIndex = 11;
            // 
            // cmb_empleados
            // 
            this.cmb_empleados._ComboSinSeleccion = false;
            this.cmb_empleados._MensajeError = null;
            this.cmb_empleados._Nombre_campo = null;
            this.cmb_empleados._Nombre_tabla = null;
            this.cmb_empleados._tabla_cargar_combo = "Empleado";
            this.cmb_empleados._tabla_cargar_descriptor = "nombre";
            this.cmb_empleados._tabla_cargar_pk = "nro_doc_emp";
            this.cmb_empleados._Validable = false;
            this.cmb_empleados.FormattingEnabled = true;
            this.cmb_empleados.Location = new System.Drawing.Point(115, 178);
            this.cmb_empleados.Name = "cmb_empleados";
            this.cmb_empleados.Size = new System.Drawing.Size(157, 26);
            this.cmb_empleados.TabIndex = 9;
            // 
            // cmb_sucursales
            // 
            this.cmb_sucursales._ComboSinSeleccion = false;
            this.cmb_sucursales._MensajeError = null;
            this.cmb_sucursales._Nombre_campo = null;
            this.cmb_sucursales._Nombre_tabla = null;
            this.cmb_sucursales._tabla_cargar_combo = "Sucursal";
            this.cmb_sucursales._tabla_cargar_descriptor = "descripcion";
            this.cmb_sucursales._tabla_cargar_pk = "id_sucursal";
            this.cmb_sucursales._Validable = false;
            this.cmb_sucursales.FormattingEnabled = true;
            this.cmb_sucursales.Location = new System.Drawing.Point(114, 136);
            this.cmb_sucursales.Name = "cmb_sucursales";
            this.cmb_sucursales.Size = new System.Drawing.Size(157, 26);
            this.cmb_sucursales.TabIndex = 8;
            // 
            // cmb_clientes
            // 
            this.cmb_clientes._ComboSinSeleccion = false;
            this.cmb_clientes._MensajeError = null;
            this.cmb_clientes._Nombre_campo = null;
            this.cmb_clientes._Nombre_tabla = null;
            this.cmb_clientes._tabla_cargar_combo = "Clientes";
            this.cmb_clientes._tabla_cargar_descriptor = "razon_social";
            this.cmb_clientes._tabla_cargar_pk = "cuil_cliente";
            this.cmb_clientes._Validable = false;
            this.cmb_clientes.FormattingEnabled = true;
            this.cmb_clientes.Location = new System.Drawing.Point(115, 21);
            this.cmb_clientes.Name = "cmb_clientes";
            this.cmb_clientes.Size = new System.Drawing.Size(157, 26);
            this.cmb_clientes.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_descripcion);
            this.groupBox3.Controls.Add(this.txt_cantidad);
            this.groupBox3.Controls.Add(this.txt_precio);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.Subtotal);
            this.groupBox3.Location = new System.Drawing.Point(543, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 123);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Artículo seleccionado";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(128, 93);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(142, 24);
            this.txt_cantidad.TabIndex = 17;
            this.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_cantidad.TextChanged += new System.EventHandler(this.txt_cantidad_TextChanged);
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            // 
            // txt_precio
            // 
            this.txt_precio.Enabled = false;
            this.txt_precio.Location = new System.Drawing.Point(128, 58);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(142, 24);
            this.txt_precio.TabIndex = 16;
            this.txt_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grid_Articulos
            // 
            this.grid_Articulos._formatoLetraHeader = System.Drawing.FontStyle.Regular;
            this.grid_Articulos._tamannoLetraHeader = 9;
            this.grid_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Articulos.Location = new System.Drawing.Point(315, 21);
            this.grid_Articulos.Name = "grid_Articulos";
            this.grid_Articulos.Size = new System.Drawing.Size(498, 208);
            this.grid_Articulos.TabIndex = 23;
            this.grid_Articulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Articulos_CellContentClick);
            this.grid_Articulos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Articulos_CellContentDoubleClick);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Enabled = false;
            this.txt_descripcion.Location = new System.Drawing.Point(19, 23);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(251, 24);
            this.txt_descripcion.TabIndex = 18;
            this.txt_descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_idarticulo
            // 
            this.txt_idarticulo.Location = new System.Drawing.Point(579, 190);
            this.txt_idarticulo.Name = "txt_idarticulo";
            this.txt_idarticulo.Size = new System.Drawing.Size(48, 24);
            this.txt_idarticulo.TabIndex = 24;
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(671, 178);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(100, 24);
            this.txt_stock.TabIndex = 20;
            // 
            // Frm_RegistrarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 554);
            this.Controls.Add(this.grid_Articulos);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid_Venta);
            this.Controls.Add(this.cmb_empleados);
            this.Controls.Add(this.cmb_sucursales);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_clientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_idarticulo);
            this.Controls.Add(this.txt_stock);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_RegistrarVentas";
            this.Text = "Registrar Ventas";
            this.Load += new System.EventHandler(this.Frm_RegistrarVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Venta)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Clases.ComboBox01 cmb_clientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private Clases.ComboBox01 cmb_sucursales;
        private Clases.ComboBox01 cmb_empleados;
        private Clases.Grilla grid_Venta;
        private System.Windows.Forms.Label Subtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private Clases.ComboBox01 cmb_fpagos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_precio;
        private Clases.Grilla grid_Articulos;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_idarticulo;
        private System.Windows.Forms.TextBox txt_stock;
    }
}