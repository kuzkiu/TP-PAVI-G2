using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV_3K3_GRUPO2
{
    public partial class Frm_RegEmpleado : Form
    {
        public String TipoDoc_E
        {
            get { return cb_tipoDocE.Text; }
            set { cb_tipoDocE.Text = value; }
        }
        public String TipoCargo_E
        {
            get { return cb_cargoE.Text; }
            set { cb_cargoE.Text = value; }
        }
        public String NroDocumento_E
        {
            get { return txt_DocumentoE.Text; }
            set { txt_DocumentoE.Text = value; }
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
        /*
                 public String FechaIng_E
        {
            get { return dp_FechaIngE.Value.ToString("YYYY/MM/DDDD"); }
            set { dp_FechaIngE.Value.ToString("MM/dd/yyyy"); }
        }
        public String FechaNac_E
        {
            get { return dp_FechaNacE.Value.ToString("MM/dd/yyyy"); }
            set { dp_FechaNacE.Value.ToString("MM/dd/yyyy"); }
        }*/
        public String Calle_E
        {
            get { return txt_calleE.Text; }
            set { txt_calleE.Text = value; }
        }

        public String Numero_E
        {
            get { return txt_NumeroE.Text; }
            set { txt_NumeroE.Text = value; }
        }
        public String Piso_E
        {
            get { return txt_pisoE.Text; }
            set { txt_pisoE.Text = value; }
        }
        public String Depto_E
        {
            get { return txt_deptoE.Text; }
            set { txt_deptoE.Text = value; }
        }
        public String BarrioE
        {
            get { return txt_barrioE.Text; }
            set { txt_barrioE.Text = value; }
        }
        public String Localidad_E
        {
            get { return txt_localidadE.Text; }
            set { txt_localidadE.Text = value; }
        }



        public Frm_RegEmpleado()
        {
            
            InitializeComponent();
        }

        private void Frm_RegEmpleado_Load(object sender, EventArgs e)
        {
            Negocios.NE_Empleados tipo_doc = new Negocios.NE_Empleados();
            DataTable tabla_cmb_tipodoc = new DataTable();
            tabla_cmb_tipodoc = tipo_doc.Buscar_nombreTipoDocumento();
            for (int i = 0; i < tabla_cmb_tipodoc.Rows.Count; i++)
            {

               // MessageBox.Show(tabla_cmb_tipodoc.Rows[i]["nombre"].ToString());
                cb_tipoDocE.Items.Add(tabla_cmb_tipodoc.Rows[i]["nombre"]);
            }
            Negocios.NE_Empleados tipotel = new Negocios.NE_Empleados();
            DataTable tabla_cmb_tipocargo = new DataTable();
            tabla_cmb_tipocargo = tipotel.Buscar_nombreTipoCargo();
            for (int i = 0; i < tabla_cmb_tipocargo.Rows.Count; i++)
            {
                cb_cargoE.Items.Add(tabla_cmb_tipocargo.Rows[i]["denominacion"]);
            }
            

    }

    private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.cb_tipoDocE.Text == "")
            {
                MessageBox.Show("No ha seleccionado ningún documento");
                this.txt_NombreE.Focus();
                return;
            }
            if (this.txt_NombreE.Text == "")
            {
                MessageBox.Show("No ha ingresado ningún Nombre");
                this.txt_NombreE.Focus();
                return;
            }
            if (this.txt_ApellidoE.Text == "")
            {
                MessageBox.Show("No ha ingresado ningún Apellido");
                this.txt_NombreE.Focus();
                return;
            }
            if (this.txt_DocumentoE.Text == "")
            {
                MessageBox.Show("No ha ingresado ningún Documento");
                this.txt_NombreE.Focus();
                return;
            }
            if (this.txt_NumeroE.Text == "")
            {
                MessageBox.Show("No ha ingresado ningún numero");
                this.txt_NombreE.Focus();
                return;
            }
            if (this.txt_calleE.Text == "")
            {
                MessageBox.Show("No ha ingresado ninguna calle");
                this.txt_NombreE.Focus();
                return;
            }
            if (this.dp_FechaNacE.Text == "")
            {
                MessageBox.Show("No ha seleccionado ninguna fecha de nacimiento");
                this.txt_NombreE.Focus();
                return;
            }
            if (this.dp_FechaIngE.Text == "")
            {
                MessageBox.Show("No ha seleccionado ninguna fecha de Ingreso");
                this.txt_NombreE.Focus();
                return;
            }
            if (this.cb_cargoE.Text == "")
            {
                MessageBox.Show("No ha seleccionado ningún cargo");
                this.txt_NombreE.Focus();
                return;
            }
            if (this.txt_barrioE.Text == "")
            {
                MessageBox.Show("No ha ingresado ningun barrio");
                this.txt_NombreE.Focus();
                return;
            }
            else
            {
            Negocios.NE_Empleados clie = new Negocios.NE_Empleados();
                /*Ne_Cliente tipoTel = new Ne_Cliente();
                string id_tipotel = tipoTel.Buscar_id(TipoTel).ToString();
                Ne_Cliente dir = new Ne_Cliente();
                string id_direc = dir.Buscar_id_direccion().ToString();*/
                Negocios.NE_Empleados cargo = new Negocios.NE_Empleados();
                string id_cargo = cargo.Buscar_idTipoCargo(TipoCargo_E).ToString();
                Negocios.NE_Empleados tipodoc = new Negocios.NE_Empleados();
                MessageBox.Show(TipoCargo_E);
                string id_tipodocu = tipodoc.Buscar_idTipoDoc(TipoDoc_E).ToString();
                Negocios.NE_Empleados dir = new Negocios.NE_Empleados();
                string id_direc = dir.Buscar_id_direccion().ToString();
                Negocios.NE_Empleados bar = new Negocios.NE_Empleados();
                string id_barrio = bar.Buscar_idBarrio(BarrioE).ToString();
                //MessageBox.Show(id_barrio);

                //cambiar los txt cuando sepa como convertirlos a int.

                clie.Registrar_EmpleadoFinal(NroDocumento_E, Nombre_E, Apellido_E, FechaNac_E, FechaIng_E, id_cargo, 
                    id_tipodocu,
                    id_direc, id_barrio, Calle_E, Numero_E, Piso_E,Depto_E);
                //clie.Insertar(NroDocumento_E, Nombre_E,Apellido_E, FechaNac_E, FechaIng_E, id_cargo, id_tipodocu);//Nombre_E,Apellido_E, FechaNac_E, FechaIng_E, id_tipodocu, id_cargo);
                //TipoDoc_E, NroDocumento_E, Nombre_E, Apellido_E, FechaIng_E, FechaNac_E, Calle_E, Numero_E, Piso_E, BarrioE, Localidad_E
            }
            
           MessageBox.Show("Ha registrado un nuevo empleado con exito");
            

        }
        //Parte de combobox

        private void Frm_RegEmpleado_Load_1(object sender, EventArgs e)
        {
            Negocios.NE_Empleados tipo_doc = new Negocios.NE_Empleados();
            DataTable tabla_cmb_tipodoc = new DataTable();
            tabla_cmb_tipodoc = tipo_doc.Buscar_nombreTipoDocumento();
            for (int i = 0; i < tabla_cmb_tipodoc.Rows.Count; i++)
            {

            MessageBox.Show(tabla_cmb_tipodoc.Rows[i]["nombre"].ToString());
                //cb_tipoDocE.Items.Add(tabla_cmb_tipodoc.Rows[i]["nombre"]);
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

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_tipoDocE_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_DocumentoE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ApellidoE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
