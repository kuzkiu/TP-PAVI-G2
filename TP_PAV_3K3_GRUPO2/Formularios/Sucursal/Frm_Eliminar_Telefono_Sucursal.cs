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
    public partial class Frm_Eliminar_Telefono_Sucursal : Form
    {
        public Frm_Eliminar_Telefono_Sucursal()
        {
            InitializeComponent();
        }

        private void Frm_Eliminar_Telefono_Sucursal_Load(object sender, EventArgs e)
        {
            Ne_Sucursal cargar_tels = new Ne_Sucursal();
            DataTable cargar_cmb = cargar_tels.Buscar_telefonos(txt_idsede.Text);
            for(int i=0; i<cargar_cmb.Rows.Count; i++) 
            {
                cmb_numtel.Items.Add(cargar_cmb.Rows[i]["numero_telefono"].ToString());
            }
        }

        private void cmb_numtel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ne_Sucursal buscar_tipo = new Ne_Sucursal();
            txt_tipotel.Text = buscar_tipo.Buscar_tipotel_telefono(cmb_numtel.Text);
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (cmb_numtel.Text == "") 
            {
                MessageBox.Show("Seleccione un numero a eliminar antes de continuar");
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Quiere dar de baja el numero seleccionado?", "Eliminando numero", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes) 
            {
                Ne_Sucursal baja_tel = new Ne_Sucursal();
                baja_tel.Eliminar_Telefono(cmb_numtel.Text);
                cmb_numtel.Items.Clear();
                txt_tipotel.Text = "";
                DataTable cargar_cmb = baja_tel.Buscar_telefonos(txt_idsede.Text);
                for (int i = 0; i < cargar_cmb.Rows.Count; i++)
                {
                    cmb_numtel.Items.Add(cargar_cmb.Rows[i]["numero_telefono"].ToString());
                }
                this.Close();

            }
        }
    }
}
