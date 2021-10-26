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
using Microsoft.Reporting.WinForms;

namespace TP_PAV_3K3_GRUPO2.Formularios.Estadisticas.Ventas
{
    public partial class Frm_EstVentas : Form
    {
        public Frm_EstVentas()
        {
            InitializeComponent();
        }

        private void txt_mes01_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_mes02_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (this.txt_mes01.Text == "")
            {
                MessageBox.Show("Debe completar este campo.", "Reporte de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_mes01.Focus();
                return;
            }
            if (Int32.Parse(this.txt_mes01.Text) > 12 || Int32.Parse(this.txt_mes01.Text) < 1)
            {
                MessageBox.Show("Debe ingresar un número de mes válido (entre 1 y 12)", "Reporte de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_mes01.Focus();
                return;
            }

            if (Int32.Parse(this.txt_mes01.Text) < 10)
            {
                int mes = Int16.Parse(txt_mes01.Text);
                txt_mes01.Text = mes.ToString("D2");

            }

            if (this.txt_anio01.Text == "")
            {
                MessageBox.Show("Debe completar este campo.", "Reporte de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_anio01.Focus();
                return;
            }
            if (Int32.Parse(this.txt_anio01.Text) > 2021 || Int32.Parse(this.txt_anio01.Text) < 2020)
            {
                MessageBox.Show("Debe ingresar un número de año válido", "Reporte de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_anio01.Focus();
                return;
            }
            NE_Ventas venta = new NE_Ventas();
            DataTable tabla = new DataTable();
            string fechadesde = "01/" + txt_mes01.Text + "/" + txt_anio01.Text;
            string fechahasta = "31/" + txt_mes01.Text + "/" + txt_anio01.Text;
            tabla = venta.BuscarVentasPorMesPorSucursalEst(fechadesde, fechahasta);
            
            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            rv01.LocalReport.ReportEmbeddedResource = "TP_PAV_3K3_GRUPO2.Formularios.Estadisticas.Ventas.RP_EstadisticasVSucursal.rdlc";
            rv01.LocalReport.DataSources.Clear();
            rv01.LocalReport.DataSources.Add(datos);
            rv01.RefreshReport();
        }

        private void Frm_EstVentas_Load(object sender, EventArgs e)
        {

            this.rv01.RefreshReport();
            this.rv02.RefreshReport();
        }

        private void txt_mes01_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_mes02_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_anio02_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_buscar2_Click(object sender, EventArgs e)
        {
            if (this.txt_mes02.Text == "")
            {
                MessageBox.Show("Debe completar este campo.", "Reporte de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_mes02.Focus();
                return;
            }
            if (Int32.Parse(this.txt_mes02.Text) > 12 || Int32.Parse(this.txt_mes02.Text) < 1)
            {
                MessageBox.Show("Debe ingresar un número de mes válido (entre 1 y 12)", "Reporte de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_mes02.Focus();
                return;
            }

            if (Int32.Parse(this.txt_mes02.Text) < 10)
            {
                int mes = Int16.Parse(txt_mes02.Text);
                txt_mes02.Text = mes.ToString("D2");

            }

            if (this.txt_anio02.Text == "")
            {
                MessageBox.Show("Debe completar este campo.", "Reporte de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_anio02.Focus();
                return;
            }
            if (Int32.Parse(this.txt_anio02.Text) > 2021 || Int32.Parse(this.txt_anio02.Text) < 2020)
            {
                MessageBox.Show("Debe ingresar un número de año válido", "Reporte de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_anio02.Focus();
                return;
            }
            NE_Ventas venta = new NE_Ventas();
            DataTable tabla = new DataTable();
            string fechadesde = "01/" + txt_mes02.Text + "/" + txt_anio02.Text;
            string fechahasta = "31/" + txt_mes02.Text + "/" + txt_anio02.Text;
            tabla = venta.BuscarVentasPorMesPorEmpleadoEst(fechadesde, fechahasta);

            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            rv02.LocalReport.ReportEmbeddedResource = "TP_PAV_3K3_GRUPO2.Formularios.Estadisticas.Ventas.RP_EstadisticasVEmpleado.rdlc";
            rv02.LocalReport.DataSources.Clear();
            rv02.LocalReport.DataSources.Add(datos);
            rv02.RefreshReport();
        }
    }
}
