using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV_3K3_GRUPO2.Formularios.Barrio
{
    public partial class Frm_ConsultarBarrio : Form
    {
        public Frm_ConsultarBarrio()
        {
            InitializeComponent();
        }

        private void Frm_ConsultarBarrio_Load(object sender, EventArgs e)
        {

        }

        private void txt_idbarrio_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Negocios.NE_Barrio barrio = new Negocios.NE_Barrio();
            
            DataTable tabla = new DataTable();

            tabla = barrio.Buscar_barrio(txt_idbarrio.Text, txt_nombreBarrio.Text);


            Cargar_Datos(tabla);
        }
        public void Cargar_Datos(DataTable tabla)
        {
            Data_Barrio.DataSource = tabla;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_nombreBarrio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
