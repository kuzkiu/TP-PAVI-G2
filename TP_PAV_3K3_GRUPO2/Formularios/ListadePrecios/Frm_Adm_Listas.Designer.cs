
namespace TP_PAV_3K3_GRUPO2.Formularios.ListadePrecios
{
    partial class Frm_Consultar_Listas
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
            this.dgw_listas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cuil = new System.Windows.Forms.TextBox();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgw_detalle = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.chb_habilitar_inicio = new System.Windows.Forms.CheckBox();
            this.chk_activas = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_listas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_listas
            // 
            this.dgw_listas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_listas.Location = new System.Drawing.Point(23, 153);
            this.dgw_listas.Name = "dgw_listas";
            this.dgw_listas.ReadOnly = true;
            this.dgw_listas.RowHeadersWidth = 62;
            this.dgw_listas.RowTemplate.Height = 28;
            this.dgw_listas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_listas.Size = new System.Drawing.Size(530, 202);
            this.dgw_listas.TabIndex = 0;
            this.dgw_listas.DoubleClick += new System.EventHandler(this.dgw_listas_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cuil:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Creada despues de:";
            // 
            // txt_cuil
            // 
            this.txt_cuil.Location = new System.Drawing.Point(177, 48);
            this.txt_cuil.Name = "txt_cuil";
            this.txt_cuil.Size = new System.Drawing.Size(144, 26);
            this.txt_cuil.TabIndex = 4;
            this.txt_cuil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.Enabled = false;
            this.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inicio.Location = new System.Drawing.Point(177, 80);
            this.dtp_inicio.MaxDate = new System.DateTime(2021, 10, 12, 0, 0, 0, 0);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(144, 26);
            this.dtp_inicio.TabIndex = 11;
            this.dtp_inicio.Value = new System.DateTime(2021, 10, 2, 0, 0, 0, 0);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(437, 115);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(116, 32);
            this.btn_Buscar.TabIndex = 13;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgw_detalle);
            this.groupBox1.Location = new System.Drawing.Point(12, 379);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 218);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Lista";
            // 
            // dgw_detalle
            // 
            this.dgw_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_detalle.Location = new System.Drawing.Point(11, 26);
            this.dgw_detalle.Name = "dgw_detalle";
            this.dgw_detalle.ReadOnly = true;
            this.dgw_detalle.RowHeadersWidth = 62;
            this.dgw_detalle.RowTemplate.Height = 28;
            this.dgw_detalle.Size = new System.Drawing.Size(530, 186);
            this.dgw_detalle.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 58);
            this.button1.TabIndex = 18;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chb_habilitar_inicio
            // 
            this.chb_habilitar_inicio.AutoSize = true;
            this.chb_habilitar_inicio.Location = new System.Drawing.Point(327, 85);
            this.chb_habilitar_inicio.Name = "chb_habilitar_inicio";
            this.chb_habilitar_inicio.Size = new System.Drawing.Size(93, 24);
            this.chb_habilitar_inicio.TabIndex = 19;
            this.chb_habilitar_inicio.Text = "Habilitar";
            this.chb_habilitar_inicio.UseVisualStyleBackColor = true;
            this.chb_habilitar_inicio.CheckedChanged += new System.EventHandler(this.chb_habilitar_inicio_CheckedChanged);
            // 
            // chk_activas
            // 
            this.chk_activas.AutoSize = true;
            this.chk_activas.Location = new System.Drawing.Point(177, 120);
            this.chk_activas.Name = "chk_activas";
            this.chk_activas.Size = new System.Drawing.Size(180, 24);
            this.chk_activas.TabIndex = 20;
            this.chk_activas.Text = "Mostrar Solo Activas";
            this.chk_activas.UseVisualStyleBackColor = true;
            // 
            // Frm_Consultar_Listas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 673);
            this.Controls.Add(this.chk_activas);
            this.Controls.Add(this.chb_habilitar_inicio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.dtp_inicio);
            this.Controls.Add(this.txt_cuil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgw_listas);
            this.Name = "Frm_Consultar_Listas";
            this.Text = "Consultar Listas";
            this.Load += new System.EventHandler(this.Frm_Consultar_Listas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_listas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_detalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_listas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cuil;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgw_detalle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chb_habilitar_inicio;
        private System.Windows.Forms.CheckBox chk_activas;
    }
}