using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3K3_GRUPO2.Clases;
using System.Data;

namespace TP_PAV_3K3_GRUPO2.Negocios
{
    class NE_Articulos
    {
        public string Localidad_E { get; set; }
        public string BarrioE { get; set; }
        public string Piso_E { get; set; }
        public string Calle_E { get; set; }
        public string Cargo_E { get; set; }
        public string FechaIng_E { get; set; }
        public string FechaNac_E{ get; set; }

        public string Apellido_E { get; set; }
        public string Nombre_E { get; set; }
        public string TipoDoc_E { get; set; }

        public string NroDocumento_E { get; set; }
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public void Insertar()
        {
            string sqlInsert = "";
            sqlInsert = @"INSERT INTO empleado (nro_doc_emp, id_tipoDocumento, nombre, 
            apellido, fecha_nac, fecha_ingreso , codigo_cargo) VALUES (";
            sqlInsert += 4;
            sqlInsert += ", " + NroDocumento_E;
            sqlInsert += ", " + TipoDoc_E;
            sqlInsert += ", '" + Nombre_E + "'";
            sqlInsert += ", " + Apellido_E;
            sqlInsert += ", " + FechaNac_E;
            sqlInsert += ", " + FechaIng_E;
            sqlInsert += ", " + Cargo_E + ")";

            
            _BD.Insertar(sqlInsert);
        }