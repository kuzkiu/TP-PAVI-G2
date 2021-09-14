using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_PAV_3K3_GRUPO2.Clases;

namespace TP_PAV_3K3_GRUPO2.Negocio
{
    class Ne_Barrio
    {
        Be_BaseDatos bd = new Be_BaseDatos();

        public int Buscar_idBarrio(string nombre)
        {
            string sql = @"Select B.id_barrio
                        From Barrio B
                        Where B.nombre_barrio = '" + nombre+ "'";

            DataTable tabla = new DataTable();
            tabla = bd.Consulta(sql);
            DataRow row = tabla.Rows[0];
            int id = (int)tabla.Rows[0][0];
            return id;

        }
    }
}
