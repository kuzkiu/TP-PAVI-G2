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
            cmb_clientes._Cargar();
            cmb_empleados._Cargar();
            cmb_fpagos._Cargar();
            cmb_sucursales._Cargar();
            NE_Ventas articulo = new NE_Ventas();
            DataTable tabla = new DataTable();
            tabla = articulo.BuscarArticulos();
            grid_Articulos.formatear("ID_Articulo, 0, I; Descripción, 200, I; Precio de venta, 100, D; Stock, 100, D");
            grid_Articulos.Cargar(tabla);
        }

        private void Subtotal_Click(object sender, EventArgs e)
        {

        }
    }
}
