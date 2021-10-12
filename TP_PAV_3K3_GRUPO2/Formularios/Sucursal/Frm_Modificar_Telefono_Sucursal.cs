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
    public partial class Frm_Modificar_Telefono_Sucursal : Form
    {
        public Frm_Modificar_Telefono_Sucursal()
        {
            InitializeComponent();
        }

        private void Frm_Modificar_Telefono_Sucursal_Load(object sender, EventArgs e)
        {
            Ne_Sucursal load_form = new Ne_Sucursal();
            DataTable tabla_tipos = load_form.Buscar_tipo_tel();
            for(int i=0; i< tabla_tipos.Rows.Count; i++) 
            {
                cmb_tipotel.Items.Add(tabla_tipos.Rows[i]["nombre"].ToString());
            }

            DataTable tabla_num = load_form.Buscar_telefonos(txt_idsede.Text);
            for (int j=0; j<tabla_num.Rows.Count; j++) 
            {
                cmb_telefono.Items.Add(tabla_num.Rows[j]["numero_telefono"].ToString());
            }
        }

        private void cmb_telefono_SelectedValueChanged(object sender, EventArgs e)
        {
            Ne_Sucursal tipotel = new Ne_Sucursal();
            txt_numnuevo.Text = cmb_telefono.Text;
            cmb_tipotel.Text = tipotel.Buscar_tipotel_telefono(cmb_telefono.Text);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Ne_Sucursal mod_tel = new Ne_Sucursal();
            if (cmb_telefono.Text == "") 
            {
                MessageBox.Show("Seleccione un numero que queira cambiar antes de continuar");
                return;
            }
            if (txt_numnuevo.Text == "")
            {
                MessageBox.Show("Escriba un nuevo numero antes de continuar");
                return;
            }

            if (mod_tel.Buscar_telefono_existente(txt_numnuevo.Text, txt_idsede.Text)) 
            {
                MessageBox.Show("El numero ingresado ya esta registrado.");
                return;
            }

            if (cmb_tipotel.Text=="") 
            {
                MessageBox.Show("Seleccione un nuevo tipo telefono antes de continuar");
                return;
            }

            mod_tel.Modificar_telefono(txt_numnuevo.Text, mod_tel.Buscar_id_tipotel(cmb_tipotel.Text), cmb_telefono.Text);
            MessageBox.Show("Modificacion existosa");
            this.Close();
        }
    }
}
