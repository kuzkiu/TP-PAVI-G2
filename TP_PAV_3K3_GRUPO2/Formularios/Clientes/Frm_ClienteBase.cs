using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV_3K3_GRUPO2.Formularios.Clientes
{
    public partial class Frm_ClienteBase : Form
    {
        public String _Titulo 
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
        public Frm_ClienteBase()
        {
            InitializeComponent();
        }

        private void dgw_telefono_cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
