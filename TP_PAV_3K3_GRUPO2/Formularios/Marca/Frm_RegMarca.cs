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
    public partial class Frm_RegMarca : Form
    {
        public String Nombre
        {
            get { return txt_nombre.Text; }
            set { txt_nombre.Text = value; }
        }


        public Frm_RegMarca()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_RegMarca_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txt_nombre.Text == "")
            {
                MessageBox.Show("El nombre esta vacio");
                this.txt_nombre.Focus();
                return;

            }
            this.Close();
        }
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (this.txt_nombre.Text == "")
            {
                MessageBox.Show("El nombre está vacio");
                this.txt_nombre.Focus();
                return;
            }
            this.Close();
            MessageBox.Show("Datos Cargados Correctamente");
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
