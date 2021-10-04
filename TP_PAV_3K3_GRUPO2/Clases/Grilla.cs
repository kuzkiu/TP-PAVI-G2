using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//para que funcione el datarid y grilla herede de ella
using System.Windows.Forms;
using System.Data;
using System.Drawing;


namespace TP_PAV_3K3_GRUPO2.Clases
{
    class Grilla : DataGridView
    {
        public int _tamannoLetraHeader { get { return tamLet; } set { tamLet = value; } }
        public FontStyle _formatoLetraHeader { get { return forLet; } set { forLet = value; } }
        int tamLet = 9;
        FontStyle forLet = FontStyle.Regular;

        // Nombre de columna, ancho de columna, IDC; 
        // Descripción, 200, I; Rubro, 100, I; Marca, 100, I; Precio de costo, 100, D; Precio de venta, 100, D; Stock, 100, D;
        public void formatear(string formato)
        {
            string[] datos_columna = formato.Split(';');
            //int cantida_columnas = datos_columna.Length;
            this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(Font.FontFamily, tamLet, forLet);
            for (int i = 0; i < datos_columna.Length; i++)
            {
                string[] datos = datos_columna[i].Split(',');
                this.Columns.Add("columna" + i.ToString(), datos[0].ToString());
                this.Columns[i].Width = int.Parse(datos[1].ToString());
                if (datos.Length == 3)
                {
                    switch (datos[2].Trim())
                    {
                        case "I":
                            this.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                            break;
                        case "D":
                            this.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            this.Columns[i].DefaultCellStyle.Format = "F2";
                            break;
                        case "C":
                            this.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        default:
                            this.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                            break;
                    }
                }
            }
            this.Columns[0].Visible = false;
        }
        public void Cargar(DataTable tabla)
        {
            this.Rows.Clear();
            for (int fila = 0; fila < tabla.Rows.Count; fila++)
            {
                this.Rows.Add();
                for (int columna = 0; columna < tabla.Columns.Count; columna++)
                {
                    this.Rows[fila].Cells[columna].Value = tabla.Rows[fila][columna];

                }
            }
            this.Columns[0].Visible = false;
        }
        


    }
}
