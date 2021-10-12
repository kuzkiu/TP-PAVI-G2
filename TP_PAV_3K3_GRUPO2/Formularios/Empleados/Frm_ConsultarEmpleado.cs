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
using TP_PAV_3K3_GRUPO2.Clases;
namespace TP_PAV_3K3_GRUPO2.Formularios.Empleados
{
    public partial class Frm_ConsultarEmpleado : Form
    {
        public String TipoDoc_E
        {
            get { return cb_tipoDocE.Text; }
            set { cb_tipoDocE.Text = value; }
        }
        public String NroDocumento_E
        {
            get { return txt_DocumentoE.Text; }
            set { txt_DocumentoE.Text = value; }
        }
        public Frm_ConsultarEmpleado()
        {
            InitializeComponent();
        }

        private void label_Text1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ConsultarEmpleado_Load(object sender, EventArgs e)
        {
                Negocios.NE_Empleados tipo_doc = new Negocios.NE_Empleados();
                DataTable tabla_cmb_tipodoc = new DataTable();
                tabla_cmb_tipodoc = tipo_doc.Buscar_nombreTipoDocumento();
                for (int i = 0; i < tabla_cmb_tipodoc.Rows.Count; i++)
                {

                    //MessageBox.Show(tabla_cmb_tipodoc.Rows[i]["nombre"].ToString());
                    cb_tipoDocE.Items.Add(tabla_cmb_tipodoc.Rows[i]["nombre"]);
                }
                /*
                Ne_Cliente tipotel = new Ne_Cliente();
                DataTable tabla_cmb_tipotel = new DataTable();
                tabla_cmb_tipotel = tipotel.Buscar_nombreTipoTel();
                for (int i = 0; i < tabla_cmb_tipotel.Rows.Count; i++)
                {
                    cb_TipoTelE.Items.Add(tabla_cmb_tipotel.Rows[i]["nombre"]);
                }*/
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.cb_tipoDocE.Text == "")
            {
                MessageBox.Show("No ha seleccionado ningún documento");
                this.cb_tipoDocE.Focus();
                return;
            }
            if (this.txt_DocumentoE.Text == "")
            {
                MessageBox.Show("No ha ingresado ningún Documento");
                this.txt_DocumentoE.Focus();
                return;
            }
            NE_Empleados empleado = new NE_Empleados();
            Negocios.NE_Empleados tipodoc = new Negocios.NE_Empleados();
            string id_tipodocu = tipodoc.Buscar_idTipoDoc(TipoDoc_E).ToString();
            DataTable tabla = new DataTable();

            tabla = empleado.Buscar_Empleado(id_tipodocu, NroDocumento_E);
            
            
            Cargar_Datos(tabla);
            







        }

        public void Cargar_Datos(DataTable tabla)
        {
            Data_Empleados.DataSource = tabla;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
