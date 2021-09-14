
namespace TP_PAV_3K3_GRUPO2.Formularios.Base
{
    partial class Frm_AdmCliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AdmCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_razonS = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cuil = new System.Windows.Forms.TextBox();
            this.DGV_clientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Razon Social:";
            // 
            // txt_razonS
            // 
            this.txt_razonS.Location = new System.Drawing.Point(136, 29);
            this.txt_razonS.Name = "txt_razonS";
            this.txt_razonS.Size = new System.Drawing.Size(143, 26);
            this.txt_razonS.TabIndex = 2;
            this.txt_razonS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_razonS_KeyPress);
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_registrar.BackgroundImage")));
            this.btn_registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_registrar.Location = new System.Drawing.Point(24, 392);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(72, 59);
            this.btn_registrar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_registrar, "Registrar nuevo Cliente");
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_modificar.BackgroundImage")));
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(120, 392);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(72, 59);
            this.btn_modificar.TabIndex = 6;
            this.toolTip2.SetToolTip(this.btn_modificar, "Modificar Cliente");
            this.toolTip1.SetToolTip(this.btn_modificar, " ");
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.BackgroundImage")));
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Location = new System.Drawing.Point(214, 391);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(79, 60);
            this.btn_eliminar.TabIndex = 7;
            this.toolTip3.SetToolTip(this.btn_eliminar, "Eliminar Cliente");
            this.btn_eliminar.UseMnemonic = false;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cuil:";
            // 
            // txt_cuil
            // 
            this.txt_cuil.Location = new System.Drawing.Point(137, 62);
            this.txt_cuil.Name = "txt_cuil";
            this.txt_cuil.Size = new System.Drawing.Size(142, 26);
            this.txt_cuil.TabIndex = 11;
            this.txt_cuil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cuil_KeyPress);
            // 
            // DGV_clientes
            // 
            this.DGV_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_clientes.Location = new System.Drawing.Point(27, 117);
            this.DGV_clientes.Name = "DGV_clientes";
            this.DGV_clientes.RowHeadersWidth = 62;
            this.DGV_clientes.RowTemplate.Height = 28;
            this.DGV_clientes.Size = new System.Drawing.Size(515, 254);
            this.DGV_clientes.TabIndex = 12;
            // 
            // Frm_AdmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 463);
            this.Controls.Add(this.DGV_clientes);
            this.Controls.Add(this.txt_cuil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txt_razonS);
            this.Controls.Add(this.label1);
            this.Name = "Frm_AdmCliente";
            this.Text = "Frm_Base";
            this.Load += new System.EventHandler(this.Frm_AdmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_razonS;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cuil;
        private System.Windows.Forms.DataGridView DGV_clientes;
    }
}