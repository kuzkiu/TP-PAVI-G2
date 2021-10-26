
namespace TP_PAV_3K3_GRUPO2.Formularios.Promociones
{
    partial class Frm_RegPromociones
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
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.grid_promociones = new TP_PAV_3K3_GRUPO2.Clases.Grilla();
            this.cmb_id_articulo = new TP_PAV_3K3_GRUPO2.Clases.ComboBox01();
            this.txt_cantidad = new TP_PAV_3K3_GRUPO2.Clases.Label_Text();
            this.txt_precio_diferenciado = new TP_PAV_3K3_GRUPO2.Clases.Label_Text();
            this.txt_stock = new TP_PAV_3K3_GRUPO2.Clases.Label_Text();
            this.txt_total = new TP_PAV_3K3_GRUPO2.Clases.Label_Text();
            this.txt_pecio_costo = new TP_PAV_3K3_GRUPO2.Clases.Label_Text();
            this.txt_fecha_fin = new TP_PAV_3K3_GRUPO2.Clases.Label_Text();
            this.txt_fecha_inicio = new TP_PAV_3K3_GRUPO2.Clases.Label_Text();
            this.txt_id_promocion = new TP_PAV_3K3_GRUPO2.Clases.Label_Text();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_promociones)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(635, 126);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(98, 28);
            this.btn_agregar.TabIndex = 10;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Registrar Promociones";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(34, 363);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(96, 39);
            this.btn_guardar.TabIndex = 13;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // grid_promociones
            // 
            this.grid_promociones._formatoLetraHeader = System.Drawing.FontStyle.Regular;
            this.grid_promociones._tamannoLetraHeader = 9;
            this.grid_promociones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_promociones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grid_promociones.Location = new System.Drawing.Point(257, 169);
            this.grid_promociones.Name = "grid_promociones";
            this.grid_promociones.Size = new System.Drawing.Size(497, 248);
            this.grid_promociones.TabIndex = 9;
            this.grid_promociones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_promociones_CellDoubleClick);
            // 
            // cmb_id_articulo
            // 
            this.cmb_id_articulo._ComboSinSeleccion = false;
            this.cmb_id_articulo._MensajeError = null;
            this.cmb_id_articulo._Nombre_campo = null;
            this.cmb_id_articulo._Nombre_tabla = null;
            this.cmb_id_articulo._tabla_cargar_combo = null;
            this.cmb_id_articulo._tabla_cargar_descriptor = null;
            this.cmb_id_articulo._tabla_cargar_pk = null;
            this.cmb_id_articulo._Validable = false;
            this.cmb_id_articulo.FormattingEnabled = true;
            this.cmb_id_articulo.Location = new System.Drawing.Point(360, 65);
            this.cmb_id_articulo.Name = "cmb_id_articulo";
            this.cmb_id_articulo.Size = new System.Drawing.Size(121, 21);
            this.cmb_id_articulo.TabIndex = 8;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad._Ancho = 10;
            this.txt_cantidad._Decimales = 0;
            this.txt_cantidad._Etiqueta = "Cantidad";
            this.txt_cantidad._MensajeError = null;
            this.txt_cantidad._Nobre_tabla = null;
            this.txt_cantidad._Nombre_campo = null;
            this.txt_cantidad._ReadOnly = false;
            this.txt_cantidad._Text = "";
            this.txt_cantidad._TipoDato = TP_PAV_3K3_GRUPO2.Clases.Label_Text.TipoDato.numero;
            this.txt_cantidad._Validable = false;
            this.txt_cantidad.Location = new System.Drawing.Point(360, 126);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(182, 28);
            this.txt_cantidad.TabIndex = 7;
            // 
            // txt_precio_diferenciado
            // 
            this.txt_precio_diferenciado._Ancho = 10;
            this.txt_precio_diferenciado._Decimales = 2;
            this.txt_precio_diferenciado._Etiqueta = "Precio Diferenciado";
            this.txt_precio_diferenciado._MensajeError = null;
            this.txt_precio_diferenciado._Nobre_tabla = null;
            this.txt_precio_diferenciado._Nombre_campo = null;
            this.txt_precio_diferenciado._ReadOnly = false;
            this.txt_precio_diferenciado._Text = "       ,";
            this.txt_precio_diferenciado._TipoDato = TP_PAV_3K3_GRUPO2.Clases.Label_Text.TipoDato.numero;
            this.txt_precio_diferenciado._Validable = false;
            this.txt_precio_diferenciado.Location = new System.Drawing.Point(360, 92);
            this.txt_precio_diferenciado.Name = "txt_precio_diferenciado";
            this.txt_precio_diferenciado.Size = new System.Drawing.Size(243, 28);
            this.txt_precio_diferenciado.TabIndex = 6;
            // 
            // txt_stock
            // 
            this.txt_stock._Ancho = 10;
            this.txt_stock._Decimales = 0;
            this.txt_stock._Etiqueta = "Stock";
            this.txt_stock._MensajeError = null;
            this.txt_stock._Nobre_tabla = null;
            this.txt_stock._Nombre_campo = null;
            this.txt_stock._ReadOnly = false;
            this.txt_stock._Text = "";
            this.txt_stock._TipoDato = TP_PAV_3K3_GRUPO2.Clases.Label_Text.TipoDato.numero;
            this.txt_stock._Validable = false;
            this.txt_stock.Location = new System.Drawing.Point(29, 294);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(166, 28);
            this.txt_stock.TabIndex = 5;
            // 
            // txt_total
            // 
            this.txt_total._Ancho = 10;
            this.txt_total._Decimales = 2;
            this.txt_total._Etiqueta = "Total";
            this.txt_total._MensajeError = null;
            this.txt_total._Nobre_tabla = null;
            this.txt_total._Nombre_campo = null;
            this.txt_total._ReadOnly = false;
            this.txt_total._Text = "       ,";
            this.txt_total._TipoDato = TP_PAV_3K3_GRUPO2.Clases.Label_Text.TipoDato.numero;
            this.txt_total._Validable = false;
            this.txt_total.Location = new System.Drawing.Point(29, 259);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(166, 28);
            this.txt_total.TabIndex = 4;
            // 
            // txt_pecio_costo
            // 
            this.txt_pecio_costo._Ancho = 10;
            this.txt_pecio_costo._Decimales = 2;
            this.txt_pecio_costo._Etiqueta = "Precio Costo";
            this.txt_pecio_costo._MensajeError = null;
            this.txt_pecio_costo._Nobre_tabla = null;
            this.txt_pecio_costo._Nombre_campo = null;
            this.txt_pecio_costo._ReadOnly = false;
            this.txt_pecio_costo._Text = "       ,";
            this.txt_pecio_costo._TipoDato = TP_PAV_3K3_GRUPO2.Clases.Label_Text.TipoDato.numero;
            this.txt_pecio_costo._Validable = false;
            this.txt_pecio_costo.Location = new System.Drawing.Point(29, 224);
            this.txt_pecio_costo.Name = "txt_pecio_costo";
            this.txt_pecio_costo.Size = new System.Drawing.Size(194, 28);
            this.txt_pecio_costo.TabIndex = 3;
            // 
            // txt_fecha_fin
            // 
            this.txt_fecha_fin._Ancho = 10;
            this.txt_fecha_fin._Decimales = 0;
            this.txt_fecha_fin._Etiqueta = "Fecha Fin";
            this.txt_fecha_fin._MensajeError = null;
            this.txt_fecha_fin._Nobre_tabla = null;
            this.txt_fecha_fin._Nombre_campo = null;
            this.txt_fecha_fin._ReadOnly = false;
            this.txt_fecha_fin._Text = "  /  /";
            this.txt_fecha_fin._TipoDato = TP_PAV_3K3_GRUPO2.Clases.Label_Text.TipoDato.fecha;
            this.txt_fecha_fin._Validable = false;
            this.txt_fecha_fin.Location = new System.Drawing.Point(29, 189);
            this.txt_fecha_fin.Name = "txt_fecha_fin";
            this.txt_fecha_fin.Size = new System.Drawing.Size(183, 28);
            this.txt_fecha_fin.TabIndex = 2;
            // 
            // txt_fecha_inicio
            // 
            this.txt_fecha_inicio._Ancho = 10;
            this.txt_fecha_inicio._Decimales = 0;
            this.txt_fecha_inicio._Etiqueta = "Fecha Inicio";
            this.txt_fecha_inicio._MensajeError = null;
            this.txt_fecha_inicio._Nobre_tabla = null;
            this.txt_fecha_inicio._Nombre_campo = null;
            this.txt_fecha_inicio._ReadOnly = false;
            this.txt_fecha_inicio._Text = "  /  /";
            this.txt_fecha_inicio._TipoDato = TP_PAV_3K3_GRUPO2.Clases.Label_Text.TipoDato.fecha;
            this.txt_fecha_inicio._Validable = false;
            this.txt_fecha_inicio.Location = new System.Drawing.Point(29, 154);
            this.txt_fecha_inicio.Name = "txt_fecha_inicio";
            this.txt_fecha_inicio.Size = new System.Drawing.Size(194, 28);
            this.txt_fecha_inicio.TabIndex = 1;
            // 
            // txt_id_promocion
            // 
            this.txt_id_promocion._Ancho = 10;
            this.txt_id_promocion._Decimales = 0;
            this.txt_id_promocion._Etiqueta = "Id";
            this.txt_id_promocion._MensajeError = null;
            this.txt_id_promocion._Nobre_tabla = null;
            this.txt_id_promocion._Nombre_campo = null;
            this.txt_id_promocion._ReadOnly = false;
            this.txt_id_promocion._Text = "";
            this.txt_id_promocion._TipoDato = TP_PAV_3K3_GRUPO2.Clases.Label_Text.TipoDato.numero;
            this.txt_id_promocion._Validable = false;
            this.txt_id_promocion.Location = new System.Drawing.Point(29, 119);
            this.txt_id_promocion.Name = "txt_id_promocion";
            this.txt_id_promocion.Size = new System.Drawing.Size(166, 28);
            this.txt_id_promocion.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id Articulo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion Articulo";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio Diferenciado";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Stock";
            this.Column5.Name = "Column5";
            // 
            // Frm_RegPromociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.grid_promociones);
            this.Controls.Add(this.cmb_id_articulo);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_precio_diferenciado);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_pecio_costo);
            this.Controls.Add(this.txt_fecha_fin);
            this.Controls.Add(this.txt_fecha_inicio);
            this.Controls.Add(this.txt_id_promocion);
            this.Name = "Frm_RegPromociones";
            this.Text = "Frm_RegPromociones";
            this.Load += new System.EventHandler(this.Frm_RegPromociones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_promociones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.Label_Text txt_id_promocion;
        private Clases.Label_Text txt_fecha_inicio;
        private Clases.Label_Text txt_fecha_fin;
        private Clases.Label_Text txt_pecio_costo;
        private Clases.Label_Text txt_total;
        private Clases.Label_Text txt_stock;
        private Clases.Label_Text txt_precio_diferenciado;
        private Clases.Label_Text txt_cantidad;
        private Clases.ComboBox01 cmb_id_articulo;
        private Clases.Grilla grid_promociones;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}