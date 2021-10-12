
namespace TP_PAV_3K3_GRUPO2.Formularios.ListadePrecios
{
    partial class Frm_Registrar_Lista
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
            this.cmb_cuils = new System.Windows.Forms.ComboBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_detalles = new System.Windows.Forms.DataGridView();
            this.txt_precion = new System.Windows.Forms.TextBox();
            this.txt_precioo = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.cmb_id = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.id_articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_dif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuil:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Lista:";
            // 
            // cmb_cuils
            // 
            this.cmb_cuils.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cuils.FormattingEnabled = true;
            this.cmb_cuils.Location = new System.Drawing.Point(208, 34);
            this.cmb_cuils.Name = "cmb_cuils";
            this.cmb_cuils.Size = new System.Drawing.Size(163, 28);
            this.cmb_cuils.TabIndex = 2;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(207, 78);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(164, 26);
            this.txt_id.TabIndex = 3;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(387, 75);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(120, 33);
            this.btn_confirmar.TabIndex = 4;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_detalles);
            this.groupBox1.Controls.Add(this.txt_precion);
            this.groupBox1.Controls.Add(this.txt_precioo);
            this.groupBox1.Controls.Add(this.txt_descripcion);
            this.groupBox1.Controls.Add(this.cmb_id);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_Eliminar);
            this.groupBox1.Controls.Add(this.btn_modificar);
            this.groupBox1.Controls.Add(this.btn_Agregar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(40, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 317);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Lista";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgv_detalles
            // 
            this.dgv_detalles.AllowUserToAddRows = false;
            this.dgv_detalles.AllowUserToDeleteRows = false;
            this.dgv_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_articulo,
            this.descripcion,
            this.precio_dif});
            this.dgv_detalles.Location = new System.Drawing.Point(442, 25);
            this.dgv_detalles.MultiSelect = false;
            this.dgv_detalles.Name = "dgv_detalles";
            this.dgv_detalles.ReadOnly = true;
            this.dgv_detalles.RowHeadersWidth = 62;
            this.dgv_detalles.RowTemplate.Height = 28;
            this.dgv_detalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detalles.Size = new System.Drawing.Size(524, 263);
            this.dgv_detalles.TabIndex = 17;
            this.dgv_detalles.DoubleClick += new System.EventHandler(this.dgv_detalles_DoubleClick);
            // 
            // txt_precion
            // 
            this.txt_precion.Enabled = false;
            this.txt_precion.Location = new System.Drawing.Point(168, 171);
            this.txt_precion.Name = "txt_precion";
            this.txt_precion.Size = new System.Drawing.Size(163, 26);
            this.txt_precion.TabIndex = 16;
            // 
            // txt_precioo
            // 
            this.txt_precioo.Enabled = false;
            this.txt_precioo.Location = new System.Drawing.Point(168, 136);
            this.txt_precioo.Name = "txt_precioo";
            this.txt_precioo.ReadOnly = true;
            this.txt_precioo.Size = new System.Drawing.Size(163, 26);
            this.txt_precioo.TabIndex = 15;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Enabled = false;
            this.txt_descripcion.Location = new System.Drawing.Point(167, 104);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.ReadOnly = true;
            this.txt_descripcion.Size = new System.Drawing.Size(164, 26);
            this.txt_descripcion.TabIndex = 14;
            // 
            // cmb_id
            // 
            this.cmb_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_id.Enabled = false;
            this.cmb_id.FormattingEnabled = true;
            this.cmb_id.Location = new System.Drawing.Point(167, 67);
            this.cmb_id.Name = "cmb_id";
            this.cmb_id.Size = new System.Drawing.Size(164, 28);
            this.cmb_id.TabIndex = 13;
            this.cmb_id.SelectedValueChanged += new System.EventHandler(this.cmb_id_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Precio Diferenciado:";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Enabled = false;
            this.btn_Eliminar.Location = new System.Drawing.Point(300, 229);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(99, 59);
            this.btn_Eliminar.TabIndex = 11;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Enabled = false;
            this.btn_modificar.Location = new System.Drawing.Point(167, 229);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(103, 59);
            this.btn_modificar.TabIndex = 10;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Enabled = false;
            this.btn_Agregar.Location = new System.Drawing.Point(23, 229);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(98, 59);
            this.btn_Agregar.TabIndex = 9;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio Original:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID articulo:";
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Enabled = false;
            this.btn_Registrar.Location = new System.Drawing.Point(845, 451);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(177, 44);
            this.btn_Registrar.TabIndex = 7;
            this.btn_Registrar.Text = "Confirmar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(40, 451);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(145, 44);
            this.btn_Cancelar.TabIndex = 8;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // id_articulo
            // 
            this.id_articulo.HeaderText = "ID Articulo";
            this.id_articulo.MinimumWidth = 8;
            this.id_articulo.Name = "id_articulo";
            this.id_articulo.ReadOnly = true;
            this.id_articulo.Width = 150;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.MinimumWidth = 8;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 150;
            // 
            // precio_dif
            // 
            this.precio_dif.HeaderText = "Precio Diferenciado";
            this.precio_dif.MinimumWidth = 8;
            this.precio_dif.Name = "precio_dif";
            this.precio_dif.ReadOnly = true;
            this.precio_dif.Width = 150;
            // 
            // Frm_Registrar_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 512);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.cmb_cuils);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Registrar_Lista";
            this.Text = "Registrar Lista";
            this.Load += new System.EventHandler(this.Frm_Registrar_Lista_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_cuils;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_precion;
        private System.Windows.Forms.TextBox txt_precioo;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.ComboBox cmb_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DataGridView dgv_detalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_dif;
    }
}