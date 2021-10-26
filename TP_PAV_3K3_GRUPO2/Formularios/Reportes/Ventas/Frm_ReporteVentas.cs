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

namespace TP_PAV_3K3_GRUPO2.Formularios.Reportes.Ventas
{
    public partial class Frm_ReporteVentas : Form
    {
        public Frm_ReporteVentas()
        {
            InitializeComponent();
        }

        private void Frm_ReporteVentas_Load(object sender, EventArgs e)
        {

        }

        private void Frm_ReporteVentas_Load_1(object sender, EventArgs e)
        {
            cmb_sucursal._Cargar();
            cmb_empleado._Cargar();
            this.rv01.RefreshReport();
            this.rv02.RefreshReport();
        }

        private void btn_generar01_Click(object sender, EventArgs e)
        {
            if (this.txt_mes.Text == "")
            {
                MessageBox.Show("Debe completar este campo.", "Reporte de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_mes.Focus();
                return;
            }
            if (Int32.Parse(this.txt_mes.Text) > 12 || Int32.Parse(this.txt_mes.Text) < 1)
            {
                MessageBox.Show("Debe ingresar un número de mes válido (entre 1 y 12)", "Reporte de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_mes.Focus();
                return;
            }

            if (Int32.Parse(this.txt_mes.Text) < 10)
            {
                int mes = Int16.Parse(txt_mes.Text);
                txt_mes.Text = mes.ToString("D2");

            }

            if (this.txt_anio.Text == "")
            {
                MessageBox.Show("Debe completar este campo.", "Reporte de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_anio.Focus();
                return;
            }
            if (Int32.Parse(this.txt_anio.Text) > 2021 || Int32.Parse(this.txt_anio.Text) < 2020)
            {
                MessageBox.Show("Debe ingresar un número de año válido", "Reporte de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_anio.Focus();
                return;
            }
            NE_Ventas venta = new NE_Ventas();
            DataTable tabla = new DataTable();
            int sucursal = Int32.Parse(cmb_sucursal.SelectedValue.ToString());
            string fechadesde = "01/" + txt_mes.Text + "/" + txt_anio.Text;
            string fechahasta = "31/" + txt_mes.Text + "/" + txt_anio.Text;
            tabla = venta.BuscarVentasPorMesPorSucursal(fechadesde, fechahasta, sucursal);

            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            rv01.LocalReport.ReportEmbeddedResource = "TP_PAV_3K3_GRUPO2.Formularios.Reportes.Ventas.Rp_VentasPorSucursal.rdlc";
            rv01.LocalReport.DataSources.Clear();
            rv01.LocalReport.DataSources.Add(datos);
            rv01.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_mes2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_anio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txt_mes2.Text == "")
            {
                MessageBox.Show("Debe completar este campo.", "Reporte de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_mes2.Focus();
                return;
            }
            if (Int32.Parse(this.txt_mes2.Text) > 12 || Int32.Parse(this.txt_mes2.Text) < 1)
            {
                MessageBox.Show("Debe ingresar un número de mes válido (entre 1 y 12)", "Reporte de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_mes2.Focus();
                return;
            }

            if (Int32.Parse(this.txt_mes2.Text) < 10)
            {
                int mes = Int16.Parse(txt_mes2.Text);
                txt_mes2.Text = mes.ToString("D2");

            }

            if (this.txt_anio2.Text == "")
            {
                MessageBox.Show("Debe completar este campo.", "Reporte de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_anio2.Focus();
                return;
            }
            if (Int32.Parse(this.txt_anio2.Text) > 2021 || Int32.Parse(this.txt_anio2.Text) < 2020)
            {
                MessageBox.Show("Debe ingresar un número de año válido", "Reporte de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_anio2.Focus();
                return;
            }
            NE_Ventas venta = new NE_Ventas();
            DataTable tabla = new DataTable();
            int empleado = Int32.Parse(cmb_empleado.SelectedValue.ToString());
            string fechadesde = "01/" + txt_mes2.Text + "/" + txt_anio2.Text;
            string fechahasta = "31/" + txt_mes2.Text + "/" + txt_anio2.Text;
            tabla = venta.BuscarVentasPorMesPorEmpleado(fechadesde, fechahasta, empleado);

            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            rv02.LocalReport.ReportEmbeddedResource = "TP_PAV_3K3_GRUPO2.Formularios.Reportes.Ventas.RP_VentasPorEmpleado.rdlc";
            rv02.LocalReport.DataSources.Clear();
            rv02.LocalReport.DataSources.Add(datos);
            rv02.RefreshReport();
        }

        private void txt_mes2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
