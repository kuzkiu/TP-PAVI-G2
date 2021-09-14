using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_PAV_3K3_GRUPO2.Clases;


namespace TP_PAV_3K3_GRUPO2.Negocio
{
    class Ne_TIpoDocumento
    {
        Be_BaseDatos bd = new Be_BaseDatos();

        public int Buscar_idTipoDoc(string nombre)
        {
            string sql = @"Select T.id_tipoDocumento
                        From Tipo_documento T
                        Where T.nombre ='" + nombre+"'";

            DataTable tabla = new DataTable();
            tabla = bd.Consulta(sql);
            DataRow row = tabla.Rows[0];
            int id = (int)tabla.Rows[0][0];
            return id;

        }

        public DataTable Buscar_nombreTipoDocumento() 
        {
            DataTable tabla_nombreTD = new DataTable();
            string sql = @"Select T.nombre
                        FROM Tipo_documento T";
            tabla_nombreTD = bd.Consulta(sql);
            return tabla_nombreTD;
        }
    }
}
