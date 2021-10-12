using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3K3_GRUPO2.Clases;

namespace TP_PAV_3K3_GRUPO2.Negocios
{
    class Ne_Sucursal
    {


        Be_BaseDatos bd = new Be_BaseDatos();

        public DataTable Buscar_Sucursal_Consulta(string id, string descripcion)
        {
            if (id == "" && descripcion == "")
            {
                string sql = @"SELECT S.id_sucursal, S.descripcion, D.calle, D.numero, D.piso, D.depto, B.nombre_barrio, L.nombre_localidad
                    FROM Sucursal S, Direccion D, Barrio B, Localidad L 
                    WHERE S.alta_logica = 1 AND S.id_direccion = D.id_direccion AND D.id_barrio = B.id_barrio 
                    AND B.id_localidad = L.id_localidad";
                DataTable tabla = bd.Consulta(sql);
                return tabla;
            }

            if (id == "" && descripcion != "")
            {
                string sql = @"SELECT S.id_sucursal, S.descripcion, D.calle, D.numero, D.piso, D.depto, B.nombre_barrio, L.nombre_localidad
                    FROM Sucursal S, Direccion D, Barrio B, Localidad L  
                    WHERE S.alta_logica = 1 AND S.id_direccion = D.id_direccion AND D.id_barrio = B.id_barrio 
                    AND B.id_localidad = L.id_localidad AND S.descripcion LIKE '%" + descripcion + "%'";
                DataTable tabla = bd.Consulta(sql);
                return tabla;
            }

            if (id != "" && descripcion == "")
            {
                string sql = @"SELECT S.id_sucursal, S.descripcion, D.calle, D.numero, D.piso, D.depto, B.nombre_barrio, L.nombre_localidad
                    FROM Sucursal S, Direccion D, Barrio B, Localidad L 
                    WHERE S.alta_logica = 1 AND S.id_direccion = D.id_direccion AND D.id_barrio = B.id_barrio 
                    AND B.id_localidad = L.id_localidad AND S.id_sucursal = '" + id + "' ";
                DataTable tabla = bd.Consulta(sql);
                return tabla;
            }

            if (id != "" && descripcion != "")
            {
                string sql = @"SELECT S.id_sucursal, S.descripcion, D.calle, D.numero, D.piso, D.depto, B.nombre_barrio, L.nombre_localidad
                    FROM Sucursal S, Direccion D, Barrio B, Localidad L 
                    WHERE S.alta_logica = 1 AND S.id_direccion = D.id_direccion AND D.id_barrio = B.id_barrio 
                    AND B.id_localidad = L.id_localidad AND S.id_sucursal = '" + id + "' AND S.descripcion LIKE '%" + descripcion + "%'";
                DataTable tabla = bd.Consulta(sql);
                return tabla;
            }

            DataTable backup = new DataTable();
            return backup;

        }

        public DataTable Buscar_Localidad_cmb()
        {
            string sql = @"SELECT L.nombre_localidad
                        FROM Localidad L
                        WHERE L.alta_logica =1";

            DataTable tabla = bd.Consulta(sql);
            return tabla;

        }

        public DataTable Buscar_Barrios_cmb(string nombre_localidad)
        {
            string sql = @"SELECT B.nombre_barrio
                        FROM Barrio B, Localidad L
                        WHERE B.id_localidad =L.id_localidad AND B.alta_logica = 1 AND L.nombre_localidad= '" + nombre_localidad + "'";
            DataTable tabla = bd.Consulta(sql);
            return tabla;

        }

        public DataTable Buscar_tipo_tel()
        {
            string sql = @"Select T.nombre
                        FROM Tipo_telefono T
                        WHERE T.alta_logica =1";
            DataTable tabla = bd.Consulta(sql);
            return tabla;
        }

        public bool Buscar_id_existente(string id)
        {
            string sql = @"SELECT S.id_sucursal
                        FROM Sucursal S
                        WHERE S.id_sucursal = '" + id + "'";
            DataTable tabla = bd.Consulta(sql);

            if (tabla.Rows.Count == 0) { return false; }
            return true;
        }

        public int Sugerir_id()
        {
            string sql = @"SELECT max(S.id_sucursal)
                        FROM Sucursal S";
            DataTable tabla = bd.Consulta(sql);

            return ((int)tabla.Rows[0][0]) + 1;
        }

       
        public string Buscar_id_direccion()
        {
            string sql = @"SELECT MAX (D.id_direccion)
                        FROM Direccion D";
            DataTable tabla = bd.Consulta(sql);
            int num = (int)tabla.Rows[0][0];
            string numero = (num + 1).ToString();

            return numero;

        }

        public string Buscar_id_barrio(string nombre, string localidad)
        {
            string sql = @"SELECT B.id_barrio
                        FROM Barrio B, Localidad L 
                        WHERE B.nombre_barrio = '" + nombre + "' AND L.id_localidad= B.id_localidad ";
            DataTable tabla = bd.Consulta(sql);
            return tabla.Rows[0][0].ToString();
        }

        public string Buscar_id_tipotel(string nombre)
        {
            string sql = @"SELECT T.id_tipoTelefono
                        FROM Tipo_telefono T
                        WHERE T.nombre ='" + nombre + "'";
            DataTable tabla = bd.Consulta(sql);
            return tabla.Rows[0][0].ToString();
        }

        public void Registrar_Sede(string id_direc, string id_barrio, string calle, string num_calle, string piso,
           string depto, string id_sucursal, string des, string num_tel, string id_tipotel)
        {
            string sql = @"INSERT INTO Direccion
                        VALUES ('" + id_direc + "','" + id_barrio + "','" + calle + "','" + num_calle + "','" + piso + "','" + depto + "', 1)" +
                        "INSERT INTO SUCURSAL " +
                        "VALUES('" + id_sucursal + "','" + id_direc + "', 1,'" + des + "')" +
                        "";
            if (num_tel != "")
            {
                sql += "INSERT INTO Telefono_Sucursal" +
                      " VALUES ('" + num_tel + "','" + id_tipotel + "','" + id_sucursal + "', 1)"; ;

            }

            bd.Consulta(sql);
        }

        public DataTable Buscar_sedes()
        {
            string sql = @"SELECT S.id_sucursal
                        FROM Sucursal S
                        WHERE S.alta_logica = 1";

            DataTable tabla = bd.Consulta(sql);
            return tabla;
        }

        public DataTable Buscar_datos_sede(string id) 
        {
            string sql = @"SELECT S.descripcion, D.calle, D.numero, D.piso, D.depto, B.nombre_Barrio, L.nombre_localidad
                        FROM Sucursal S, Direccion D, Barrio B, Localidad L
                        WHERE S.id_direccion= D.id_direccion AND D.id_barrio = B.id_barrio 
                        AND B.id_localidad = L.id_localidad AND S.id_sucursal = '"+ id+"'";
            DataTable tabla = bd.Consulta(sql);
            return tabla;
        }

        public string Buscar_iddirec_sucursal(string id) 
        {
            string sql = @"SELECT S.id_direccion
                        FROM Sucursal S
                        WHERE S.id_sucursal = '" + id+"'";
            DataTable tabla = bd.Consulta(sql);
            return tabla.Rows[0][0].ToString();
        }
        public void Baja_sucursal(string id_sucursal, string id_direccion) 
        {
            string sql = @"UPDATE SUCURSAL 
                         SET alta_logica = 0 
                        WHERE id_sucursal = '"+id_sucursal+"' " +
                        "UPDATE DIRECCION " +
                        "SET alta_logica = 0 " +
                        "WHERE id_direccion ='"+id_direccion+"' " +
                        "UPDATE Telefono_Sucursal " +
                        "SET alta_logica =0 " +
                        "WHERE id_sucursal = '"+id_sucursal+"' ";
            bd.Consulta(sql);
        }

        public void Modificar_sucursal(string id_direc_viejo, string id_direc_nuevo, string id_barrio, string calle,
            string num, string piso, string depto, string id_sucursal) 
        {
            string sql = @"UPDATE Direccion 
                        SET alta_logica = 0 
                        WHERE id_direccion = '"+ id_direc_viejo+"' " +
                        "INSERT INTO Direccion " +
                        "VALUES ('"+id_direc_nuevo+"','"+ id_barrio+"','"+calle+"','"+ num+"','"+piso+"','"+depto+"', 1) " +
                        "UPDATE Sucursal " +
                        "SET id_direccion = '"+ id_direc_nuevo+"' " +
                        "WHERE id_sucursal ='"+ id_sucursal+"' ";
            bd.Consulta(sql);
        }

        public DataTable Buscar_telefonos(string id) 
        {
            string sql = @"SELECT T.numero_telefono, P.nombre 
                        FROM Telefono_Sucursal T, Tipo_telefono P
                        WHERE T.id_sucursal = '"+id+"' AND T.id_tipo_telefono = P.id_tipoTelefono AND T.alta_logica = 1";
            DataTable tabla = bd.Consulta(sql);
            return tabla;
        }
        public bool Buscar_telefono_existente(string num,string id_Sdede) 
        {
            string sql = @"SELECT T.*
                        FROM Telefono_Sucursal T 
                        WHERE T.numero_telefono = '"+num+"' AND NOT (T.id_sucursal= '"+ id_Sdede+"') ";
            DataTable tabla = bd.Consulta(sql);
            if(tabla.Rows.Count == 0) 
            { return false; }
            else { return true; }
        }

        public void Registrar_Telefono(string num, string id_tipo, string id_suc) 
        {
            string sql = @"INSERT INTO Telefono_Sucursal 
                        VALUES('"+num+"','"+id_tipo+"','"+ id_suc+"',1)";
            bd.Consulta(sql);
        }

        public string Buscar_tipotel_telefono(string num) 
        {
            string sql = @"Select T.nombre 
                            FROM Tipo_telefono T, Telefono_Sucursal S 
                        WHERE T.id_tipoTelefono = S.id_tipo_telefono AND S.numero_telefono = '"+num+"'";
            DataTable tabla = bd.Consulta(sql);
            return tabla.Rows[0][0].ToString();
        }

        public void Modificar_telefono(string nuevo_num, string id_tipo, string viejo_num) 
        {
            string sql = @"UPDATE Telefono_Sucursal 
                        SET numero_telefono = '"+nuevo_num+"', id_tipo_telefono = '"+id_tipo+"' " +
                        "WHERE numero_telefono = '"+viejo_num+"' ";
            bd.Consulta(sql);
        }

        public void Eliminar_Telefono(string num_tel) 
        {
            string sql = @"UPDATE Telefono_Sucursal 
                        SET alta_logica = 0 
                        WHERE numero_telefono = '"+num_tel+"'";
            bd.Consulta(sql);
        }
    } 
}


        

