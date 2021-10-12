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
    public partial class Frm_Registrar_Sucursal : Form
    {
        public Frm_Registrar_Sucursal()
        {
            InitializeComponent();
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void txt_numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_depto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "") 
            {
                MessageBox.Show("Cargue un ID antes de continuar");
                return;
            }

            else 
            {
                Ne_Sucursal verificar_id_existente = new Ne_Sucursal();
                if (verificar_id_existente.Buscar_id_existente(txt_id.Text)) 
                {
                    MessageBox.Show("Ese id ya existe. Ingrese otro \n"+
                                    "Sugerencia: "+ verificar_id_existente.Sugerir_id());
                    return;
                }

            }

            if(txt_Descripcion.Text == "") 
            {
                MessageBox.Show("Cargue una descripcion antes de continuar");
                return;
            }

            if((txt_numtel.Text=="" && cmb_tipotel.Text!="") || (txt_numtel.Text != "" && cmb_tipotel.Text == "")) 
            {
                MessageBox.Show("Numero de telefono y tipo telefono deben estar llenos o vacios simultaneamente");
                return;
            }

            if(txt_calle.Text == "") 
            {
                MessageBox.Show("Ingrese una calle antes de continuar");
                return;
            }

            if (txt_numero.Text == "")
            {
                MessageBox.Show("Ingrese un numero de calle antes de continuar");
                return;
            }

            if((txt_depto.Text !="" && txt_piso.Text=="") || (txt_depto.Text == "" && txt_piso.Text != "")) 
            {
                MessageBox.Show("Depto y piso deben estar llenos o vacios simultaneamente");
                return;
            }

            if(cmb_Localidad.Text == "") 
            {
                MessageBox.Show("Seleccione una localidad antes de continuar");
                return;
            }

            if(cmb_Barrio.Text == "") 
            {
                MessageBox.Show("Seleccione un barrio antes de continuar");
                return;
            }

            else 
            {

                Ne_Sucursal reg_sucursal = new Ne_Sucursal();
                string id_direc = reg_sucursal.Buscar_id_direccion();
                string id_barrio = reg_sucursal.Buscar_id_barrio(cmb_Barrio.Text, cmb_Localidad.Text);
                string id_tipo_tel = "";
                if (txt_numtel.Text != "") 
                {
                    id_tipo_tel = reg_sucursal.Buscar_id_tipotel(cmb_tipotel.Text);
                }
                reg_sucursal.Registrar_Sede(id_direc, id_barrio, txt_calle.Text, txt_numero.Text, txt_piso.Text,
                    txt_depto.Text, txt_id.Text, txt_Descripcion.Text, txt_numtel.Text, id_tipo_tel);

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

        private void Frm_Registrar_Sucursal_Load(object sender, EventArgs e)
        {
            Ne_Sucursal cargar_localidades = new Ne_Sucursal();
            DataTable tabla_loc = cargar_localidades.Buscar_Localidad_cmb();
            for(int i=0; i< tabla_loc.Rows.Count; i++) 
            {
                cmb_Localidad.Items.Add(tabla_loc.Rows[i]["nombre_localidad"].ToString());
            }
            DataTable tabla_tipotel = cargar_localidades.Buscar_tipo_tel();
            for (int j=0; j< tabla_tipotel.Rows.Count; j++) 
            {
                cmb_tipotel.Items.Add(tabla_tipotel.Rows[j]["nombre"].ToString());
            }
        }

        private void cmb_Localidad_SelectedValueChanged(object sender, EventArgs e)
        {
            cmb_Barrio.Enabled = true;
            cmb_Barrio.Items.Clear();
            Ne_Sucursal cargar_barrio = new Ne_Sucursal();
            DataTable tabla_barrio = cargar_barrio.Buscar_Barrios_cmb(cmb_Localidad.Text);
            for (int i = 0; i < tabla_barrio.Rows.Count; i++)
            {
                cmb_Barrio.Items.Add(tabla_barrio.Rows[i]["nombre_barrio"].ToString());
            }
        }
    }
}
