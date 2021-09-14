using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TP_PAV_3K3_GRUPO2.Clases
{
    class Be_BaseDatos
    {
        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        string Cadena_conexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K3G02_2021;Persist Security Info=True;User ID=BD3K3G02_2021;Password=BDG02_2244";

        private void Conectar()
        {
            Conexion.ConnectionString = Cadena_conexion;
            Conexion.Open();
            Cmd.Connection = Conexion;
            Cmd.CommandType = System.Data.CommandType.Text;
        }

        public DataTable Consulta(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            tabla.Load(Cmd.ExecuteReader());
            Desconectar();
            return tabla;
        }

        private void Desconectar()
        {
            Conexion.Close();
        }
    }
}
