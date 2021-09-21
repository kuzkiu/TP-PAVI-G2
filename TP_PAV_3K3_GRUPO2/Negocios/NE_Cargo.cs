using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using TP_PAV_3K3_GRUPO2.Clases;

namespace TP_PAV_3K3_GRUPO2.Negocios
{
    class NE_Cargo
    {
        public string Cod_cargo { get; set; }
        public string denominacion { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public void Insertar()
        {
            string sqlInsert = "";
            sqlInsert += @"INSERT INTO Cargo (Cod_cargo, denominacion, alta_logica) VALUES ('" + Cod_cargo + "','" + denominacion + "', 1)";
            //MessageBox.Show("se ha realizado una accion del tipo: " + sqlInsert);
            _BD.Insertar(sqlInsert);  
        }

        public void BorrarReg()
        {
            string sqlBorrar = "";
            sqlBorrar += @"DELETE FROM Cargo WHERE Cod_cargo =" + Cod_cargo;
            _BD.DarBaja(sqlBorrar);
        }


    }
}
