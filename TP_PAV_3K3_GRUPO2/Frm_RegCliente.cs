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
    public partial class Frm_RegCliente : Form
    {
        public String Cuil
        {
            get { return txt_Cuil.Text; }
            set { txt_Cuil.Text = value; }
        }

        public String RazonS
        {
            get { return txt_Razon.Text; }
            set { txt_Razon.Text = value; }
        }

        public String TipoDoc
        {
            get { return cb_tipoDoc.Text; }
            set { cb_tipoDoc.Text = value; }
        }

        public String NumDoc
        {
            get { return txt_NumDoc.Text; }
            set { txt_NumDoc.Text = value; }
        }

        public String TipoTel
        {
            get { return cb_TipoTel.Text; }
            set { cb_TipoTel.Text = value; }
        }

        public String Telefono
        {
            get { return txt_numtel.Text; }
            set { txt_numtel.Text = value; }
        }

        public String NumeroDir
        {
            get { return txt_numdir.Text; }
            set { txt_numdir.Text = value; }
        }

        public String Calle
        {
            get { return txt_calle.Text; }
            set { txt_calle.Text = value; }
        }

        public String Depto
        {
            get { return txt_Depto.Text; }
            set { txt_Depto.Text = value; }
        }

        public String Piso
        {
            get { return txt_piso.Text; }
            set { txt_piso.Text = value; }
        }
        public String Barrio
        {
            get { return txt_barrio.Text; }
            set { txt_barrio.Text = value; }
        }
        public String Localidad
        {
            get { return txt_loc.Text; }
            set { txt_loc.Text = value; }
        }



        public Frm_RegCliente()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txt_Cuil.Text == "") 
            {
                MessageBox.Show("El cuil está vacio");
                this.txt_Cuil.Focus();
                return;
            }

            if (this.txt_Razon.Text == "")
            {
                MessageBox.Show("La razon social esta vacia está vacia");
                this.txt_Razon.Focus();
                return;
            }

            if (this.cb_tipoDoc.Text == "")
            {
                MessageBox.Show("El tipo documento está vacio");
                this.cb_tipoDoc.Focus();
                return;
            }

            if (this.txt_NumDoc.Text == "")
            {
                MessageBox.Show("El número documento está vacio");
                this.txt_NumDoc.Focus();
                return;
            }

            if (this.cb_TipoTel.Text == "")
            {
                MessageBox.Show("El tipo teléfono está vacio");
                this.cb_TipoTel.Focus();
                return;
            }

            if (this.txt_numtel.Text == "")
            {
                MessageBox.Show("El numero teléfono está vacio");
                this.txt_numtel.Focus();
                return;
            }

            if (this.txt_numdir.Text == "")
            {
                MessageBox.Show("El numero de dirección está vacio");
                this.txt_numdir.Focus();
                return;
            }

            if (this.txt_calle.Text == "")
            {
                MessageBox.Show("La calle está vacio");
                this.txt_calle.Focus();
                return;
            }

            if (this.txt_barrio.Text == "")
            {
                MessageBox.Show("El barrio está vacio");
                this.txt_barrio.Focus();
                return;
            }

            if (this.txt_loc.Text == "")
            {
                MessageBox.Show("La localidad está vacia");
                this.txt_loc.Focus();
                return;
            }

            this.Close();
        }

        private void Frm_RegCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
