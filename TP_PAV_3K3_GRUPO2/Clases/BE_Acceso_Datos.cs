using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Cargo using de SQLServer
using System.Data.SqlClient;
using System.Data;

namespace TP_PAV_3K3_GRUPO2.Clases
{
    class BE_Acceso_Datos
    {
        //Crea el caño de conexión entre la DB y el proyecto.
        SqlConnection Conexion = new SqlConnection();
        //Ahora creo el mensajero que va, busca y trae los datos
        SqlCommand Cmd = new SqlCommand();
        string cadena_conexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K3G02_2021;Persist Security Info=True;User ID=BD3K3G02_2021;Password=BDG02_2244";

        private void Conectar()
        {
            Conexion.ConnectionString = cadena_conexion;
            Conexion.Open();
            Cmd.Connection = Conexion;
            Cmd.CommandType = System.Data.CommandType.Text;
        }
        private void Cerrar()
        {
            Conexion.Close();
        }
        public DataTable EjecutarSelect (string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            tabla.Load(Cmd.ExecuteReader());
            Cerrar();
            return tabla;
        }
        public void Insertar(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            Cmd.ExecuteNonQuery();
            Cerrar();
        }
        public void Modificar(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            Cmd.ExecuteNonQuery();
            Cerrar();
        }
        public void Eliminar(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            Cmd.ExecuteNonQuery();
            Cerrar();
        }
        private void EjecutarNoSelect(string sql) //--> sirve para modificar o borrar
        {
            Conectar();
            Cmd.CommandText = sql;
            Cmd.ExecuteNonQuery();
            Cerrar();
        }

        public void DarBaja(string sql)
        {
            EjecutarNoSelect(sql);
        }




    }
}
