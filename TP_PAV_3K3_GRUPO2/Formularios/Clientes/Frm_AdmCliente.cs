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
using TP_PAV_3K3_GRUPO2.Clases;
using TP_PAV_3K3_GRUPO2.Formularios.Clientes;

namespace TP_PAV_3K3_GRUPO2.Formularios.Base
{
    public partial class Frm_AdmCliente : Form
    {
        private String Cuil_Cliente
        {
            get { return txt_cuil.Text; }
            set { txt_cuil.Text = value; }
        }

        private String RazonSo
        {
            get { return txt_cuil.Text; }
            set { txt_cuil.Text = value; }
        }

        public Frm_AdmCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ne_Cliente cliente = new Ne_Cliente();
            DataTable tabla = new DataTable();
            tabla = cliente.buscarCliente(txt_cuil.Text, txt_razonS.Text);
            Cargar_Datos(tabla);
        }

        private void txt_cuil_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void txt_razonS_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
        }

        private void Frm_AdmCliente_Load(object sender, EventArgs e)
        {

        }

        public void Cargar_Datos(DataTable tabla) 
        {
            DGV_clientes.DataSource = tabla;
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Frm_RegCliente reg_clie = new Frm_RegCliente();
            reg_clie.ShowDialog();
            reg_clie.Dispose();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Frm_ModificarCliente mod_cli = new Frm_ModificarCliente();
            mod_cli.ShowDialog();
            mod_cli.Dispose();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Frm_BajaCliente baja_clie = new Frm_BajaCliente();
            baja_clie.ShowDialog();
            baja_clie.Dispose();
        }
    }
}
