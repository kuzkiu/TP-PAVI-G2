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

namespace TP_PAV_3K3_GRUPO2.Formularios.Cargo
{
    public partial class Frm_BajaCargo : Form
    {
        public string Codigo_cargo
        {
            get { return txt_codigo_cargo.Text; }
            set { txt_codigo_cargo.Text = value; }
        }

        /*public string _denominacion_
        {
            get { return txt_denominacion.Text; }
            set { txt_denominacion.Text = value; }
        }*/


        public Frm_BajaCargo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_codigo_cargo._Text == "")
            {
                MessageBox.Show("no se ha ingresado un codigo de cargo");
                this.txt_codigo_cargo.Focus();
                return;
            }

            else
            {
                NE_Cargo _cargo_ = new NE_Cargo();
                _cargo_.Cod_cargo = txt_codigo_cargo._Text;
                _cargo_.BorrarReg();
                MessageBox.Show("se ha eliminado el registro exitosamente");
            }

            this.Close();

        }
    }
}
