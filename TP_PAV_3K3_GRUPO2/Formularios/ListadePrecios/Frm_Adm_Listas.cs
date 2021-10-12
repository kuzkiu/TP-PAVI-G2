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

namespace TP_PAV_3K3_GRUPO2.Formularios.ListadePrecios
{
    public partial class Frm_Consultar_Listas : Form
    {
        public Frm_Consultar_Listas()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
        
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            dgw_listas.ClearSelection();
            Ne_Lista_de_Precios validaciones = new Ne_Lista_de_Precios();
            DataTable tabla_cargar = new DataTable();
            bool existe = false;

            if(chb_habilitar_inicio.Checked==  false)
            {
                tabla_cargar = validaciones.Buscar_Listas(txt_cuil.Text, "", chk_activas.Checked);
            }
            else
            {
                tabla_cargar = validaciones.Buscar_Listas(txt_cuil.Text, dtp_inicio.Text, chk_activas.Checked);
            }

            dgw_listas.DataSource = tabla_cargar;



        }

        private void chb_fecha_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Frm_Consultar_Listas_Load(object sender, EventArgs e)
        {
            dtp_inicio.MaxDate = DateTime.Today;
        }

        private void dgw_listas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgw_listas_DoubleClick(object sender, EventArgs e)
        {
            dgw_detalle.ClearSelection();
            Ne_Lista_de_Precios cargar_detalle = new Ne_Lista_de_Precios();
            DataTable detalle = cargar_detalle.Buscar_ArticulosLista_Adm(dgw_listas.CurrentRow.Cells[1].Value.ToString()) ;
            dgw_detalle.DataSource = detalle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Registrar_Lista reg_lista = new Frm_Registrar_Lista();
            reg_lista.ShowDialog();
            reg_lista.Dispose();
        }

        private void chb_habilitar_inicio_CheckedChanged(object sender, EventArgs e)
        { 
            if (dtp_inicio.Enabled == false)
            {
                dtp_inicio.Enabled = true;
            }
            else
            {
                dtp_inicio.Enabled = false;
            }
        }
    }
}
