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
    public partial class Frm_ModificarEmpleado : Form
    {
        public Frm_ModificarEmpleado()
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
            get { return cb_CargoE.Text; }
            set { cb_CargoE.Text = value; }
        }
        public String NroDocumento_E
        {
            get { return cb_documentoE.Text; }
            set { cb_documentoE.Text = value; }
        }
        public String Nombre_E
        {
            get { return txt_NombreE.Text; }
            set { txt_NombreE.Text = value; }
        }
        public String Apellido_E
        {
            get { return txt_ApellidoE.Text; }
            set { txt_ApellidoE.Text = value; }
        }
        
        public String FechaIng_E
        {
            get { return dp_FechaIngE.Value.ToString("yyyy/MM/dd"); }
            set { dp_FechaIngE.Value.ToString("yyyy/MM/dd"); }
        }
        public String FechaNac_E
        {
            get { return dp_FechaNacE.Value.ToString("yyyy/MM/dd"); }
            set { dp_FechaNacE.Value.ToString("yyyy/MM/dd"); }
        }
        private void Frm_ModificarEmpleado_Load(object sender, EventArgs e)
        {
            Negocios.NE_Empleados tipo_doc = new Negocios.NE_Empleados();
            DataTable tabla_cmb_tipodoc = new DataTable();
            tabla_cmb_tipodoc = tipo_doc.Buscar_nombreTipoDocumento();
            for (int i = 0; i < tabla_cmb_tipodoc.Rows.Count; i++)
            {

                //MessageBox.Show(tabla_cmb_tipodoc.Rows[i]["nombre"].ToString());
                cb_tipoDocE.Items.Add(tabla_cmb_tipodoc.Rows[i]["nombre"]);
            }

            //buscar documento


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox011_SelectedIndexChanged(object sender, EventArgs e)
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
            if (NroDocumento_E == "" || TipoDoc_E == "")
                MessageBox.Show("Debes seleccionar un empleado");
            if (this.dp_FechaIngE.Value < this.dp_FechaNacE.Value)
            {
                MessageBox.Show("Debe introducir una fecha válida para el nacimiento del cliente");
                return;
            }
            else
            {
                Negocios.NE_Empleados empl_mod = new Negocios.NE_Empleados();
                Negocios.NE_Empleados tipodoc = new Negocios.NE_Empleados();
                string id_tipodocu = tipodoc.Buscar_idTipoDoc(cb_tipoDocE.Text).ToString();
                Negocios.NE_Empleados dir = new Negocios.NE_Empleados();
                string id_direc = dir.Buscar_id_direccion_empleado(NroDocumento_E, id_tipodocu).ToString();
                Negocios.NE_Empleados bar = new Negocios.NE_Empleados();
                string id_barrio = bar.Buscar_idBarrio(cb_barrioE.Text).ToString();
                Negocios.NE_Empleados cargo = new Negocios.NE_Empleados();
                string id_cargo = cargo.Buscar_idTipoCargo(TipoCargo_E).ToString();
              
                empl_mod.modificar_empleado_total(id_tipodocu, NroDocumento_E, Nombre_E, Apellido_E, FechaNac_E, 
                    FechaIng_E, id_cargo,
                   id_direc, txt_calleE.Text, txt_numeroE.Text, txt_deptoE.Text, txt_pisoE.Text, id_barrio);

                /*
                empl_mod.modificar_ClienteDefinitivo(cmb_cuil.Text, txt_Razon.Text, id_tipodocu, txt_NumDoc.Text,
                    id_direc, txt_calle.Text, txt_numdir.Text, txt_Depto.Text, txt_piso.Text, id_barrio);*/


            }
        }

        private void cb_documentoE_SelectedIndexChanged(object sender, EventArgs e)
        {
            Negocios.NE_Empleados cliente_mod = new Negocios.NE_Empleados();
            DataTable tabla_mod = new DataTable();
            tabla_mod = cliente_mod.BuscarEmpleadoModificacion(cb_documentoE.Text);
            txt_NombreE.Enabled = true;
            txt_NombreE.Text = tabla_mod.Rows[0]["nombre"].ToString();
            txt_ApellidoE.Enabled = true;
            txt_ApellidoE.Text = tabla_mod.Rows[0]["apellido"].ToString();
            dp_FechaNacE.Text = tabla_mod.Rows[0]["fecha_nac"].ToString();
            dp_FechaIngE.Text = tabla_mod.Rows[0]["fecha_ingreso"].ToString();
            cb_CargoE.Text = tabla_mod.Rows[0]["denominacion"].ToString();
            txt_calleE.Text = tabla_mod.Rows[0]["calle"].ToString();
            txt_numeroE.Text = tabla_mod.Rows[0]["numero"].ToString();
            txt_pisoE.Text = tabla_mod.Rows[0]["piso"].ToString();
            txt_deptoE.Text = tabla_mod.Rows[0]["depto"].ToString();
            cb_barrioE.Text = tabla_mod.Rows[0]["nombre_barrio"].ToString();
            cb_localidadE.Text = tabla_mod.Rows[0]["nombre_localidad"].ToString();
            Negocios.NE_Empleados combo_cargo = new Negocios.NE_Empleados();
            DataTable tabla_cmb_cargo = new DataTable();
            tabla_cmb_cargo = combo_cargo.Buscar_Cargo();
            for (int i = 0; i < tabla_cmb_cargo.Rows.Count; i++)
            {
                cb_CargoE.Items.Add(tabla_cmb_cargo.Rows[i]["denominacion"]);
            }
            
            //cb_CargoE.Text = tabla_mod.Rows[0]["denominacion"].ToString();
            Negocios.NE_Empleados combo_localidad = new Negocios.NE_Empleados();
            DataTable tabla_cmb_localidad = new DataTable();
            tabla_cmb_localidad = combo_localidad.Buscar_Localidad();
            for (int i = 0; i < tabla_cmb_localidad.Rows.Count; i++)
            {
                cb_localidadE.Items.Add(tabla_cmb_localidad.Rows[i]["nombre_localidad"]);
            }
            cb_localidadE.Text = tabla_mod.Rows[0]["nombre_localidad"].ToString();
            cb_barrioE.Enabled = true;
            cb_barrioE.Items.Clear();
            Negocios.NE_Empleados barrio = new Negocios.NE_Empleados();
            DataTable tabla_barrio = new DataTable();
            tabla_barrio = barrio.Buscar_NombreBarrio(cb_localidadE.Text);
            for (int i = 0; i < tabla_barrio.Rows.Count; i++)
            {
                cb_barrioE.Items.Add(tabla_barrio.Rows[i]["nombre_barrio"]);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cb_localidadE_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_barrioE.Items.Clear();
            cb_barrioE.Enabled = true;
            Negocios.NE_Empleados barrio = new Negocios.NE_Empleados();
            DataTable tabla_barrio = new DataTable();
            tabla_barrio = barrio.Buscar_NombreBarrio(cb_localidadE.Text);
            for (int i = 0; i < tabla_barrio.Rows.Count; i++)
            {
                cb_barrioE.Items.Add(tabla_barrio.Rows[i]["nombre_barrio"]);
            }
        }

        private void cb_CargoE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_ApellidoE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
