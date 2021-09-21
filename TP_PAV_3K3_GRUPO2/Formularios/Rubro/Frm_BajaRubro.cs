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


namespace TP_PAV_3K3_GRUPO2.Formularios.Rubro
{
    

    public partial class Frm_BajaRubro : Form
    {
        public string idRubro
        {
            get { return txt_idRubro._Text; }
            set { txt_idRubro._Text = value; }
        }

        public Frm_BajaRubro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_idRubro._Text == "")
            {
                MessageBox.Show("no se ha ingresado un id de rubro");
                this.txt_idRubro.Focus();
                return;
            }

            else
            {
                NE_Rubro _rubro_ = new NE_Rubro();
                _rubro_.id_Rubro_ = txt_idRubro._Text;
                _rubro_.BorrarReg();
                MessageBox.Show("se ha borrado exitosamente el registroo");
            }

            this.Close();

        }
    }
}
