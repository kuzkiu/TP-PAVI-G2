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

namespace TP_PAV_3K3_GRUPO2.Formularios.Clientes
{
    public partial class Frm_RegistrarTelefonoCliente : Form
    {
        public Frm_RegistrarTelefonoCliente()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void Frm_RegistrarTelefonoCliente_Load(object sender, EventArgs e)
        {
            Ne_Cliente cliente = new Ne_Cliente();
            DataTable tabla_tipotel = new DataTable();
            tabla_tipotel = cliente.Buscar_nombreTipoTelefono();
            for (int i =0; i<tabla_tipotel.Rows.Count; i++) 
            {
                cmb_tipotel.Items.Add(tabla_tipotel.Rows[i]["nombre"].ToString());
            }
        }

        private void btn_RegistrarTelefonoCliente_Click(object sender, EventArgs e)
        {
            if (txt_numtel.Text == "") 
            {
                MessageBox.Show("No se ha cargado ningun numero");
                return;
            }

            if (txt_numtel.Text != "") 
            {
                Ne_Cliente verificar_tel = new Ne_Cliente();
                DataTable tabla_telefonos_registrados = new DataTable();
                tabla_telefonos_registrados = verificar_tel.Buscar_NumTelVerificacion();
                for (int i =0; i< tabla_telefonos_registrados.Rows.Count; i++) 
                { 
                    if(txt_numtel.Text == tabla_telefonos_registrados.Rows[i]["numero_telefono"].ToString()) 
                    {
                        MessageBox.Show("Ha ingresado un numero ya registrado");
                        return;
                    }
                }
            }

            if (cmb_tipotel.Text == "") 
            {
                MessageBox.Show("No se ha seleccionado un tipo de telefono");
                return;
            }

           
            else 
            {
                Ne_Cliente reg_tel = new Ne_Cliente();
                string tipotelefono = reg_tel.Buscar_id(cmb_tipotel.Text).ToString();
                reg_tel.Registrar_Telfono_Cliente(txt_cuil.Text, txt_numtel.Text, tipotelefono);
                this.Close();
            }
        }
    }
}
