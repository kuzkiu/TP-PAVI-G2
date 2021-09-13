using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3K3_GRUPO2.Clases;
using TP_PAV_3K3_GRUPO2.Negocios;

namespace TP_PAV_3K3_GRUPO2
{
    public partial class Frm_AltaArticulos : Form
    {

        public String Descripcion 
        {
            get { return txt_descripcion.Text;}
            set { txt_descripcion.Text = value;}

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

        //public String Marca
        //{
        //    get { return txt_marca.Text; }
        //    set { txt_marca.Text = value; }
        //}


        //public String Rubro
        //{
        //    get { return txt_rubro.Text; }
        //    set { txt_rubro.Text = value; }
        //}



        public Frm_AltaArticulos()
        {
            InitializeComponent();
        }


        private void btn_Guardar_Click_1(object sender, EventArgs e)
        {
            if (this.txt_descripcion.Text == "")
            {
                MessageBox.Show("La descripción esta vacía.", "Registrar artículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_descripcion.Focus();
                return;

            }

            //if (this.txt_marca.Text == "")
            //{
            //    MessageBox.Show("La marca esta vacia");
            //    this.txt_marca.Focus();
            //    return;

            //}
            //if (this.txt_rubro.Text == "")
            //{
            //    MessageBox.Show("La rubro esta vacia");
            //    this.txt_rubro.Focus();
            //    return;

            //}
            if (this.txt_costo.Text == "")
            {
                MessageBox.Show("El costo de compra está vacío.", "Registrar artículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_costo.Focus();
                return;

            }
            if (this.txt_venta.Text == "")
            {
                MessageBox.Show("El costo de venta está vacío.", "Registrar artículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_venta.Focus();
                return;

            }
            if (this.txt_stock.Text == "")
            {
                MessageBox.Show("El stock está vacío.", "Registrar artículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_stock.Focus();
                return;

            }
            //GRABAR NUEVO ARTICULO
            NE_Articulos articulo = new NE_Articulos();
            articulo.id_rubro = cmb_rubro.SelectedValue.ToString();
            articulo.id_marca = cmb_marca.SelectedValue.ToString();
            articulo.descripcion = txt_descripcion.Text;
            articulo.precio_costo = txt_costo.Text;
            articulo.precio_venta = txt_venta.Text;
            articulo.stock_actual = txt_stock.Text;
            articulo.Insertar();

            //Limpiar campos
            txt_descripcion.Text = string.Empty;
            txt_costo.Text = string.Empty;
            txt_venta.Text = string.Empty;
            txt_stock.Text = string.Empty;
            MessageBox.Show("El artículo fue registrado correctamente.", "Registrar artículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_descripcion.Focus();
        }

        private void txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (this.txt_descripcion.Text == "")
                {
                    MessageBox.Show("Debe completar este campo.", "Registrar artículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txt_descripcion.Focus();
                    return;
                }
               else
                 cmb_rubro.Focus();
            }
        }

        private void txt_costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Campo que sólo acepte valores numéricos
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            //Si apreta ENTER pasará al siguiente campo
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (this.txt_costo.Text == "")
                {
                    MessageBox.Show("Debe completar este campo.", "Registrar artículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txt_costo.Focus();
                    return;
                }
                else
                    txt_venta.Focus();
            }
        }

        private void txt_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Campo que sólo acepte valores numéricos
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            //Si apreta ENTER pasará al siguiente campo
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (this.txt_venta.Text == "")
                {
                    MessageBox.Show("Debe completar este campo.", "Registrar artículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txt_venta.Focus();
                    return;
                }
                else
                    txt_stock.Focus();
            }
        }

        private void txt_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Campo que sólo acepte valores numéricos
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            //Si apreta ENTER pasará al siguiente campo
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (this.txt_stock.Text == "")
                {
                    MessageBox.Show("Debe completar este campo.", "Registrar artículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txt_stock.Focus();
                    return;
                }
                else
                    btn_Guardar.Focus();
            }
        }
        //Pasar a mayúsculas lo que se carga en el text
        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {
            txt_descripcion.CharacterCasing = CharacterCasing.Upper;
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_descripcion.Text = string.Empty;
            cmb_marca.SelectedIndex = 0;
            cmb_rubro.SelectedIndex = 0;
            txt_costo.Text = string.Empty;
            txt_venta.Text = string.Empty;
            txt_stock.Text = string.Empty;
            MessageBox.Show("Los campos fueron limpiados.", "Registrar artículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_descripcion.Focus();
        }

        private void Frm_AltaArticulos_Load(object sender, EventArgs e)
        {
            cmb_rubro._Cargar();
            cmb_marca._Cargar();
        }
    }
}
