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
    public partial class Frm_ModificarBarrio : Form
    {
        public Frm_ModificarBarrio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ModificarBarrio_Load(object sender, EventArgs e)
        {
            Negocios.NE_Barrio combo_localidad = new Negocios.NE_Barrio();
            DataTable tabla_cmb_localidad = new DataTable();
            tabla_cmb_localidad = combo_localidad.Buscar_Localidad();
            for (int i = 0; i < tabla_cmb_localidad.Rows.Count; i++)
            {
                cb_localidadB.Items.Add(tabla_cmb_localidad.Rows[i]["nombre_localidad"]);
            }
            Negocios.NE_Barrio combo_idBarrio = new Negocios.NE_Barrio();
            DataTable tabla_cmb_idBarrio = new DataTable();
            tabla_cmb_idBarrio = combo_idBarrio.BuscarIds();
            for (int i = 0; i < tabla_cmb_idBarrio.Rows.Count; i++)
            {
                cb_idbarrio.Items.Add(tabla_cmb_idBarrio.Rows[i]["id_barrio"]);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_idbarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Negocios.NE_Barrio barrio_mod = new Negocios.NE_Barrio();
            DataTable tabla_mod = new DataTable();
            tabla_mod = barrio_mod.BuscarBarrioModificacion(cb_idbarrio.Text);
            txt_nombreB.Enabled = true;
            txt_nombreB.Text = tabla_mod.Rows[0]["nombre_barrio"].ToString();
            cb_localidadB.Text = tabla_mod.Rows[0]["nombre_localidad"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Negocios.NE_Barrio barrio_mod = new Negocios.NE_Barrio();
            Negocios.NE_Barrio localidad = new Negocios.NE_Barrio();
            string id_localidad = localidad.Buscar_idLocalidad(cb_localidadB.Text).ToString();
            barrio_mod.modificar_barrio(cb_idbarrio.Text, txt_nombreB.Text, id_localidad);
            MessageBox.Show("El barrio se ha modificado con éxito");
            this.Close();
        }
    }
}
