using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV_3K3_GRUPO2.Formularios.Empleados
{
    public partial class Frm_BajaEmpleado : Form
    {
        public Frm_BajaEmpleado()
        {
            InitializeComponent();
        }
        public String TipoDoc_E
        {
            get { return cb_tipoDocE.Text; }
            set { cb_tipoDocE.Text = value; }
        }

        public String TipoCargo_E
        {
            get { return txt_cargoE.Text; }
            set { txt_cargoE.Text = value; }
        }
        public String NroDocumento_E
        {
            get { return cb_documentoE.Text; }
            set { cb_documentoE.Text = value; }
        }
        public String Nombre_E
        {
            get { return txt_nombreE.Text; }
            set { txt_nombreE.Text = value; }
        }
        public String Apellido_E
        {
            get { return txt_apellidoE.Text; }
            set { txt_apellidoE.Text = value; }
        }

        public String FechaIng_E
        {
            get { return dp_FechaIng_E.Value.ToString("yyyy/MM/dd"); }
            set { dp_FechaIng_E.Value.ToString("yyyy/MM/dd"); }
        }
        public String FechaNac_E
        {
            get { return dp_FechaNac_E.Value.ToString("yyyy/MM/dd"); }
            set { dp_FechaNac_E.Value.ToString("yyyy/MM/dd"); }
        }

        private void Frm_BajaEmpleado_Load(object sender, EventArgs e)
        {
            Negocios.NE_Empleados tipo_doc = new Negocios.NE_Empleados();
            DataTable tabla_cmb_tipodoc = new DataTable();
            tabla_cmb_tipodoc = tipo_doc.Buscar_nombreTipoDocumento();
            for (int i = 0; i < tabla_cmb_tipodoc.Rows.Count; i++)
            {

                //MessageBox.Show(tabla_cmb_tipodoc.Rows[i]["nombre"].ToString());
                cb_tipoDocE.Items.Add(tabla_cmb_tipodoc.Rows[i]["nombre"]);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cb_documentoE_SelectedIndexChanged(object sender, EventArgs e)
        {
            Negocios.NE_Empleados tipodoc = new Negocios.NE_Empleados();
            string id_tipodocu = tipodoc.Buscar_idTipoDoc(TipoDoc_E).ToString();
            Negocios.NE_Empleados Empleado_baja= new Negocios.NE_Empleados();
            DataTable tabla = new DataTable();
            tabla = Empleado_baja.BuscarEmpleadoBaja(id_tipodocu, cb_documentoE.Text);
            txt_nombreE.Text = tabla.Rows[0]["nombre"].ToString();
            txt_nombreE.ReadOnly = true; 
            txt_apellidoE.Text = tabla.Rows[0]["apellido"].ToString();
            txt_apellidoE.ReadOnly = true;
            dp_FechaNac_E.Text = tabla.Rows[0]["fecha_nac"].ToString();
            dp_FechaIng_E.Text = tabla.Rows[0]["fecha_ingreso"].ToString();

            txt_cargoE.Text = tabla.Rows[0]["denominacion"].ToString();
            txt_cargoE.ReadOnly = true;
            txt_calleE.Text = tabla.Rows[0]["calle"].ToString();
            txt_calleE.ReadOnly = true;
            txt_numeroE.Text = tabla.Rows[0]["numero"].ToString();
            txt_numeroE.ReadOnly = true;
            txt_pisoE.Text = tabla.Rows[0]["piso"].ToString();
            txt_pisoE.ReadOnly = true;
            txt_deptoE.Text = tabla.Rows[0]["depto"].ToString();
            txt_deptoE.ReadOnly = true;
            txt_barrioE.Text = tabla.Rows[0]["nombre_barrio"].ToString();
            txt_barrioE.ReadOnly = true;
            txt_localidadE.Text = tabla.Rows[0]["nombre_localidad"].ToString();
            txt_localidadE.ReadOnly = true;

        }

        private void cb_tipoDocE_SelectedIndexChanged(object sender, EventArgs e)
        {
            Negocios.NE_Empleados tipodoc = new Negocios.NE_Empleados();
            string id_tipodocu = tipodoc.Buscar_idTipoDoc(TipoDoc_E).ToString();
            Negocios.NE_Empleados cliente_cmb = new Negocios.NE_Empleados();
            DataTable tabla_documento = new DataTable();
            tabla_documento = cliente_cmb.BuscarDocumentos(id_tipodocu);

            for (int i = 0; i < tabla_documento.Rows.Count; i++)
            {
                cb_documentoE.Items.Add(tabla_documento.Rows[i]["nro_doc_emp"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Negocios.NE_Empleados tipodoc = new Negocios.NE_Empleados();
            string id_tipodocu = tipodoc.Buscar_idTipoDoc(TipoDoc_E).ToString();
            Negocios.NE_Empleados cli_baja = new Negocios.NE_Empleados();
            cli_baja.BajaEmpleado(id_tipodocu, cb_documentoE.Text);
            MessageBox.Show("Empleado eliminado con éxito");
            this.Close();
        }
    }
}
