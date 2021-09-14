using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3K3_GRUPO2.Clases;
using System.Data;

namespace TP_PAV_3K3_GRUPO2.Negocio
{
    class Ne_Direccion
    {
        Be_BaseDatos bd = new Be_BaseDatos();

        public int Buscar_id_direccion()
        {
            string sql = @"Select max(D.id_direccion)
                        From Direccion D";
            DataTable tabla = new DataTable();
            tabla = bd.Consulta(sql);
            DataRow row = tabla.Rows[0];
            int id = (int)tabla.Rows[0][0];
            return id + 1;

        }

        public int Buscar_id_direccion_cliente(string cuil) 
        {
            string sql = @"Select D.id_direccion
                        From Direccion D, Clientes C 
                        WHERE C.cuil_cliente = '"+ cuil +"' AND C.id_direccion = D.id_direccion ";
            DataTable tabla = new DataTable();
            tabla = bd.Consulta(sql);
            DataRow row = tabla.Rows[0];
            int id = (int)tabla.Rows[0][0];
            return id;

        }
    }
}
