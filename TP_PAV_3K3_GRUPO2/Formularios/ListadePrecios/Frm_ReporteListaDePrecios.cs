using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TP_PAV_3K3_GRUPO2.Negocios;

namespace TP_PAV_3K3_GRUPO2.Formularios.ListadePrecios
{
    public partial class Frm_ReporteListaDePrecios : Form
    {
        public Frm_ReporteListaDePrecios()
        {
            InitializeComponent();
        }

        private void Frm_ReporteListaDePrecios_Load(object sender, EventArgs e)
        {
            Ne_Lista_de_Precios cargar_cuils = new Ne_Lista_de_Precios();
            DataTable tabla_cuils = cargar_cuils.Buscar_clientes_con_lista();
            for(int i = 0; i<tabla_cuils.Rows.Count; i++) 
            {
                cmb_cuil.Items.Add(tabla_cuils.Rows[i]["cuil_cliente"].ToString());
                cmb_cuils.Items.Add(tabla_cuils.Rows[i]["cuil_cliente"].ToString());
            }
            this.rpv_listasCliente.RefreshReport();
        }

        private void cmb_cuil_SelectedValueChanged(object sender, EventArgs e)
        {
            Ne_Lista_de_Precios buscar_razon = new Ne_Lista_de_Precios();
            txt_razon.Text = buscar_razon.Buscar_Razon_Cliente(cmb_cuil.Text);
            btn_Reporte.Enabled = true;
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            Ne_Lista_de_Precios lista_reporte = new Ne_Lista_de_Precios();
            DataTable tabla_reporte = lista_reporte.Listas_de_un_cliente(cmb_cuil.Text);
            ReportDataSource datos = new ReportDataSource("tabla_lista1", tabla_reporte);
            rpv_listasCliente.LocalReport.ReportEmbeddedResource = "TP_PAV_3K3_GRUPO2.Formularios.ListadePrecios.Report1.rdlc";
            ReportParameter[] param = new ReportParameter[1];
            param[0] = new ReportParameter("RP_01", "Listas del cliente: "+ txt_razon.Text );
            rpv_listasCliente.LocalReport.SetParameters(param);
            rpv_listasCliente.LocalReport.DataSources.Clear();
            rpv_listasCliente.LocalReport.DataSources.Add(datos);
            rpv_listasCliente.RefreshReport();


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            Ne_Lista_de_Precios listaactual_reporte = new Ne_Lista_de_Precios();
            DataTable tabla_reporte2 = listaactual_reporte.Buscar_Lista_Actual_Reporte(cmb_cuils.Text);
            ReportDataSource datos = new ReportDataSource("DataSet23", tabla_reporte2);
            rpv_listaactual.LocalReport.ReportEmbeddedResource = "TP_PAV_3K3_GRUPO2.Formularios.ListadePrecios.Report2.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP_02", "Lista actual del cliente: " +txt_RazonSocial.Text);
            rpv_listaactual.LocalReport.SetParameters(parametros);
            rpv_listaactual.LocalReport.DataSources.Clear();
            rpv_listaactual.LocalReport.DataSources.Add(datos);
            rpv_listaactual.RefreshReport();
        }

        private void cmb_cuils_SelectedValueChanged(object sender, EventArgs e)
        {
            Ne_Lista_de_Precios buscar_razon = new Ne_Lista_de_Precios();
            txt_RazonSocial.Text = buscar_razon.Buscar_Razon_Cliente(cmb_cuils.Text);
            btn_generar.Enabled = true;
        }
    }
}
