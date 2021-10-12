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

namespace TP_PAV_3K3_GRUPO2.Formularios.Tipo_Telefono
{
    public partial class Frm_ModificarTipoTelefono : Form
    {

        public string _idtipotel_
        {
            get { return txt_id_tipo_telefono._Text; }
            set { txt_id_tipo_telefono._Text = value; }
        }

        public string _nombretipotel_
        {
            get { return txt_nombre_tipo_tel._Text; }
            set { txt_nombre_tipo_tel._Text = value; }
        }


        public Frm_ModificarTipoTelefono()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_id_tipo_telefono._Text == "")
            {
                MessageBox.Show("no se ha ingresado un id de Tipo Telefono");
                this.txt_id_tipo_telefono.Focus();
                return;
            }

            else if (txt_nombre_tipo_tel._Text == "")
            {
                MessageBox.Show("no se ha ingresado un nombre de Tipo Telefono");
                this.txt_nombre_tipo_tel.Focus();
                return;
            }

            else
            {
                NE_TipoTelefono _modtipotel_ = new NE_TipoTelefono();
                _modtipotel_.id_tipoTel = txt_id_tipo_telefono._Text;
                _modtipotel_.nombre_tipoTel = txt_nombre_tipo_tel._Text;
                _modtipotel_.modificarTipoTel();
                MessageBox.Show("la actualizacion se ha registrado exitosamente");
            }

            this.Close();
        }
    }
}
