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
using System.Data;
using TP_PAV_3K3_GRUPO2.Clases;

namespace TP_PAV_3K3_GRUPO2.Formularios.Clientes
{
    public partial class Frm_ModificarTelefonoCliente : Form
    {
        public Frm_ModificarTelefonoCliente()
        {
            InitializeComponent();
        }

        private void Frm_ModificarTelefonoCliente_Load(object sender, EventArgs e)
        {
            Ne_Cliente mod_tel_clie = new Ne_Cliente();
            DataTable tabla_telefonoCliente = new DataTable();
            tabla_telefonoCliente = mod_tel_clie.Buscar_TelefonoCliente(txt_cuil.Text);
            for (int i = 0; i < tabla_telefonoCliente.Rows.Count; i++)
            {
                cmb_numero.Items.Add(tabla_telefonoCliente.Rows[i]["numero_telefono"].ToString());
            }


        }

        private void cmb_numero_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_numero.Enabled = true;
            txt_numero.Text = cmb_numero.Text;
            cmb_tipotel.Enabled = true;
            Ne_Cliente tipotel = new Ne_Cliente();
            DataTable tabla_tipo_tel = new DataTable();
            tabla_tipo_tel = tipotel.Buscar_nombreTipoTelefono();
            for (int i = 0; i < tabla_tipo_tel.Rows.Count; i++)
            {
                cmb_tipotel.Items.Add(tabla_tipo_tel.Rows[i]["nombre"].ToString());
            }
            
        }

        private void txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (cmb_numero.Text == "")
            {
                MessageBox.Show("No se ha seleccionado un numero para modificar.");
                return;
            }

            if (txt_numero.Text == "")
            {
                MessageBox.Show("No se ha ingresado un nuevo numero.");
                return;

            }

            else
            {
                Ne_Cliente nuevo_tel_ver = new Ne_Cliente();
                DataTable verificacion = new DataTable();
                verificacion = nuevo_tel_ver.Buscar_NumTelVerificacion();
                for (int i = 0; i < verificacion.Rows.Count; i++)
                {
                    if (verificacion.Rows[i]["numero_telefono"].ToString() == txt_numero.Text
                        && verificacion.Rows[i]["numero_telefono"].ToString() != cmb_numero.Text)
                    {
                        MessageBox.Show("Este numero ya esta registrado.");
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
                Ne_Cliente cliente_modtel = new Ne_Cliente();
                DataTable tabla_mod = new DataTable();
                string id = cliente_modtel.Buscar_id(cmb_tipotel.Text).ToString();
                cliente_modtel.Modificar_Telefono_Cliente(cmb_numero.Text, txt_numero.Text, id);
                this.Close();

            }
        }
    }
}
