using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3K3_GRUPO2.Negocio;
using System.Data;

namespace TP_PAV_3K3_GRUPO2.Formularios.Clientes
{
    public partial class Frm_ModificarCliente : Form
    {
        public Frm_ModificarCliente()
        {
            InitializeComponent();
        }

        private void Frm_ModificarCliente_Load(object sender, EventArgs e)
        {
            Ne_TIpoDocumento tipo_doc = new Ne_TIpoDocumento();
            DataTable tabla_cmb_tipodoc = new DataTable();
            tabla_cmb_tipodoc = tipo_doc.Buscar_nombreTipoDocumento();
            for (int i = 0; i < tabla_cmb_tipodoc.Rows.Count; i++)
            {
                cb_tipoDoc.Items.Add(tabla_cmb_tipodoc.Rows[i]["nombre"]);
            }

            Ne_Cliente cliente_cmb = new Ne_Cliente();
            DataTable tabla_cmb = new DataTable();
            tabla_cmb = cliente_cmb.BuscarCuils();
            for (int i = 0; i < tabla_cmb.Rows.Count; i++)
            {
                cmb_cuil.Items.Add(tabla_cmb.Rows[i]["cuil_cliente"]);
            }
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            if (cmb_cuil.Text == "") 
            {
                MessageBox.Show("No se ha seleccionado un cuil");
                return;
            }

            else 
            {
                Ne_Cliente cliente_mod = new Ne_Cliente();
                DataTable tabla_mod = new DataTable();
                tabla_mod = cliente_mod.BuscarClienteModificacion(cmb_cuil.Text);
                txt_Razon.Text = tabla_mod.Rows[0]["razon_social"].ToString();
                txt_NumDoc.Text = tabla_mod.Rows[0]["nro_documento"].ToString();
                cb_tipoDoc.Text = tabla_mod.Rows[0]["nombre"].ToString();
                txt_calle.Text = tabla_mod.Rows[0]["calle"].ToString();
                txt_numdir.Text = tabla_mod.Rows[0]["numero"].ToString();
                txt_piso.Text = tabla_mod.Rows[0]["piso"].ToString();
                txt_Depto.Text = tabla_mod.Rows[0]["depto"].ToString();
                txt_barrio.Text = tabla_mod.Rows[0]["nombre_barrio"].ToString();                
                txt_loc.Text = tabla_mod.Rows[0]["nombre_localidad"].ToString();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( cmb_cuil.Text == "") 
            {
                MessageBox.Show("No se ha seleccionado un cuil");
                return;
            }

            else 
            {
                Ne_Cliente clien_mod = new Ne_Cliente();
                Ne_Direccion dir = new Ne_Direccion();
                string id_direc = dir.Buscar_id_direccion_cliente(cmb_cuil.Text).ToString();
                Ne_Barrio bar = new Ne_Barrio();
                string id_barrio = bar.Buscar_idBarrio(txt_barrio.Text).ToString();
                Ne_TIpoDocumento tipodoc = new Ne_TIpoDocumento();
                string id_tipodocu = tipodoc.Buscar_idTipoDoc(cb_tipoDoc.Text).ToString();
                clien_mod.modificar_ClienteDefinitivo(cmb_cuil.Text, txt_Razon.Text, id_tipodocu, txt_NumDoc.Text,
                    id_direc, txt_calle.Text, txt_numdir.Text, txt_Depto.Text, txt_piso.Text,id_barrio );
                this.Close();
            }
        }
    }
}
