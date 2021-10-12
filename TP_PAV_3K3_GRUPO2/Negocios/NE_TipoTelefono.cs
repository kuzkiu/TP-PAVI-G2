using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3K3_GRUPO2.Clases;

namespace TP_PAV_3K3_GRUPO2.Negocios
{
    class NE_TipoTelefono
    {

        public string id_tipoTel { get; set; }
        public string nombre_tipoTel { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
        Be_BaseDatos bd = new Be_BaseDatos();

        public void Insertar()
        {
            string sqlInsert = "";
            sqlInsert += @"INSERT INTO Tipo_telefono (id_tipoTelefono, nombre, alta_logica) VALUES ('" + id_tipoTel + "','" + nombre_tipoTel + "', 1)";
            //MessageBox.Show("se ha realizado una accion del tipo: " + sqlInsert);
            _BD.Insertar(sqlInsert);
        }


        public void BorrarReg()
        {
            string sqlBorrar = "";
            sqlBorrar += @"DELETE FROM Tipo_telefono WHERE id_tipoTelefono =" + id_tipoTel;
            _BD.DarBaja(sqlBorrar);
        }

        public void modificarTipoTel()
        {
            string sqlModificar = "";
            sqlModificar = @"UPDATE Tipo_telefono SET ";
            sqlModificar += "id_tipoTelefono = " + id_tipoTel;
            sqlModificar += ", nombre = '" + nombre_tipoTel + "'";
            sqlModificar += "WHERE id_tipoTelefono =" + id_tipoTel;
            _BD.Modificar(sqlModificar);
        }

        public DataTable BuscarTipoTelefono(string id, string nombre)
        {
            if (id != "" & nombre != "")
            {
                string sql = @"SELECT t.id_tipoTelefono,t.nombre FROM Tipo_telefono t WHERE t.id_tipoTelefono LIKE '%" + id + "%' AND t.nombre LIKE '%" + nombre + "%' AND c.alta_logica = 1";
                return bd.Consulta(sql);
            }

            if (id != "" & nombre == "")
            {
                string sql = @"SELECT t.id_tipoTelefono,t.nombre FROM Tipo_telefono t WHERE t.id_tipoTelefono LIKE '%" + id + "%' AND t.nombre LIKE '%" + nombre + "%' AND c.alta_logica = 1";
                return bd.Consulta(sql);
            }

            if (id == "" & nombre != "")
            {
                string sql = @"SELECT t.id_tipoTelefono,t.nombre FROM Tipo_telefono t WHERE t.id_tipoTelefono LIKE '%" + id + "%' AND t.nombre LIKE '%" + nombre + "%' AND c.alta_logica = 1";
                return bd.Consulta(sql);
            }

            DataTable tabla_nul = new DataTable();
            return tabla_nul;

        }









    }
}
