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

        public void Insertar(String numerodoc, String nombre,String apellido_e, String FechaNac_E, String FechaIng_E, 
            String id_cargo, String id_tipodocu,String id_direc)  //String id_tipodocu, String id_cargo, String Nombre_E,String Apellido_E)
        {
            //Convert.ToDateTime(FechaIng_E);
            //Convert.ToDateTime(FechaNac_E);
            string sqlInsert = "";
            sqlInsert = @"INSERT INTO Empleado (nro_doc_emp, id_tipoDocumento, nombre, 
            apellido, fecha_nac, fecha_ingreso, codigo_cargo, id_direccion, alta_logica) VALUES (";
            sqlInsert += " " +numerodoc;
            sqlInsert += ", "+id_tipodocu;
            sqlInsert += ", '" +nombre+"'";
            sqlInsert += ", '" +apellido_e+ "'";
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