using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3K3_GRUPO2.Clases;
using System.Data;

namespace TP_PAV_3K3_GRUPO2.Negocios
{
    class NE_Ventas
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable BuscarArticulos()
        {

            string sql = @"SELECT A.id_articulo, A.descripcion, A.precio_costo, A.stock_actual FROM Articulos AS A
            WHERE  A.Alta_logica = 1";
            DataTable tabla = new DataTable();
            return _BD.EjecutarSelect(sql);


        }
    }
}
