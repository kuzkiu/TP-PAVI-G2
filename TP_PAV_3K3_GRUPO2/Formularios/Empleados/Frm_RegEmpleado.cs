using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV_3K3_GRUPO2
{
    public partial class Frm_RegEmpleado : Form
    {
        public String TipoDoc_E
        {
            get { return txt_NombreE.Text; }
            set { txt_NombreE.Text = value; }
        }
        public String NroDocumento_E
        {
            get { return txt_NombreE.Text; }
            set { txt_NombreE.Text = value; }
        }
        public String Nombre_E
        {
            get { return txt_NombreE.Text; }
            set { txt_NombreE.Text = value; }
        }
        public String Apellido_E
        {
            get { return txt_ApellidoE.Text; }
            set { txt_ApellidoE.Text = value; }
        }
        public String FechaIng_E
        {
            get { return dp_FechaIngE.Text; }
            set { dp_FechaIngE.Text = value; }
        }
        public String FechaNac_E
        {
            get { return dp_FechaNacE.Text; }
            set { dp_FechaNacE.Text = value; }//No se si es TEXT O  SELECT
        }
        public String Calle_E
        {
            get { return txt_calleE.Text; }
            set { txt_calleE.Text = value; }
        }

        public String Numero_E
        {
            get { return txt_NumeroE.Text; }
            set { txt_NumeroE.Text = value; }
        }
        public String Piso_E
        {
            get { return txt_pisoE.Text; }
            set { txt_pisoE.Text = value; }
        }
        public String BarrioE
        {
            get { return txt_barrioE.Text; }
            set { txt_barrioE.Text = value; }
        }
        public String Localidad_E
        {
            get { return txt_localidadE.Text; }
            set { txt_localidadE.Text = value; }
        }



        public Frm_RegEmpleado()
        {

            InitializeComponent();
        }

        private void Frm_RegEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.cb_tipoDocE.Text == "")
            {
                MessageBox.Show("No ha seleccionado ningún documento");
                this.txt_NombreE.Focus();
                return;
            }
            if (this.txt_NombreE.Text == "")
            {
                MessageBox.Show("No ha ingresado ningún Nombre");
                this.txt_NombreE.Focus();
                return;
            }
            if (this.txt_ApellidoE.Text == "")
            {
                MessageBox.Show("No ha ingresado ningún Apellido");
                this.txt_NombreE.Focus();
                return;
            }
            if (this.txt_DocumentoE.Text == "")
            {
                MessageBox.Show("No ha ingresado ningún Documento");
                this.txt_NombreE.Focus();
                return;
            }
            if (this.txt_NumeroE.Text == "")
            {
                MessageBox.Show("No ha ingresado ningún numero");
                this.txt_NombreE.Focus();
                return;
            }
            if (this.txt_calleE.Text == "")
            {
                MessageBox.Show("No ha ingresado ninguna calle");
                this.txt_NombreE.Focus();
                return;
            }
            if (this.dp_FechaNacE.Text == "")
            {
                MessageBox.Show("No ha seleccionado ninguna fecha de nacimiento");
                this.txt_NombreE.Focus();
                return;
            }
            if (this.dp_FechaIngE.Text == "")
            {
                MessageBox.Show("No ha seleccionado ninguna fecha de Ingreso");
                this.txt_NombreE.Focus();
                return;
            }
            if (this.cb_cargoE.Text == "")
            {
                MessageBox.Show("No ha seleccionado ningún cargo");
                this.txt_NombreE.Focus();
                return;
            }
            if (this.txt_barrioE.Text == "")
            {
                MessageBox.Show("No ha ingresado ningun barrio");
                this.txt_NombreE.Focus();
                return;
            }

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_tipoDocE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_DocumentoE_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Frm_RegEmpleado
            // 
            this.ClientSize = new System.Drawing.Size(429, 405);
            this.Name = "Frm_RegEmpleado";
            this.ResumeLayout(false);

        }
    }
}
