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
using TP_PAV_3K3_GRUPO2.Negocio;

namespace TP_PAV_3K3_GRUPO2
{
    public partial class Frm_RegCliente : Form
    {
        public String Cuil
        {
            get { return txt_Cuil.Text; }
            set { txt_Cuil.Text = value; }
        }

        public String RazonS
        {
            get { return txt_Razon.Text; }
            set { txt_Razon.Text = value; }
        }

        public String TipoDoc
        {
            get { return cb_tipoDoc.Text; }
            set { cb_tipoDoc.Text = value; }
        }

        public String NumDoc
        {
            get { return txt_NumDoc.Text; }
            set { txt_NumDoc.Text = value; }
        }

        public String TipoTel
        {
            get { return cb_TipoTel.Text; }
            set { cb_TipoTel.Text = value; }
        }

        public String Telefono
        {
            get { return txt_numtel.Text; }
            set { txt_numtel.Text = value; }
        }

        public String NumeroDir
        {
            get { return txt_numdir.Text; }
            set { txt_numdir.Text = value; }
        }

        public String Calle
        {
            get { return txt_calle.Text; }
            set { txt_calle.Text = value; }
        }

        public String Depto
        {
            get { return txt_Depto.Text; }
            set { txt_Depto.Text = value; }
        }

        public String Piso
        {
            get { return txt_piso.Text; }
            set { txt_piso.Text = value; }
        }
        public String Barrio
        {
            get { return txt_barrio.Text; }
            set { txt_barrio.Text = value; }
        }
        public String Localidad
        {
            get { return txt_loc.Text; }
            set { txt_loc.Text = value; }
        }



        public Frm_RegCliente()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txt_Cuil.Text == "") 
            {
                MessageBox.Show("El cuil está vacio");
                this.txt_Cuil.Focus();
                return;
            }
            if(this.txt_Cuil.Text != "")
            {
                Ne_Cliente cliente_cuil = new Ne_Cliente();
                DataTable tabla_cuil = new DataTable();
                tabla_cuil = cliente_cuil.BuscarCuils();
                for (int i=0; i<tabla_cuil.Rows.Count; i++) 
                {
                    if (tabla_cuil.Rows[i]["cuil_cliente"] == txt_Cuil.Text) 
                    {
                        MessageBox.Show("Cuil ya existente. Ingrese otro");
                        return;
                    }
                }
            
            }

            if (this.txt_Razon.Text == "")
            {
                MessageBox.Show("La razon social esta vacia está vacia");
                this.txt_Razon.Focus();
                return;
            }

            if (this.cb_tipoDoc.Text == "")
            {
                MessageBox.Show("El tipo documento está vacio");
                this.cb_tipoDoc.Focus();
                return;
            }

            if (this.txt_NumDoc.Text == "")
            {
                MessageBox.Show("El número documento está vacio");
                this.txt_NumDoc.Focus();
                return;
            }

            if (this.cb_TipoTel.Text == "" & this.txt_numtel.Text != "" || this.cb_TipoTel.Text != "" & this.txt_numtel.Text == "")
            {
                MessageBox.Show("Tipo Telefono y Telefono deben estar simultaneamente vacios o llenos");
                this.cb_TipoTel.Focus();
                return;
            }

          

            if (this.txt_numdir.Text == "")
            {
                MessageBox.Show("El numero de dirección está vacio");
                this.txt_numdir.Focus();
                return;
            }

            if (this.txt_calle.Text == "")
            {
                MessageBox.Show("La calle está vacio");
                this.txt_calle.Focus();
                return;
            }

            if (this.txt_barrio.Text == "")
            {
                MessageBox.Show("El barrio está vacio");
                this.txt_barrio.Focus();
                return;
            }

            if (this.txt_loc.Text == "")
            {
                MessageBox.Show("La localidad está vacia");
                this.txt_loc.Focus();
                return;
            }

            if ((this.txt_piso.Text =="" & this.txt_Depto.Text !="") || (this.txt_piso.Text != "" & this.txt_Depto.Text == ""))
            {
                MessageBox.Show("Piso y depto deben estar ambos vacios o ambos deben tener un valor ");
                this.txt_loc.Focus();
                return;
            }

            else
            {
                Ne_Cliente clie = new Ne_Cliente();
                Ne_Cliente tipoTel = new Ne_Cliente();
                string id_tipotel =tipoTel.Buscar_id(TipoTel).ToString();
                Ne_Cliente dir = new Ne_Cliente();
                string id_direc = dir.Buscar_id_direccion().ToString();
                Ne_Cliente bar = new Ne_Cliente();
                string id_barrio = bar.Buscar_idBarrio(Barrio).ToString();
                Ne_Cliente tipodoc = new Ne_Cliente();
                string id_tipodocu = tipodoc.Buscar_idTipoDoc(TipoDoc).ToString();


                //cambiar los txt cuando sepa como convertirlos a int.
                clie.Registrar_Cliente_Final(Cuil, RazonS, Telefono, id_tipotel, id_direc, id_barrio, 
                    Calle, NumeroDir, Piso, Depto, id_tipodocu, NumDoc);
               
            }


            this.Close();
        }

        private void Frm_RegCliente_Load(object sender, EventArgs e)
        {

        }

        private void txt_Cuil_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void txt_Razon_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
        }

        private void txt_NumDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_NumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void txt_numtel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void txt_numdir_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void txt_calle_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
        }

        private void txt_Depto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
        }

        private void txt_piso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void Frm_RegCliente_Load_1(object sender, EventArgs e)
        {
            Ne_Cliente tipo_doc = new Ne_Cliente();
            DataTable tabla_cmb_tipodoc = new DataTable();
            tabla_cmb_tipodoc = tipo_doc.Buscar_nombreTipoDocumento();
            for (int i = 0; i < tabla_cmb_tipodoc.Rows.Count; i++)
            {
                cb_tipoDoc.Items.Add(tabla_cmb_tipodoc.Rows[i]["nombre"]);
            }

            Ne_Cliente tipotel = new Ne_Cliente();
            DataTable tabla_cmb_tipotel = new DataTable();
            tabla_cmb_tipotel = tipotel.Buscar_nombreTipoTel();
            for (int i = 0; i < tabla_cmb_tipotel.Rows.Count; i++)
            {
                cb_TipoTel.Items.Add(tabla_cmb_tipotel.Rows[i]["nombre"]);
            }

        }
    }
}
