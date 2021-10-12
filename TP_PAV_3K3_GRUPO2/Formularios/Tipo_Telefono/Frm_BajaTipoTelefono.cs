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
    public partial class Frm_BajaTipoTelefono : Form
    {

        public string _idTipoTel_
        {
            get { return txt_id_tipo_telefono._Text; }
            set { txt_id_tipo_telefono._Text = value; }
        }

        public Frm_BajaTipoTelefono()
        {
            InitializeComponent();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (txt_id_tipo_telefono._Text == "")
            {
                MessageBox.Show("no se ha ingresado un id de tipo Telefono");
                this.txt_id_tipo_telefono.Focus();
                return;
            }

            else
            {
                NE_TipoTelefono _bajatipotel_ = new NE_TipoTelefono();
                _bajatipotel_.id_tipoTel = txt_id_tipo_telefono._Text;
                _bajatipotel_.BorrarReg();
                MessageBox.Show("se ha eliminado el Tipo de Telefono exitosamente");
            }

            this.Close();
        }
    }
}
