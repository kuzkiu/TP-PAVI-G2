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
    public partial class Frm_RegCargo : Form
    {
        public string _Titulo
        {
            get { return label_titulo.Text; }
            set { label_titulo.Text = value; }
        }

        public string Codigo_cargo
        {
            get { return txt_codigo_cargo.Text; }
            set { txt_codigo_cargo.Text = value; }
        }

        public string _denominacion_
        {
            get { return txt_denominacion.Text; }
            set { txt_denominacion.Text = value; }
        }


        public Frm_RegCargo()
        {
            InitializeComponent();
        }

        private void label_Text2_Load(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            //debo validar los datos del formulario
            //si la validacion esta bien grabo en la BD 
            //si la validacion da error debo correjir

            if(txt_codigo_cargo._Text == "")
            {
                MessageBox.Show("no se ha ingresado un codigo de cargo");
                this.txt_codigo_cargo.Focus();
                return;
            }

            else if (txt_denominacion._Text == "")
            {
                MessageBox.Show("no se ha ingresado una denominacion");
                this.txt_codigo_cargo.Focus();
                return;
            }

            else
            {
                //INSERTAR NUEVO CARGO
                NE_Cargo _cargo_ = new NE_Cargo();
                _cargo_.Cod_cargo = txt_codigo_cargo._Text;
                _cargo_.denominacion = txt_denominacion._Text;
                _cargo_.Insertar();
                MessageBox.Show("Cargo ingresado correctamente");

            }

            this.Close();

           
        }

    }
}
