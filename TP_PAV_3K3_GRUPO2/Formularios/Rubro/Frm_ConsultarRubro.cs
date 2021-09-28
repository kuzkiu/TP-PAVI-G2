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

namespace TP_PAV_3K3_GRUPO2.Formularios.Rubro
{
    public partial class Frm_ConsultarRubro : Form
    {

        private String rubroId
        {
            get { return txt_idrubro.Text; }
            set { txt_idrubro.Text = value; }
        }

        private String rubroNombre
        {
            get { return txt_nombrerubro.Text; }
            set { txt_nombrerubro.Text = value; }
        }


        public Frm_ConsultarRubro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NE_Rubro rubro = new NE_Rubro();
            DataTable tabla = new DataTable();
            tabla = rubro.BuscarRubro(txt_idrubro.Text, txt_nombrerubro.Text);
            Cargar_Datos(tabla);
        }

        public void Cargar_Datos(DataTable tabla)
        {
            DGV_Rubro.DataSource = tabla;
        }
    }
}
