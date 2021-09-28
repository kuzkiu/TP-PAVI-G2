using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3K3_GRUPO2.Negocio;

namespace TP_PAV_3K3_GRUPO2.Formularios.Clientes
{
    public partial class Frm_EliminarTelefonoCliente : Form
    {
        public Frm_EliminarTelefonoCliente()
        {
            InitializeComponent();
        }

        private void Frm_EliminarTelefonoCliente_Load(object sender, EventArgs e)
        {
            Ne_Cliente cliente_bajatel = new Ne_Cliente();
            DataTable tabla_bajatel = new DataTable();
            tabla_bajatel = cliente_bajatel.Buscar_TelefonoCliente(txt_cuil.Text);
            for(int i=0; i< tabla_bajatel.Rows.Count; i++) 
            {
                cmb_numtel.Items.Add(tabla_bajatel.Rows[i]["numero_telefono"].ToString());
            }
        }

        private void cmb_numtel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //string mostrar = cmb_numtel.Text;
            //MessageBox.Show(mostrar);
            //Ne_Cliente cliente1 = new Ne_Cliente();
            //DataTable tabla1 = new DataTable();
            //tabla1 = cliente1.Buscar_TipoTelBajaTel(mostrar);
            //txt_tipotel.Enabled = true;
            //MessageBox.Show(tabla1.ToString());
            //txt_tipotel.Text = tabla1.Rows[0]["nombre"].ToString();
            //txt_tipotel.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_numtel.Text == "") 
            {
                MessageBox.Show("No se ha seleccionado un numero para eliminar");
                return;
            }

            else 
            {
                Ne_Cliente baja_telefono = new Ne_Cliente();
                baja_telefono.Eliminar_telefono(cmb_numtel.Text);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mostrar = cmb_numtel.Text;
            MessageBox.Show(mostrar);
            Ne_Cliente cliente1 = new Ne_Cliente();
            DataTable tabla1 = new DataTable();
            tabla1 = cliente1.Buscar_TipoTelBajaTel(mostrar);
            txt_tipotel.Enabled = true;
            MessageBox.Show(tabla1.ToString());
            txt_tipotel.Text = tabla1.Rows[0]["nombre"].ToString();
            txt_tipotel.Enabled = false;
        }

        private void cmb_numtel_SelectedValueChanged(object sender, EventArgs e)
        {
            string mostrar = cmb_numtel.Text;
            Ne_Cliente cliente1 = new Ne_Cliente();
            DataTable tabla1 = new DataTable();
            tabla1 = cliente1.Buscar_TipoTelBajaTel(mostrar);
            txt_tipotel.Enabled = true;
            txt_tipotel.Text = tabla1.Rows[0]["nombre"].ToString();
            txt_tipotel.Enabled = false;
        }
    }
}
