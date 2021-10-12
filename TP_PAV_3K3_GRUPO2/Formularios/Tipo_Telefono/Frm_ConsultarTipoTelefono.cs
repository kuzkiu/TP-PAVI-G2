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

namespace TP_PAV_3K3_GRUPO2.Formularios.Tipo_Telefono
{
    public partial class Frm_ConsultarTipoTelefono : Form
    {

        private String _idtipotel_
        {
            get { return txt_id_tipo_telefono.Text; }
            set { txt_id_tipo_telefono.Text = value; }
        }

        private String _nombretipotel_
        {
            get { return txt_nombre_tipo_tel.Text; }
            set { txt_nombre_tipo_tel.Text = value; }
        }

        public Frm_ConsultarTipoTelefono()
        {
            InitializeComponent();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            NE_TipoTelefono tipotel = new NE_TipoTelefono();
            DataTable tabla = new DataTable();
            tabla = tipotel.BuscarTipoTelefono(txt_id_tipo_telefono.Text, txt_nombre_tipo_tel.Text);
            Cargar_Datos(tabla);
        }

        public void Cargar_Datos(DataTable tabla)
        {
            DGV_TipoTel_consulta.DataSource = tabla;
        }

    }
}
