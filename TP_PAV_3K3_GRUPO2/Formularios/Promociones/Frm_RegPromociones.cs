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

namespace TP_PAV_3K3_GRUPO2.Formularios.Promociones
{
    public partial class Frm_RegPromociones : Form
    {
        public enum ResultadoDeBusqueda { encontre, no_encontre }
        NE_Promociones Promo = new NE_Promociones();

        public Frm_RegPromociones()
        {
            InitializeComponent();
        }

        private void Frm_RegPromociones_Load(object sender, EventArgs e)
        {
            Promo.cargarCombo(ref cmb_id_articulo);
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AgregarFilaGrilaPromociones();
            //CALCULA EL TOTAL
            CalcularTotal();
        }

        private void AgregarFilaGrilaPromociones()
        {
            /*if (BuscarArticulo(cmb_id_articulo.SelectedValue.ToString()) == ResultadoDeBusqueda.encontre)
            {
                MessageBox.Show("Esta asignacion ya fue cargada");
                return;
            }*/
            grid_promociones.Rows.Add(cmb_id_articulo.SelectedValue.ToString()
                                      , cmb_id_articulo.Text
                                      , txt_cantidad._Text
                                      , txt_precio_diferenciado._Text
                                      ,txt_stock._Text);

        }

        private void grid_promociones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Esta seguro de que quiere borrar esta fila?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                grid_promociones.Rows.Remove(grid_promociones.Rows[grid_promociones.CurrentRow.Index]);
            }
        }

        //METODO PARA CALCULAR EL TOTAL
        public void CalcularTotal()
        {
            float sumar = 0;
            //MessageBox.Show(grid_promociones.Rows[0].Cells[2].Value.ToString());
            //MessageBox.Show(grid_promociones.Rows[0].Cells[3].Value.ToString());
            for (int i = 0; i < grid_promociones.Rows.Count-1; i++)
            {
                sumar += float.Parse(grid_promociones.Rows[i].Cells[2].Value.ToString())
                        * float.Parse(grid_promociones.Rows[i].Cells[3].Value.ToString());
            }
            txt_total._Text = sumar.ToString();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //GRABAR NUEVO ARTICULO
            NE_Promociones promo = new NE_Promociones();
            promo.id_promocion = int.Parse(txt_id_promocion._Text).ToString();
            promo.fecha_inicio = txt_fecha_inicio._Text.ToString();
            promo.fecha_fin = txt_fecha_fin._Text.ToString();
            promo.precio_costo = promo.FormatearDato(txt_pecio_costo._Text,"texto");
            promo.total = double.Parse(txt_total._Text).ToString();
            promo.stock = int.Parse(txt_stock._Text).ToString();
            promo.alta_logica = "1";
            promo.cantidad = int.Parse(txt_cantidad._Text).ToString();
            promo.precio_dif = double.Parse(txt_precio_diferenciado._Text).ToString();
            promo.Insertar();
            for (int fila = 0; fila < grid_promociones.Rows.Count - 1; fila++)
            {
                promo.id_promocion = int.Parse(txt_id_promocion._Text).ToString();
                promo.id_articulo = Convert.ToString(grid_promociones.Rows[fila].Cells[0].Value);
                promo.cantidad = Convert.ToString(grid_promociones.Rows[fila].Cells[2].Value);
                promo.InsertarDetalle();
                promo.stock = Convert.ToString(grid_promociones.Rows[fila].Cells[4].Value);
                promo.ModificarStock();
            }
        }

        /*private void btn_guardar_Click(object sender, EventArgs e)
        {
            //GRABAR NUEVO ARTICULO
            NE_Promociones promo = new NE_Promociones();
            promo.id_promocion = int.Parse(txt_id_promocion._Text).ToString();
            promo.fecha_inicio = txt_fecha_inicio._Text;
            promo.fecha_fin = txt_fecha_fin._Text;
            promo.precio_costo = double.Parse(txt_pecio_costo._Text).ToString();
            promo.total = double.Parse(txt_total._Text).ToString();
            promo.stock = int.Parse(txt_stock._Text).ToString();
            promo.alta_logica = "1";
            promo.cantidad = int.Parse(txt_cantidad._Text).ToString();
            promo.precio_dif = double.Parse(txt_precio_diferenciado._Text).ToString();
            promo.Insertar();
            for (int fila = 0; fila < grid_promociones.Rows.Count - 1; fila++)
            {
                promo.id_promocion = int.Parse(txt_id_promocion._Text).ToString();
                promo.id_articulo = Convert.ToString(grid_promociones.Rows[fila].Cells[0].Value);
                promo.cantidad = Convert.ToString(grid_promociones.Rows[fila].Cells[2].Value);
                promo.id_articulo = Convert.ToString(grid_promociones.Rows[fila].Cells[0].Value);
                promo.InsertarDetalle();
                //promo.stock = Convert.ToString(grid_Venta.Rows[fila].Cells[5].Value);
                promo.ModificarStock();
            }
        }*/
    }
}
