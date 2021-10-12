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

namespace TP_PAV_3K3_GRUPO2.Formularios.Sucursal
{
    public partial class Frm_BajaSucursal : Form
    {
        public Frm_BajaSucursal()
        {
            InitializeComponent();
        }

        private void Frm_BajaSucursal_Load(object sender, EventArgs e)
        {
            Ne_Sucursal buscar = new Ne_Sucursal();
            DataTable tablacuils = buscar.Buscar_sedes();
            for (int i=0; i<tablacuils.Rows.Count; i++) 
            {
                cmb_cuil.Items.Add(tablacuils.Rows[i][0].ToString());
            }
        }

        private void cmb_cuil_SelectedValueChanged(object sender, EventArgs e)
        {
            Ne_Sucursal buscar_sede_baja = new Ne_Sucursal();
            DataTable datos_tabla = buscar_sede_baja.Buscar_datos_sede(cmb_cuil.Text);
            txt_Descripcion.Text = datos_tabla.Rows[0]["descripcion"].ToString();
            txt_calle.Text = datos_tabla.Rows[0]["calle"].ToString();
            txt_numero.Text = datos_tabla.Rows[0]["numero"].ToString();
            txt_piso.Text = datos_tabla.Rows[0]["piso"].ToString();
            txt_depto.Text = datos_tabla.Rows[0]["depto"].ToString();
            txt_Barrio.Text = datos_tabla.Rows[0]["nombre_barrio"].ToString(); 
            txt_Localidad.Text = datos_tabla.Rows[0]["nombre_Localidad"].ToString(); 

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (cmb_cuil.Text=="") 
            {
                MessageBox.Show("Seleccione un id a seleccionar antes de continuar");
                return;
            }

            else 
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro desea borrar la sede seleccionada?","Eliminando Sede" ,MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes) 
                {
                    Ne_Sucursal baja_sucursal = new Ne_Sucursal();
                    string id_direc = baja_sucursal.Buscar_iddirec_sucursal(cmb_cuil.Text);
                    baja_sucursal.Baja_sucursal(cmb_cuil.Text, id_direc);
                    MessageBox.Show("Baja exitosa");
                    this.Close();
                }

                if(dialogResult ==DialogResult.No)
                {
                    return;
                }
            }
        }
    }
}
