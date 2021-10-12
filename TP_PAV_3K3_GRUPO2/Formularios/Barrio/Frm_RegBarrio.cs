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
    public partial class Frm_RegBarrio : Form
    {
        public Frm_RegBarrio()
        {
            InitializeComponent();
        }

        private void Frm_RegBarrio_Load(object sender, EventArgs e)
        {
            Negocios.NE_Barrio combo_localidad = new Negocios.NE_Barrio();
            DataTable tabla_cmb_localidad = new DataTable();
            tabla_cmb_localidad = combo_localidad.Buscar_Localidad();
            for (int i = 0; i < tabla_cmb_localidad.Rows.Count; i++)
            {
                cb_localidadB.Items.Add(tabla_cmb_localidad.Rows[i]["nombre_localidad"]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_localidadB.Text == "")
            {
                MessageBox.Show("Debes elegir una localidad primero");
                cb_localidadB.Focus();
            }
            if (txt_nombrebarrio.Text == "")
            {
                MessageBox.Show("Debes elegir el nombre del barrio");
                txt_nombrebarrio.Focus();
            }
            if (txt_idbarrio.Text == "") 
            {
                MessageBox.Show("Debes elegir un id de barrio");
                txt_idbarrio.Focus();
            }
            if(txt_idbarrio.Text != "")
            {
                Negocios.NE_Barrio id_barrioB = new Negocios.NE_Barrio();
                DataTable id_barrio= new DataTable();
                id_barrio = id_barrioB.BuscarIds();
                for (int i = 0; i < id_barrio.Rows.Count; i++)
                {
                    if (id_barrio.Rows[i]["id_barrio"].ToString() == txt_idbarrio.Text)
                    {
                        MessageBox.Show("El iD del barrio ya existe. Ingrese otro");
                        return;
                    }
                }
            }
            Negocios.NE_Barrio localidad = new Negocios.NE_Barrio();
            string id_localidad = localidad.Buscar_idLocalidad(cb_localidadB.Text).ToString();

            Negocios.NE_Barrio barrio = new Negocios.NE_Barrio();
            barrio.RegistrarBarrio(id_localidad, txt_idbarrio.Text, txt_nombrebarrio.Text);
            MessageBox.Show("El barrio '"+txt_nombrebarrio.Text  +"' ha sido cargado con éxito");



        }

        private void txt_idbarrio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_idbarrio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }
    }
}
