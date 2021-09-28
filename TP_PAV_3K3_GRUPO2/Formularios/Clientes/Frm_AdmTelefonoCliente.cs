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
    public partial class Frm_AdmTelefonoCliente : Form
    {
        public Frm_AdmTelefonoCliente()
        {
            InitializeComponent();
        }

        private void Frm_AdmTelefonoCliente_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_agregartelefono_Click(object sender, EventArgs e)
        {
            Frm_RegistrarTelefonoCliente Reg_tel = new Frm_RegistrarTelefonoCliente();
            Reg_tel.txt_cuil.Text = this.txt_cuil.Text;
            Reg_tel.ShowDialog();
            Reg_tel.Dispose();
        }

        private void btn_modificartelefono_Click(object sender, EventArgs e)
        {
            Frm_ModificarTelefonoCliente mod_tel_cliente = new Frm_ModificarTelefonoCliente();
            mod_tel_cliente.txt_cuil.Text = this.txt_cuil.Text;
            mod_tel_cliente.txt_cuil.Enabled = false;
            mod_tel_cliente.ShowDialog();
            mod_tel_cliente.Dispose();
        }

        private void Frm_AdmTelefonoCliente_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Ne_Cliente cliente = new Ne_Cliente();
            DataTable tabla_tel = new DataTable();
            tabla_tel = cliente.Buscar_TelefonoCliente(txt_cuil.Text);
            dgv_telefonocliente.DataSource = tabla_tel;
        }

        private void btn_eliminartelefono_Click(object sender, EventArgs e)
        {
            Frm_EliminarTelefonoCliente baja_tel_cliente = new Frm_EliminarTelefonoCliente();
            baja_tel_cliente.txt_cuil.Text = txt_cuil.Text;
            baja_tel_cliente.txt_cuil.Enabled = false;
            baja_tel_cliente.ShowDialog();
            baja_tel_cliente.Dispose();

        }
    }
}
