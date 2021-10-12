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
    public partial class Frm_Reg_Telefono_Sucursal : Form
    {
        public Frm_Reg_Telefono_Sucursal()
        {
            InitializeComponent();
        }

        private void txt_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void Frm_Reg_Telefono_Sucursal_Load(object sender, EventArgs e)
        {
            Ne_Sucursal llenar_cmb = new Ne_Sucursal();
            DataTable datos = llenar_cmb.Buscar_tipo_tel();
            for(int i=0; i< datos.Rows.Count; i++) 
            {
                cmb_tipotel.Items.Add(datos.Rows[i]["nombre"].ToString());
            }
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Ne_Sucursal reg_tel = new Ne_Sucursal();
            if (txt_num.Text == "")
            {
                MessageBox.Show("Ingrese un numero antes de continuar");
                return;
            }

            if (reg_tel.Buscar_telefono_existente(txt_num.Text, txt_id.Text)) 
            {
                MessageBox.Show("Telefono ya registrado, intente con otro");
                return;

            }

            if (cmb_tipotel.Text == "") 
            {
                MessageBox.Show("Seleccione un tipo telefono antes de continuar");
                return;
            }
            else 
            {
              
                reg_tel.Registrar_Telefono(txt_num.Text, reg_tel.Buscar_id_tipotel(cmb_tipotel.Text), txt_id.Text);
                MessageBox.Show("Registro exitoso");
                this.Close();

            }
        }
    }
}
