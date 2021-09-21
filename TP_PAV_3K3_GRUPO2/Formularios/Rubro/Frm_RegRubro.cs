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
    public partial class Frm_RegRubro : Form
    {

        public String idRubro
        {
            get { return txt_idRubro.Text; }
            set { txt_idRubro.Text = value; }
        }

        public String nombreRubro
        {
            get { return txt_nomRubro.Text; }
            set { txt_nomRubro.Text = value; }
        }

        public Frm_RegRubro()
        {
            InitializeComponent();
        }

        private void Frm_RegRubro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_idRubro.Text == "")
            {
                MessageBox.Show("no se ha ingresado un ID de rubro");
                this.txt_idRubro.Focus();
                return;
            }

            else if (txt_nomRubro.Text == "")
            {
                MessageBox.Show("no se ha ingresado un nombre de rubro");
                this.txt_nomRubro.Focus();
                return;
            }

            else
            {
                //INSERTAR NUEVO RUBRO
                NE_Rubro _rubro_ = new NE_Rubro();
                _rubro_.id_Rubro_ = idRubro;
                _rubro_.nombre_Rubro = nombreRubro;
                _rubro_.Insertar();
                MessageBox.Show("Rubro ingresado correctamente");

            }

            this.Close();
        }
    }
}
