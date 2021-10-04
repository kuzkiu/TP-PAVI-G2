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

            txt_total.Text = "0.00";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = new DateTime(2021, 10, 1);
            dateTimePicker1.MaxDate = DateTime.Today;
            //Carga de combos
            cmb_clientes._Cargar();
            cmb_clientes.SelectedIndex = 0;
            cmb_empleados._Cargar();
            cmb_fpagos._Cargar();
            cmb_sucursales._Cargar();
            //Carga de grillas
            NE_Ventas articulo = new NE_Ventas();
            DataTable tabla = new DataTable();
            tabla = articulo.BuscarArticulos();
            grid_Articulos.formatear("ID_Articulo, 0, I; Descripción, 230, I; Precio de venta, 100, D; Stock, 100, D");
            grid_Articulos.Cargar(tabla);
            NE_Ventas venta = new NE_Ventas();
            DataTable tabla2 = new DataTable();
            tabla2 = venta.BuscarArticulos();
            grid_Venta.formatear("ID_Articulo, 0, I; Descripción, 210, I; Precio de venta, 90, D; Cantidad, 60, D; Subtotal, 100, D; StockActualizado,0, I");
            BuscarUltFactura();



        }

        private void Subtotal_Click(object sender, EventArgs e)
        {

        }

        private void grid_Articulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void grid_Articulos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int renglon = e.RowIndex;
            //txt_idarticulo.Text = grid_Articulos.Rows[renglon].Cells[0].Value.ToString();
            //txt_descripcion.Text = grid_Articulos.Rows[renglon].Cells[1].Value.ToString();
            
            //String value = grid_Articulos.Rows[renglon].Cells[2].Value.ToString();
            //int length = value.Length - 2;
            //txt_precio.Text = value.Substring(0, length);

            //txt_stock.Text = grid_Articulos.Rows[renglon].Cells[3].Value.ToString();
            //txt_cantidad.Enabled = true;
            //txt_cantidad.Focus();
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
                        
                        int bandera = 0;
                         for (int fila = 0; fila < grid_Venta.Rows.Count; fila++)
                        {
                            int a = Convert.ToInt32(grid_Venta.Rows[fila].Cells[0].Value);
                            int b = Convert.ToInt32(txt_idarticulo.Text);

                            if (b == a)
                            {
                                grid_Venta.Rows[fila].Cells[3].Value = Convert.ToInt32(grid_Venta.Rows[fila].Cells[3].Value) + Convert.ToInt32(txt_cantidad.Text);
                                grid_Venta.Rows[fila].Cells[5].Value = Convert.ToInt32(grid_Venta.Rows[fila].Cells[5].Value) - Convert.ToInt32(txt_cantidad.Text);
                                bandera = 1;
                            }

                        }

                        if (bandera ==0)
                        {
                            decimal Precio_Servicio_Aux = decimal.TryParse(txt_precio.Text, out Precio_Servicio_Aux) ? Convert.ToDecimal(txt_precio.Text) : (decimal)0.0;
                            decimal Precio_Servicio = Precio_Servicio_Aux;
                            grid_Venta.Rows.Add(txt_idarticulo.Text, txt_descripcion.Text, txt_precio.Text, txt_cantidad.Text, Precio_Servicio * Convert.ToInt32(txt_cantidad.Text), Convert.ToInt32(txt_stock.Text) - Convert.ToInt32(txt_cantidad.Text));
                        }
                        ActualizarTotal();
                        txt_cantidad.Text = "";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            txt_buscar.CharacterCasing = CharacterCasing.Upper;
            NE_Ventas articulo = new NE_Ventas();
            DataTable tabla = new DataTable();
            tabla = articulo.FiltrarArticulos(txt_buscar.Text);
            grid_Articulos.Cargar(tabla);

        }

        private void grid_Venta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_Venta_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar el artículo cargado?", "¡Atención!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                grid_Venta.Rows.Remove(grid_Venta.CurrentRow);
                ActualizarTotal();
            }

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //GRABAR NUEVO ARTICULO
            NE_Ventas venta = new NE_Ventas();
            venta.nro_factura = txt_nroFactura.Text;
            venta.id_tipoFactura = "1";
            venta.fecha_venta = dateTimePicker1.Value.ToString();
            venta.cuil_cliente = cmb_clientes.SelectedValue.ToString();
            venta.id_sucursal = cmb_sucursales.SelectedValue.ToString();
            venta.nro_doc_emp = cmb_empleados.SelectedValue.ToString();
            venta.id_formaDePago = cmb_fpagos.SelectedValue.ToString();
            venta.monto_total = txt_total.Text;
            venta.alta_logica = "1";
            venta.Insertar();
            for (int fila = 0; fila < grid_Venta.Rows.Count-1; fila++)
            {
                venta.nro_factura = txt_nroFactura.Text;
                venta.id_tipoFactura = "1";
                venta.nro_factura = txt_nroFactura.Text;
                venta.id_articulo = Convert.ToString(grid_Venta.Rows[fila].Cells[0].Value);
                venta.precio_unitario = Convert.ToString(grid_Venta.Rows[fila].Cells[2].Value);
                venta.cantidad = Convert.ToString(grid_Venta.Rows[fila].Cells[3].Value);
                venta.InsertarDetalle();
                venta.stock_actual= Convert.ToString(grid_Venta.Rows[fila].Cells[5].Value);
                venta.ModificarStock();
            }

            Limpiar();
            MessageBox.Show("La venta se ha registrado correctamente.", "Registrar Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmb_clientes.Focus();
        }
        private void Limpiar()
        {
            //Limpiar campos
            cmb_clientes.SelectedIndex = 0;
            cmb_empleados.SelectedIndex = 0;
            cmb_fpagos.SelectedIndex = 0;
            cmb_sucursales.SelectedIndex = 0;
            txt_idarticulo.Text = string.Empty;
            txt_cantidad.Text = string.Empty;
            txt_stock.Text = string.Empty;
            txt_descripcion.Text = string.Empty;
            txt_precio.Text = string.Empty;
            txt_buscar.Text = string.Empty;
            txt_total.Text = "0.00";
            BuscarUltFactura();
            NE_Ventas articulo = new NE_Ventas();
            DataTable tabla = new DataTable();
            tabla = articulo.BuscarArticulos();
            grid_Articulos.Cargar(tabla);
            grid_Venta.Rows.Clear();

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
