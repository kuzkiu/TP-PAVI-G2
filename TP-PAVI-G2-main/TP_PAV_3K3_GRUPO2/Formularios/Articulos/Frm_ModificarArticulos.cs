using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3K3_GRUPO2.Negocios;

namespace TP_PAV_3K3_GRUPO2
{
    public partial class Frm_ModificarArticulos : Form
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



        public Frm_ModificarArticulos()
        {
            InitializeComponent();
        }

 
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.txt_descripcion.Text == "")
            {
                MessageBox.Show("La descripción esta vacia");
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


        private void txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txt_descripcion.Text == "")
                {
                    MessageBox.Show("Debe completar este campo.");
                    txt_descripcion.Focus();
                    return;
                }
            }
        }

        private void txt_descripcion_TextAlignChanged(object sender, EventArgs e)
        {
            txt_descripcion.CharacterCasing = CharacterCasing.Upper;

        }

        private void cmb_rubro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frm_ConsultaArticulos_Load(object sender, EventArgs e)
        {
            this.grid_Articulos.formatear("ID_Articulo, 0, I; Descripción, 200, I; Rubro, 100, I; Marca, 100, I; Precio de costo, 100, D; Precio de venta, 100, D; Stock, 100, D");

            cmb_rubro._Cargar();
            cmb_marca._Cargar();


            NE_Articulos articulo = new NE_Articulos();
            DataTable tabla = new DataTable();
            tabla = articulo.BuscarArticulos("Art", "descripcion");
            grid_Articulos.Cargar(tabla);
        }

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
            grid_Articulos.ClearSelection();
        }

        private void grid_Articulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int renglon = e.RowIndex;
            txt_id_articulo.Text= grid_Articulos.Rows[renglon].Cells[0].Value.ToString();
            txt_descripcion.Text = grid_Articulos.Rows[renglon].Cells[1].Value.ToString();
            cmb_rubro.Text = grid_Articulos.Rows[renglon].Cells[2].Value.ToString();
            cmb_marca.Text = grid_Articulos.Rows[renglon].Cells[3].Value.ToString();
            txt_costo.Text = grid_Articulos.Rows[renglon].Cells[4].Value.ToString();
            txt_venta.Text = grid_Articulos.Rows[renglon].Cells[5].Value.ToString();
            txt_stock.Text = grid_Articulos.Rows[renglon].Cells[6].Value.ToString();

        }

        private void grid_Articulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
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
            articulo.id_articulo = txt_id_articulo.Text;
            articulo.id_rubro = cmb_rubro.SelectedValue.ToString();
            articulo.id_marca = cmb_marca.SelectedValue.ToString();
            articulo.descripcion = txt_descripcion.Text;
            articulo.precio_costo = txt_costo.Text;
            articulo.precio_venta = txt_venta.Text;
            articulo.stock_actual = txt_stock.Text;
            articulo.Modificar();

            //Limpiar campos
            txt_descripcion.Text = string.Empty;
            txt_costo.Text = string.Empty;
            txt_venta.Text = string.Empty;
            txt_stock.Text = string.Empty;
            MessageBox.Show("El artículo fue modificado correctamente.", "Registrar artículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_descripcion.Focus();
        }
    }
}
