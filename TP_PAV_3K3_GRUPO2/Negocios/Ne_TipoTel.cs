using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3K3_GRUPO2.Clases;
using System.Data;

namespace TP_PAV_3K3_GRUPO2.Negocio
{
    class Ne_TipoTel
    {
        Be_BaseDatos bd = new Be_BaseDatos();

        public int Buscar_id(string nombre)
        {
            if (nombre != "") 
            { 
            string sql = @"Select T.id_tipoTelefono
                        From Tipo_telefono T
                        Where T.nombre = '" + nombre + "'";

            DataTable tabla = new DataTable();
            tabla = bd.Consulta(sql);
            DataRow row = tabla.Rows[0];
            int id = (int)tabla.Rows[0][0];
            return id;
            }

            return -1;
            
        }

        public DataTable Buscar_nombreTipoTel() 
        {
            DataTable tabla_nombreTT = new DataTable();
            string sql = @"Select T.nombre
                        FROM Tipo_telefono T";
            tabla_nombreTT = bd.Consulta(sql);
            return tabla_nombreTT;
        }



    }
}
