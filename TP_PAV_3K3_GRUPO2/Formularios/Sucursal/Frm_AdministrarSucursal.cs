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
using System.Data;
using TP_PAV_3K3_GRUPO2.Clases;

namespace TP_PAV_3K3_GRUPO2.Formularios.Sucursal
{
    public partial class Frm_AdministrarSucursal : Form
    {
        public Frm_AdministrarSucursal()
        {
            InitializeComponent();
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            Ne_Sucursal consulta = new Ne_Sucursal();
            DataTable tabla_consulta = consulta.Buscar_Sucursal_Consulta(txt_id.Text, txt_descripcion.Text);
            dgv_sucursales.DataSource = tabla_consulta;
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Frm_Registrar_Sucursal reg_sucursal = new Frm_Registrar_Sucursal();
            reg_sucursal.ShowDialog();
            reg_sucursal.Dispose();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Frm_BajaSucursal baja_sucursal = new Frm_BajaSucursal();
            baja_sucursal.ShowDialog();
            baja_sucursal.Dispose();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Frm_ModificarSucursal mod_sucursal = new Frm_ModificarSucursal();
            mod_sucursal.ShowDialog();
            mod_sucursal.Dispose();
        }
    }
}
