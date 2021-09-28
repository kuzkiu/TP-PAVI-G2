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
    public partial class Frm_ConsultarCargo : Form
    {
        private String CodigoC
        {
            get { return txt_codigo.Text; }
            set { txt_codigo.Text = value; }
        }

        private String denominacionC
        {
            get { return txt_denominacion.Text; }
            set { txt_denominacion.Text = value; }
        }


        public Frm_ConsultarCargo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NE_Cargo cargo = new NE_Cargo();
            DataTable tabla = new DataTable();
            tabla = cargo.BuscarCargo(txt_codigo.Text, txt_denominacion.Text);
            Cargar_Datos(tabla);
        }

        public void Cargar_Datos(DataTable tabla)
        {
            DGV_cargo.DataSource = tabla;
        }
    }
}
