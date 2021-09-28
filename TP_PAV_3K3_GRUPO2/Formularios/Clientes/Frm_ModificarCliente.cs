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
            Ne_Cliente tipo_doc = new Ne_Cliente();
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
                cmb_barrio.Text = tabla_mod.Rows[0]["nombre_barrio"].ToString();                
                cmb_localidad.Text = tabla_mod.Rows[0]["nombre_localidad"].ToString();
                
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
                Ne_Cliente dir = new Ne_Cliente();
                string id_direc = dir.Buscar_id_direccion_cliente(cmb_cuil.Text).ToString();
                Ne_Cliente bar = new Ne_Cliente();
                string id_barrio = bar.Buscar_idBarrio(cmb_barrio.Text).ToString();
                Ne_Cliente tipodoc = new Ne_Cliente();
                string id_tipodocu = tipodoc.Buscar_idTipoDoc(cb_tipoDoc.Text).ToString();
                clien_mod.modificar_ClienteDefinitivo(cmb_cuil.Text, txt_Razon.Text, id_tipodocu, txt_NumDoc.Text,
                    id_direc, txt_calle.Text, txt_numdir.Text, txt_Depto.Text, txt_piso.Text,id_barrio );
                this.Close();
            }
        }

        private void cmb_localidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_barrio.Items.Clear();
            cmb_barrio.Enabled = true;
            Ne_Cliente barrio = new Ne_Cliente();
            DataTable tabla_barrio = new DataTable();
            tabla_barrio = barrio.Buscar_NombreBarrio(cmb_localidad.Text);
            for (int i = 0; i < tabla_barrio.Rows.Count; i++)
            {
                cmb_barrio.Items.Add(tabla_barrio.Rows[i]["nombre_barrio"]);
            }

        }

        private void cmb_cuil_SelectionChangeCommitted(object sender, EventArgs e)
        {

            Ne_Cliente cliente_mod = new Ne_Cliente();
            DataTable tabla_mod = new DataTable();
            tabla_mod = cliente_mod.BuscarClienteModificacion(cmb_cuil.Text);
            txt_Razon.Enabled = true;
            txt_Razon.Text = tabla_mod.Rows[0]["razon_social"].ToString();
            txt_NumDoc.Enabled = true;
            txt_NumDoc.Text = tabla_mod.Rows[0]["nro_documento"].ToString();
            cb_tipoDoc.Enabled = true;
            cb_tipoDoc.Text = tabla_mod.Rows[0]["nombre"].ToString();
            txt_calle.Enabled = true;
            txt_calle.Text = tabla_mod.Rows[0]["calle"].ToString();
            txt_numdir.Enabled = true;
            txt_numdir.Text = tabla_mod.Rows[0]["numero"].ToString();
            txt_piso.Enabled = true;
            txt_piso.Text = tabla_mod.Rows[0]["piso"].ToString();
            txt_Depto.Enabled = true;
            txt_Depto.Text = tabla_mod.Rows[0]["depto"].ToString();
            cmb_localidad.Enabled = true;

            Ne_Cliente combo_localidad = new Ne_Cliente();
            DataTable tabla_cmb_localidad = new DataTable();
            tabla_cmb_localidad = combo_localidad.Buscar_Localidad();
            for (int i = 0; i < tabla_cmb_localidad.Rows.Count; i++)
            {
                cmb_localidad.Items.Add(tabla_cmb_localidad.Rows[i]["nombre_localidad"]);
            }
            cmb_localidad.Text = tabla_mod.Rows[0]["nombre_localidad"].ToString();
            cmb_barrio.Enabled = true;
            cmb_barrio.Items.Clear();
            Ne_Cliente barrio = new Ne_Cliente();
            DataTable tabla_barrio = new DataTable();
            tabla_barrio = barrio.Buscar_NombreBarrio(cmb_localidad.Text);
            for (int i = 0; i < tabla_barrio.Rows.Count; i++)
            {
                cmb_barrio.Items.Add(tabla_barrio.Rows[i]["nombre_barrio"]);
            }
            cmb_barrio.Text = tabla_mod.Rows[0]["nombre_barrio"].ToString();

            btn_telefono.Enabled = true;
   
        }

        private void btn_telefono_Click(object sender, EventArgs e)
        {
            Frm_AdmTelefonoCliente adm_tel = new Frm_AdmTelefonoCliente();
            adm_tel.txt_cuil.Text = this.cmb_cuil.Text;
            Ne_Cliente cliente = new Ne_Cliente();
            DataTable tabla_tel = new DataTable();
            tabla_tel = cliente.Buscar_TelefonoCliente(adm_tel.txt_cuil.Text);
            adm_tel.dgv_telefonocliente.DataSource = tabla_tel;
            adm_tel.ShowDialog();
            adm_tel.Dispose();
        }
    }
}
