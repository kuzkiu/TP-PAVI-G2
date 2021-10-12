using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3K3_GRUPO2;
using System.Data;

namespace TP_PAV_3K3_GRUPO2.Negocios
{
    class NE_Empleados
    {
        public string Localidad_E { get; set; }
        public string BarrioE { get; set; }
        public string Piso_E { get; set; }
        public string Calle_E { get; set; }
        public string Cargo_E { get; set; }
        public string FechaIng_E { get; set; }


        public string FechaNac_E { get; set; }

        public string Apellido_E { get; set; }
        public string Nombre_E { get; set; }
        public string TipoDoc_E { get; set; }

        public string NroDocumento_E { get; set; }
        Clases.BE_Acceso_Datos _BD = new Clases.BE_Acceso_Datos();

        public void Insertar(String numerodoc, String nombre, String apellido_e, String FechaNac_E, String FechaIng_E,
            String id_cargo, String id_tipodocu, String id_direc)  //String id_tipodocu, String id_cargo, String Nombre_E,String Apellido_E)
        {
            //Convert.ToDateTime(FechaIng_E);
            //Convert.ToDateTime(FechaNac_E);
            string sqlInsert = "";
            sqlInsert = @"INSERT INTO Empleado (nro_doc_emp, id_tipoDocumento, nombre, 
            apellido, fecha_nac, fecha_ingreso, codigo_cargo, id_direccion, alta_logica) VALUES (";
            sqlInsert += " " + numerodoc;
            sqlInsert += ", " + id_tipodocu;
            sqlInsert += ", '" + nombre + "'";
            sqlInsert += ", '" + apellido_e + "'";
            sqlInsert += ",'" + FechaNac_E + "'";
            sqlInsert += ",'" + FechaIng_E + "'";
            sqlInsert += ", " + id_cargo;
            sqlInsert += ", " + id_direc;
            sqlInsert += ",1)";


            _BD.Insertar(sqlInsert);
        }
        //Combobox
        public DataTable Buscar_nombreTipoDocumento()
        {
            DataTable tabla_nombreTD = new DataTable();
            string sql = @"Select T.nombre
                        FROM Tipo_documento T";
            tabla_nombreTD = _BD.Consulta(sql);
            return tabla_nombreTD;
        }
        public DataTable Buscar_nombreTipoCargo()
        {
            DataTable tabla_nombreTT = new DataTable();
            string sql = @"Select T.denominacion
                        FROM Cargo T";
            tabla_nombreTT = _BD.Consulta(sql);
            return tabla_nombreTT;
        }

        public int Buscar_idTipoDoc(string nombre)
        {
            if (nombre != "")
            {
                string sql = @"Select T.id_tipoDocumento
                        From Tipo_Documento T
                        Where T.nombre = '" + nombre + "'";

                DataTable tabla = new DataTable();
                tabla = _BD.Consulta(sql);
                DataRow row = tabla.Rows[0];
                int id = (int)tabla.Rows[0][0];
                return id;
            }

            return -1;

        }

        public int Buscar_idTipoCargo(string nombre)
        {
            if (nombre != "")
            {
                string sql = @"Select T.Cod_cargo
                        From Cargo T
                        Where T.denominacion = '" + nombre + "'";

                DataTable tabla = new DataTable();
                tabla = _BD.Consulta(sql);
                DataRow row = tabla.Rows[0];
                int id = (int)tabla.Rows[0][0];
                return id;
            }

            return -1;

        }


        public int Buscar_idBarrio(string nombre)
        {
            string sql = @"Select B.id_barrio
                        From Barrio B
                        Where B.nombre_barrio = '" + nombre + "'";

            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            DataRow row = tabla.Rows[0];
            int id = (int)tabla.Rows[0][0];
            return id;

        }
        public int Buscar_id_direccion()
        {
            string sql = @"Select max(D.id_direccion)
                        From Direccion D";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            DataRow row = tabla.Rows[0];
            int id = (int)tabla.Rows[0][0];
            return id + 1;

        }
        //Registrar empleado

        public void Registrar_EmpleadoFinal(String NroDocumento_E, String Nombre_E, String Apellido_E, String FechaNac_E,
            String FechaIng_E, String id_cargo, String id_tipodocu, String id_direc, String id_bar, String calle, String num_calle,
            String piso, String depto)
        {
            NE_Empleados clie = new NE_Empleados();
            Registrar_Direccion_Empleado(id_direc, id_bar, calle, num_calle, piso, depto);
            clie.Insertar(NroDocumento_E, Nombre_E, Apellido_E, FechaNac_E, FechaIng_E, id_cargo, id_tipodocu, id_direc);

        }
        public void Registrar_Direccion_Empleado(string id_direccion, string id_barrio, string calle, string numero, string piso, string depto)
        {


            string sql = @"INSERT INTO Direccion
                        Values('" + id_direccion + "','" + id_barrio + "','" + calle + "','" + numero + "','" + piso + "','" + depto + "', 1)";
            _BD.Consulta(sql);

        }


        public DataTable Buscar_Empleado(string id, string documento)
        {

            string sql = @"SELECT T.nombre, E.nro_doc_emp, E.nombre, E.apellido, E.fecha_nac, E.fecha_ingreso, 
C.denominacion,B.nombre_barrio, D.calle,D.numero,D.piso,D.depto, E.alta_logica FROM Barrio B, Empleado E, Tipo_Documento T, Cargo C, Direccion D WHERE E.id_tipoDocumento = T.id_tipoDocumento
                AND " + "E.id_tipoDocumento = '" + id + "' AND E.nro_doc_emp = '" + documento + "' " +
            "AND E.codigo_cargo = C.Cod_cargo AND E.id_direccion = D.id_direccion AND D.id_barrio = B.id_barrio AND E.alta_logica = '1'";

            return _BD.Consulta(sql);



            DataTable tabla_nul = new DataTable();
            return tabla_nul;
        }
        public DataTable BuscarDocumentos(string id_tipodoc)
        {
            string sql = @"SELECT E.nro_doc_emp
                        FROM Empleado E
                        WHERE E.alta_logica = 1 AND E.id_tipoDocumento = '" + id_tipodoc + "'";

            return _BD.Consulta(sql);

        }
        public DataTable BuscarEmpleadoModificacion(string numdoc)
        {
            string sql = @"SELECT E.nombre, E.apellido, E.fecha_nac, E.fecha_ingreso, C.denominacion, D.calle, D.numero,
            D.piso, D.depto, B.nombre_barrio, L.nombre_localidad
            FROM Empleado E, Cargo C, Direccion D, Barrio B, Localidad L WHERE E.codigo_cargo = C.Cod_cargo AND
            E.id_direccion = D.id_direccion AND D.id_barrio = B.id_barrio AND B.id_localidad = L.id_localidad AND E.nro_doc_emp ='" + numdoc + "'";
            /*string sql = @"SELECT C.razon_social, C.nro_documento, T.nombre, D.calle, D.numero, D.piso, D.depto, B.nombre_barrio, L.nombre_localidad 
                   FROM Clientes C, Barrio B, Localidad L, Tipo_documento T, Direccion D  
                   WHERE C.id_direccion = D.id_direccion AND D.id_barrio= B.id_barrio AND B.id_localidad = L.id_localidad AND
                   C.id_tipoDocumento = T.id_tipoDocumento AND C.cuil_cliente LIKE '%" + cuil + "%'";
            */
            return _BD.Consulta(sql);
        }

        public DataTable Buscar_Cargo()
        {
            DataTable tabla_cargo = new DataTable();
            string sql = @"Select C.denominacion
                        FROM Cargo C
                        WHERE C.alta_logica = 1";
            tabla_cargo = _BD.Consulta(sql);
            return tabla_cargo;

        }
        public DataTable Buscar_NombreBarrio(string nombre_localidad)
        {
            DataTable tabla_nombrebarrio = new DataTable();
            string sql = @"Select B.nombre_barrio
                        FROM Barrio B, Localidad L
                        WHERE L.id_localidad = B.id_localidad AND L.nombre_localidad = '" + nombre_localidad + "'";
            tabla_nombrebarrio = _BD.Consulta(sql);
            return tabla_nombrebarrio;

        }
        public DataTable Buscar_Localidad()
        {
            DataTable tabla_nombrelocalidad = new DataTable();
            string sql = @"Select Localidad.nombre_localidad
                        FROM Localidad
                        WHERE Localidad.alta_logica = 1";
            tabla_nombrelocalidad = _BD.Consulta(sql);
            return tabla_nombrelocalidad;

        }
        public int Buscar_id_direccion_empleado(string nrodoc, string tipodoc)
        {
            string sql = @"Select D.id_direccion
                        From Direccion D, Empleado E 
                        WHERE E.id_tipoDocumento = '" + tipodoc + "'AND E.nro_doc_emp = '" + nrodoc + 
                        "' AND E.id_direccion = D.id_direccion ";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            DataRow row = tabla.Rows[0];
            int id = (int)tabla.Rows[0][0];
            return id;

        }
        public void modificar_empleado_total(string id_tipodocu, string NroDocumento_E, string Nombre_E, 
            string Apellido_E, string FechaNac_E,string FechaIng_E,string id_cargo,
                   string id_direc,string txt_calleE, string txt_numeroE, string txt_deptoE, string txt_pisoE, string id_barrio)
        {
            modificar_empleado(id_tipodocu, NroDocumento_E, Nombre_E, Apellido_E, FechaNac_E, FechaIng_E, id_cargo);
            modificar_Direccion(id_direc, txt_calleE, txt_numeroE, txt_deptoE, txt_pisoE, id_barrio);
                

        }
        public void modificar_empleado(string id_tipodocu, string NroDocumentoE, string Nombre_E, string Apellido_E,
            string FechaNac_E, string FechaIng_E, string id_cargo
            )
        {
            string sql = @"UPDATE Empleado 
                        SET nombre = '" +Nombre_E+ "', apellido = '"+Apellido_E+ "',fecha_nac = '"+FechaNac_E+"', fecha_ingreso = '"+FechaIng_E+"', codigo_cargo = '"+id_cargo+"' WHERE id_tipoDocumento = '"+id_tipodocu+"' AND nro_doc_emp = '"+NroDocumentoE+"'"; 
                           
            _BD.Consulta(sql);
        }
        public void modificar_Direccion(string id_direc, string calle, string num_calle, string depto, string piso, string id_barrio)
        {
            string sql = @"UPDATE Direccion 
                          SET id_barrio = " + id_barrio + ", calle = '" + calle + "',numero=" + num_calle + ", piso =" + piso + ", depto = '" + depto + "'" +
                         "Where id_direccion =" + id_direc;
            _BD.Consulta(sql);
        }
        public DataTable BuscarEmpleadoBaja(string tipodocu, string documento)
        {
            string sql = @"SELECT E.nombre, E.apellido, E.fecha_nac, E.fecha_ingreso, C.denominacion,D.calle, D.numero, D.piso, D.depto, B.nombre_barrio, L.nombre_localidad
FROM Empleado E, Cargo C,  Barrio B, Localidad L, Tipo_documento T, Direccion D
WHERE E.id_direccion = D.id_direccion AND D.id_barrio= B.id_barrio AND B.id_localidad = L.id_localidad AND
  E.id_tipoDocumento = T.id_tipoDocumento AND  C.Cod_Cargo = E.codigo_cargo 
    AND E.nro_doc_emp = '" + documento+"'AND E.id_tipoDocumento = '"+tipodocu+"'" ;

            return _BD.Consulta(sql);

        }
        public void BajaEmpleado(string tipodocu,string documento)
        {
            String sql = @"Update EMPLEADO
                        SET alta_logica = 0
                        WHERE Empleado.nro_doc_emp = '" + documento + "' AND Empleado.id_tipoDocumento = '"+tipodocu+"'";
            _BD.Consulta(sql);

        }
        /*
        public void Insertar()
        {
            string sqlInsert = "";
            sqlInsert = @"INSERT INTO articulo (id_articulo, id_rubro, id_marca, 
            descripcion, precio_costo, precio_venta, stock_actual) VALUES (";
            sqlInsert += 4;
            sqlInsert += ", " + id_rubro;
            sqlInsert += ", " + id_marca;
            sqlInsert += ", '" + descripcion + "'";
            sqlInsert += ", " + precio_costo;
            sqlInsert += ", " + precio_venta;
            sqlInsert += ", " + stock_actual + ")";
            _BD.Insertar(sqlInsert);
        }*/
    }
}