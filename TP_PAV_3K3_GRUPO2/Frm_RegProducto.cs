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
    public partial class Frm_RegProducto : Form
    {

        public String Descripcion 
        {
            get { return txt_Des.Text;}
            set { txt_Des.Text = value;}

        }
        public String PCosto
        {
            get { return txt_costo.Text; }
            set { txt_costo.Text = value; }

        }
        public String PVenta
        {
            get { return txt_venta.Text; }
            set { txt_venta.Text = value; }

        }
        public String Stock
        {
            get { return txt_stock.Text; }
            set { txt_stock.Text = value; }
        }

        public String Marca
        {
            get { return txt_marca.Text; }
            set { txt_marca.Text = value; }
        }


        public String Rubro
        {
            get { return txt_rubro.Text; }
            set { txt_rubro.Text = value; }
        }



        public Frm_RegProducto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.txt_Des.Text == "")
            {
                MessageBox.Show("La descripcion esta vacia");
                this.txt_Des.Focus();
                return;

            }

            if (this.txt_marca.Text == "")
            {
                MessageBox.Show("La marca esta vacia");
                this.txt_marca.Focus();
                return;

            }
            if (this.txt_rubro.Text == "")
            {
                MessageBox.Show("La rubro esta vacia");
                this.txt_rubro.Focus();
                return;

            }
            if (this.txt_costo.Text == "")
            {
                MessageBox.Show("El costo de compra esta vacio");
                this.txt_costo.Focus();
                return;

            }
            if (this.txt_venta.Text == "")
            {
                MessageBox.Show("El costo de venta esta vacio");
                this.txt_venta.Focus();
                return;

            }
            if (this.txt_stock.Text == "")
            {
                MessageBox.Show("El stock está vacio");
                this.txt_stock.Focus();
                return;

            }
            this.Close();
        }
    }
}
