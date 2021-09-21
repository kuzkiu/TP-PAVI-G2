using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3K3_GRUPO2.Clases;
using System.Data;

namespace TP_PAV_3K3_GRUPO2.Negocios
{
    class NE_Rubro
    {
        public string id_Rubro_ { get; set; }
        public string nombre_Rubro { get; set; }

        BE_Acceso_Datos BDD = new BE_Acceso_Datos();

        public void Insertar()
        {
            string sqlInsert = "";
            sqlInsert = @"INSERT INTO Rubro (id_rubro, nombre, alta_logica) VALUES ('" + id_Rubro_ + "','" + nombre_Rubro + "', 1)";
            BDD.Insertar(sqlInsert);
        }


        public void BorrarReg()
        {
            string sqlBorrar = "";
            sqlBorrar += @"DELETE FROM Rubro WHERE id_rubro =" + id_Rubro_;
            BDD.DarBaja(sqlBorrar);
        }

    }
}
