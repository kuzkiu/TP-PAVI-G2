using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV_3K3_GRUPO2
{
    public partial class Frm_Login : Form
    {
        
        public String usuario
        {
            get { return txt_usuario.Text; }
            set { txt_usuario.Text = value; }
         }

        public String contraseña
        {
            get { return txt_clave.Text; }
            set { txt_clave.Text = value; }
        }
        public Frm_Login()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.txt_usuario.Text == "")
            {
                MessageBox.Show("El usuario está vacio");
                this.txt_usuario.Focus();
                return;

            }
            if (this.txt_clave.Text == "")
            {
                MessageBox.Show("El password está vacío");
                this.txt_clave.Focus();
                return;

            }           
            this.Close();
        }
    }
}
