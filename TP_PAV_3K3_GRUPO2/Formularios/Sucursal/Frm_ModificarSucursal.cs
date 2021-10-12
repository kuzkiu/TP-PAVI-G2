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

namespace TP_PAV_3K3_GRUPO2.Formularios.Sucursal
{
    public partial class Frm_ModificarSucursal : Form
    {
        public Frm_ModificarSucursal()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_ModificarSucursal_Load(object sender, EventArgs e)
        {
            Ne_Sucursal buscar_id = new Ne_Sucursal();
            DataTable cuils = buscar_id.Buscar_sedes();
            for (int i = 0; i < cuils.Rows.Count; i++)
            {
                cmb_idsede.Items.Add(cuils.Rows[i]["id_sucursal"].ToString());
            }
            DataTable localidades = buscar_id.Buscar_Localidad_cmb();

            for (int j = 0; j<localidades.Rows.Count; j++) 
            {
                cmb_Localidad.Items.Add(localidades.Rows[j]["nombre_localidad"].ToString());
            }
        }

        private void cmb_idsede_SelectedValueChanged(object sender, EventArgs e)
        {
            Ne_Sucursal buscar_datos = new Ne_Sucursal();
            DataTable datos = buscar_datos.Buscar_datos_sede(cmb_idsede.Text);
            txt_descripcion.Enabled = true;
            txt_descripcion.Text = datos.Rows[0]["descripcion"].ToString();
            txt_calle.Enabled = true;
            txt_calle.Text = datos.Rows[0]["calle"].ToString();
            txt_numero.Enabled = true;
            txt_numero.Text = datos.Rows[0]["numero"].ToString();
            txt_piso.Enabled = true;
            txt_piso.Text = datos.Rows[0]["piso"].ToString();
            txt_depto.Enabled = true;
            txt_depto.Text = datos.Rows[0]["depto"].ToString();
            cmb_Localidad.Enabled = true;
            cmb_Localidad.Text = datos.Rows[0]["nombre_localidad"].ToString();
            cmb_barrio.Enabled = true;
            cmb_barrio.Text = datos.Rows[0]["nombre_barrio"].ToString();
            btn_telefonos.Enabled = true;

        }

        private void cmb_Localidad_SelectedValueChanged(object sender, EventArgs e)
        {
            cmb_barrio.Items.Clear();
            Ne_Sucursal buscar_barrios = new Ne_Sucursal();
            DataTable barrio = buscar_barrios.Buscar_Barrios_cmb(cmb_Localidad.Text);
            for (int i=0; i<barrio.Rows.Count; i++) 
            {
                cmb_barrio.Items.Add(barrio.Rows[i]["nombre_barrio"].ToString());
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (cmb_idsede.Text == "") 
            {
                MessageBox.Show("Seleccione una sucursald antes de continuar");
                return;
            }
            if (txt_descripcion.Text == "")
            {
                MessageBox.Show("Cargue una descripcion antes de continuar");
                return;
            }

            if (txt_calle.Text == "")
            {
                MessageBox.Show("Ingrese una calle antes de continuar");
                return;
            }

            if (txt_numero.Text == "")
            {
                MessageBox.Show("Ingrese un numero de calle antes de continuar");
                return;
            }

            if ((txt_depto.Text != "" && txt_piso.Text == "") || (txt_depto.Text == "" && txt_piso.Text != ""))
            {
                MessageBox.Show("Depto y piso deben estar llenos o vacios simultaneamente");
                return;
            }

            if (cmb_Localidad.Text == "")
            {
                MessageBox.Show("Seleccione una localidad antes de continuar");
                return;
            }

            if (cmb_barrio.Text == "")
            {
                MessageBox.Show("Seleccione un barrio antes de continuar");
                return;
            }

            else
            {
                DialogResult resultado = MessageBox.Show("¿Desea guardas los cambios?", "Cambiando sede", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes) 
                {
                    Ne_Sucursal mod_sucursal = new Ne_Sucursal();
                    string id_viejo = mod_sucursal.Buscar_iddirec_sucursal(cmb_idsede.Text);
                    string id_nuevo = mod_sucursal.Buscar_id_direccion();
                    string id_barrio = mod_sucursal.Buscar_id_barrio(cmb_barrio.Text, cmb_Localidad.Text);
                    mod_sucursal.Modificar_sucursal(id_viejo, id_nuevo, id_barrio, txt_calle.Text, txt_numero.Text,
                            txt_piso.Text, txt_depto.Text, cmb_idsede.Text);
                    MessageBox.Show("Modificacion Exitosa");
                }
                else 
                { return; }
             
            }

        }

        private void txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void txt_piso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void txt_depto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
        }

        private void btn_telefonos_Click(object sender, EventArgs e)
        {
            Frm_Adm_Telefono_Sucursal tel_suc = new Frm_Adm_Telefono_Sucursal();
            tel_suc.txt_id.Text = cmb_idsede.Text;
            tel_suc.ShowDialog();
            tel_suc.Dispose();
        }
    }
}
