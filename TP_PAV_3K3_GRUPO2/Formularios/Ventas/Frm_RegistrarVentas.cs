﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3K3_GRUPO2.Negocios;
using TP_PAV_3K3_GRUPO2.Clases;




namespace TP_PAV_3K3_GRUPO2.Formularios.Ventas
{
    public partial class Frm_RegistrarVentas : Form
    {
        public Frm_RegistrarVentas()
        {
            InitializeComponent();
        }

        private void Frm_RegistrarVentas_Load(object sender, EventArgs e)
        {
            BE_Acceso_Datos _BD = new BE_Acceso_Datos();


            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = new DateTime(2021, 10, 1);
            dateTimePicker1.MaxDate = DateTime.Today;
            //Carga de combos
            cmb_clientes._Cargar();
            cmb_empleados._Cargar();
            cmb_fpagos._Cargar();
            cmb_sucursales._Cargar();
            //Carga de grillas
            NE_Ventas articulo = new NE_Ventas();
            DataTable tabla = new DataTable();
            tabla = articulo.BuscarArticulos();
            grid_Articulos.formatear("ID_Articulo, 0, I; Descripción, 240, I; Precio de venta, 100, D; Stock, 100, D");
            grid_Articulos.Cargar(tabla);
            NE_Ventas venta = new NE_Ventas();
            DataTable tabla2 = new DataTable();
            tabla2 = venta.BuscarArticulos();
            grid_Venta.formatear("ID_Articulo, 0, I; Descripción, 210, I; Precio de venta, 90, D; Cantidad, 60, D; Subtotal, 100, D");
            BuscarUltFactura();



        }

        private void Subtotal_Click(object sender, EventArgs e)
        {

        }

        private void grid_Articulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_Articulos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int renglon = e.RowIndex;
            txt_idarticulo.Text = grid_Articulos.Rows[renglon].Cells[0].Value.ToString();
            txt_descripcion.Text = grid_Articulos.Rows[renglon].Cells[1].Value.ToString();
            
            String value = grid_Articulos.Rows[renglon].Cells[2].Value.ToString();
            int length = value.Length - 2;
            txt_precio.Text = value.Substring(0, length);

            txt_stock.Text = grid_Articulos.Rows[renglon].Cells[3].Value.ToString();
            txt_cantidad.Enabled = true;
            txt_cantidad.Focus();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Campo que sólo acepte valores numéricos
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            //Si apreta ENTER pasará al siguiente campo
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (this.txt_cantidad.Text == "")
                {
                    MessageBox.Show("Debe completar este campo.", "Registrar Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txt_cantidad.Focus();
                    return;
                }
                else
                {
                    if (Convert.ToInt32(txt_cantidad.Text) <= Convert.ToInt32(txt_stock.Text))
                    {
                        decimal Precio_Servicio_Aux = decimal.TryParse(txt_precio.Text, out Precio_Servicio_Aux) ? Convert.ToDecimal(txt_precio.Text) : (decimal)0.0;
                        decimal Precio_Servicio = Precio_Servicio_Aux;
                        grid_Venta.Rows.Add(txt_idarticulo.Text, txt_descripcion.Text, txt_precio.Text, txt_cantidad.Text, Precio_Servicio * Convert.ToInt32(txt_cantidad.Text));
                        ActualizarTotal();
                    }
                   else
                    {
                        MessageBox.Show("La cantidad vendida no puede ser superior al stock actual." + "\n\n" + "Stock disponible: " + txt_stock.Text.ToString(), "Registrar Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txt_cantidad.Focus();
                    }
                }
            }
        }
        public void ActualizarTotal()
        {
            txt_total.Text = "0";
            int suma = 0;
            for (int fila = 0; fila < grid_Venta.Rows.Count; fila++)
            {

                suma = suma + Convert.ToInt32(grid_Venta.Rows[fila].Cells[4].Value);
            }
            //decimal Precio_Servicio_Aux = decimal.TryParse(suma, out Precio_Servicio_Aux) ? Convert.ToDecimal(suma) : (decimal)0.0;
            //decimal Precio_Servicio = Precio_Servicio_Aux;
            txt_total.Text = string.Format("{0:F2}", suma); ;
            grid_Venta.Columns[0].Visible = false;
        }
        public void BuscarUltFactura()
        {
            BE_Acceso_Datos _BD = new BE_Acceso_Datos();
            //Buscar última factura
            string ultimoID = @"SELECT MAX(nro_factura) maximo FROM Factura";
            DataTable tabla3 = new DataTable();
            tabla3 = _BD.EjecutarSelect(ultimoID);
            int MaxID = 0;
            if (tabla3.Rows.Count > 0)
            {
                MaxID = Convert.ToInt32(tabla3.Rows[0][0]) + 1;
            }
            txt_nroFactura.Text = MaxID.ToString("D8");
        }
    }
}
