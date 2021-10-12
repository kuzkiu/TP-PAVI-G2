using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace TP_PAV_3K3_GRUPO2.Negocios
{
    class NE_Barrio
    {
        Clases.BE_Acceso_Datos _BD = new Clases.BE_Acceso_Datos();

        public DataTable Buscar_Localidad()
        {
            DataTable tabla_nombrelocalidad = new DataTable();
            string sql = @"Select Localidad.nombre_localidad
                        FROM Localidad
                        WHERE Localidad.alta_logica = 1";
            tabla_nombrelocalidad = _BD.Consulta(sql);
            return tabla_nombrelocalidad;

        }
        public DataTable BuscarIds()
        {
            string sql = @"SELECT Barrio.id_barrio
                        FROM Barrio
                        WHERE Barrio.alta_logica = 1";

            return _BD.Consulta(sql);

        }
        public int Buscar_idLocalidad(string localidad)
        {
            string sql = @"Select L.id_localidad
                        From Localidad L
                        Where L.nombre_localidad ='" + localidad + "'";

            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            DataRow row = tabla.Rows[0];
            int id = (int)tabla.Rows[0][0];
            return id;

        }
        public void RegistrarBarrio(string id_localidad, string id_barrio, string nombrebarrio)
        {
            string sql = @"INSERT INTO Barrio
                            VALUES ('" + id_barrio + "','" + nombrebarrio + "','" + id_localidad + "', 1)";
            _BD.Consulta(sql);
        }
        public DataTable Buscar_barrio(string id_barrio, string nombre_barrio)
        {
            if (id_barrio != "" & nombre_barrio == "")
            {
                string sql = @"SELECT B.nombre_barrio, L.nombre_localidad FROM Barrio B, Localidad L WHERE B.id_barrio = '" + id_barrio + "'AND B.id_localidad = L.id_localidad AND B.alta_logica = '1'";
                return _BD.Consulta(sql);
            }
            if (id_barrio == "" & nombre_barrio != "")
            {
                string sql = @"SELECT B.nombre_barrio, L.nombre_localidad FROM Barrio B, Localidad L WHERE B.nombre_barrio = '" + nombre_barrio + "'AND B.id_localidad = L.id_localidad AND B.alta_logica = '1'";
                return _BD.Consulta(sql);
            }
            if (id_barrio != "" & nombre_barrio != "")
            {
                string sql = @"SELECT B.nombre_barrio, L.nombre_localidad FROM Barrio B, Localidad L WHERE B.id_barrio = '" + id_barrio +"'AND B.nombre_barrio = '" + nombre_barrio + "'AND B.id_localidad = L.id_localidad AND B.alta_logica = '1'";
                return _BD.Consulta(sql);
            }




            DataTable tabla_nul = new DataTable();
            return tabla_nul;
        }
        public DataTable BuscarBarrioModificacion(string idbarrio)
        {
            string sql = @"SELECT B.nombre_barrio, L.nombre_localidad FROM Barrio B, Localidad L WHERE L.id_localidad = B.id_localidad AND B.id_barrio = '"+idbarrio+"'";

            return _BD.Consulta(sql);
        }
        public void modificar_barrio(string idbarrio, string nombrebarrio, string idlocalidad
    )
        {
            string sql = @"UPDATE Barrio 
                        SET nombre_barrio = '" + nombrebarrio + "', id_localidad = '" + idlocalidad + "' WHERE id_barrio = '" + idbarrio + "' ";

            _BD.Consulta(sql);
        }
        public void eliminar_barrio(string idbarrio
)
        {
            string sql = @"UPDATE Barrio 
                        SET alta_logica = 0 WHERE id_barrio = '"+idbarrio+"' ";

            _BD.Consulta(sql);
        }


    }
}
