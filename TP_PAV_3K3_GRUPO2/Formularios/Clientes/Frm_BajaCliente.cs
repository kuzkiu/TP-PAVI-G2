using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using TP_PAV_3K3_GRUPO2.Negocio;

namespace TP_PAV_3K3_GRUPO2.Formularios.Clientes
{
    public partial class Frm_BajaCliente : Form
    {
        public Frm_BajaCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cmb_cuil_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_cuil.Text == "") 
            {
                MessageBox.Show("Seleccione un cuil antes de continuar.");
                return;
            }

            else 
            {
                Ne_Cliente cli_baja = new Ne_Cliente();
                cli_baja.BajaCliente(cmb_cuil.Text);
                this.Close();
            
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }

        private void Frm_BajaCliente_Load(object sender, EventArgs e)
        {
            Ne_Cliente cliente_cmb = new Ne_Cliente();
            DataTable tabla_cmb = new DataTable();
            tabla_cmb = cliente_cmb.BuscarCuils();
            cmb_cuil.DataSource = tabla_cmb;
        }

        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            if (cmb_cuil.Text == "")
            {
                MessageBox.Show("Seleccion un cuil antes de continuar");
                return;
            }

            else
            {
                Ne_Cliente cliente_baja = new Ne_Cliente();
                DataTable tabla = new DataTable();
                tabla = cliente_baja.BuscarClienteBaja(cmb_cuil.Text);
                txt_Razon.Text = tabla.Rows[0]["razon_social"].ToString();
                txt_Razon.ReadOnly = true; //aca para abaj
                txt_numtel.Text = tabla.Rows[0]["numero_telefono"].ToString();
                txt_numtel.ReadOnly = true;
                txt_tipotel.Text = tabla.Rows[0]["nombre"].ToString();
                txt_tipotel.ReadOnly = true;
                txt_NumDoc.Text = tabla.Rows[0]["nro_documento"].ToString();
                txt_NumDoc.ReadOnly = true;
                txt_tipodoc.Text = tabla.Rows[0]["nombre"].ToString();
                txt_tipodoc.ReadOnly = true;
                txt_calle.Text = tabla.Rows[0]["calle"].ToString();
                txt_calle.ReadOnly = true;
                txt_numdir.Text = tabla.Rows[0]["numero"].ToString();
                txt_numdir.ReadOnly = true;
                txt_piso.Text = tabla.Rows[0]["piso"].ToString();
                txt_piso.ReadOnly = true;
                txt_Depto.Text = tabla.Rows[0]["depto"].ToString();
                txt_Depto.ReadOnly = true;
                txt_barrio.Text = tabla.Rows[0]["nombre_barrio"].ToString();
                txt_barrio.ReadOnly = true;
                txt_loc.Text = tabla.Rows[0]["nombre_localidad"].ToString();
                txt_loc.ReadOnly = true;

            }
        }

        private void cmb_cuil_Click_1(object sender, EventArgs e)
        {

        }

        private void Frm_BajaCliente_Load_1(object sender, EventArgs e)
        {
            Ne_Cliente cliente_cmb = new Ne_Cliente();
            DataTable tabla_cmb = new DataTable();
            tabla_cmb = cliente_cmb.BuscarCuils();
            for (int i = 0; i < tabla_cmb.Rows.Count; i++)
            {
                cmb_cuil.Items.Add(tabla_cmb.Rows[i]["cuil_cliente"]);
            }
        }
    }
}
