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
    public partial class Frm_Adm_Telefono_Sucursal : Form
    {
        public Frm_Adm_Telefono_Sucursal()
        {
            InitializeComponent();
        }

        private void Frm_Adm_Telefono_Sucursal_Load(object sender, EventArgs e)
        {
            Ne_Sucursal telefonos = new Ne_Sucursal();
            DataTable tabla_tel = telefonos.Buscar_telefonos(txt_id.Text);
            dgv_telefonos.DataSource = tabla_tel;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Ne_Sucursal telefonos = new Ne_Sucursal();
            DataTable tabla_tel = telefonos.Buscar_telefonos(txt_id.Text);
            dgv_telefonos.DataSource = tabla_tel;
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Frm_Reg_Telefono_Sucursal reg_tel = new Frm_Reg_Telefono_Sucursal();
            reg_tel.txt_id.Text = txt_id.Text;
            reg_tel.ShowDialog();
            reg_tel.Dispose();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Frm_Modificar_Telefono_Sucursal mod_tel = new Frm_Modificar_Telefono_Sucursal();
            mod_tel.txt_idsede.Text = this.txt_id.Text;
            mod_tel.ShowDialog();
            mod_tel.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_Eliminar_Telefono_Sucursal baja_tel = new Frm_Eliminar_Telefono_Sucursal();
            baja_tel.txt_idsede.Text = txt_id.Text;
            baja_tel.ShowDialog();
            baja_tel.Dispose();
        }
    }
}
