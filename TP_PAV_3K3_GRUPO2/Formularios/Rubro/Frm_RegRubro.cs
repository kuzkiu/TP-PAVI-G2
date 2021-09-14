using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV_3K3_GRUPO2.Formularios.Rubro
{
    public partial class Frm_RegRubro : Form
    {

        public String idRubro
        {
            get { return txt_idRubro.Text; }
            set { txt_idRubro.Text = value; }
        }

        public String nombreRubro
        {
            get { return txt_nomRubro.Text; }
            set { txt_nomRubro.Text = value; }
        }

        public Frm_RegRubro()
        {
            InitializeComponent();
        }

        private void Frm_RegRubro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txt_idRubro.Text == "")
            {
                MessageBox.Show("El id de Rubro está vacio");
                this.txt_idRubro.Focus();
                return;
            }

            if (this.txt_nomRubro.Text == "")
            {
                MessageBox.Show("El nombre del rubro está vacio");
                this.txt_nomRubro.Focus();
                return;
            }

            this.Close();
        }
    }
}
