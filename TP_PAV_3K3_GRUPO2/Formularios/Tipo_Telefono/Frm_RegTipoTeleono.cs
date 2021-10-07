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
    public partial class Frm_RegTipoTeleono : Form
    {

        public string _idTipoTelefono_
        {
            get { return txt_id_tipo_telefono._Text; }
            set { txt_id_tipo_telefono._Text = value; }
        }

        public string _nombreTipoTel_
        {
            get { return txt_nombre_tipo_tel._Text; }
            set { txt_nombre_tipo_tel._Text = value; }
        }


        public Frm_RegTipoTeleono()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if(txt_id_tipo_telefono._Text == "")
            {
                MessageBox.Show("no se ha ingresado un id para el tipo de telefono");
                this.txt_id_tipo_telefono.Focus();
                return;
            }

            else if(txt_nombre_tipo_tel._Text == "")
            {
                MessageBox.Show("no se ha ingresado un nombre para el tipo de telefono");
                this.txt_id_tipo_telefono.Focus();
                return;
            }

            else
            {
                NE_TipoTelefono _tel_ = new NE_TipoTelefono();
                _tel_.id_tipoTel = txt_id_tipo_telefono._Text;
                _tel_.nombre_tipoTel = txt_nombre_tipo_tel._Text;
                _tel_.Insertar();
                MessageBox.Show("Tipo de Telefono registrado exitosamente");
            }

                
        }
    }
}
