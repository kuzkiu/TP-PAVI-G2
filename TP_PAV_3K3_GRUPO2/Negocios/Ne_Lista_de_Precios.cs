using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_PAV_3K3_GRUPO2.Clases;
using System.Windows.Forms;

namespace TP_PAV_3K3_GRUPO2.Negocios
{
    class Ne_Lista_de_Precios
    {
        Be_BaseDatos bd = new Be_BaseDatos();

        public DataTable Buscar_CuilCliente()
        {
            string sql = @"Select C.cuil_cliente
                        From Clientes C";
            DataTable tabla_cuils = bd.Consulta(sql);
            return tabla_cuils;
        }

        public DataTable Buscar_Listas(string cuil, string fecha_inicio, bool activa) 
        {
            string sql="";
            DataTable to_monkee = new DataTable();
            if (cuil =="" && fecha_inicio == "" && activa == false) 
            {
                 sql = @"SELECT L.cuil_cliente, L.id_lista_precios, L.fecha_inicio, L.fecha_fin
                            FROM Lista_de_precios L
                            WHERE L.alta_logica = 1";
            }

            if (cuil != "" && activa == true && fecha_inicio=="") 
            {
                 sql = @"SELECT L.cuil_cliente, L.id_lista_precios, L.fecha_inicio, L.fecha_fin
                            FROM Lista_de_precios L
                            WHERE L.alta_logica = 1 AND L.fecha_fin IS NULL AND L.cuil_cliente LIKE '%"+cuil+"%'";
            }

            if (cuil == "" && activa == false && fecha_inicio != "")
            {
                sql = @"SELECT L.cuil_cliente, L.id_lista_precios, L.fecha_inicio, L.fecha_fin
                            FROM Lista_de_precios L
                            WHERE L.fecha_inicio >='" + fecha_inicio + "'" +
                           "AND L.alta_logica = 1";
            }

            if (cuil == "" && fecha_inicio == "" && activa == true)
            {
                sql = @"SELECT L.cuil_cliente, L.id_lista_precios, L.fecha_inicio, L.fecha_fin
                            FROM Lista_de_precios L
                            WHERE L.fecha_fin IS NULL AND L.alta_logica = 1";
            }

            if (cuil =="" && fecha_inicio !="" && activa == true) 
            {
                 sql = @"SELECT L.cuil_cliente, L.id_lista_precios, L.fecha_inicio, L.fecha_fin
                            FROM Lista_de_precios L
                            WHERE L.fecha_fin IS NULL AND L.fecha_inicio >='"+ fecha_inicio+"' AND L.alta_logica = 1";
            }

            if (cuil != ""  && fecha_inicio == "" && activa == false)
            {
                sql = @"SELECT L.cuil_cliente, L.id_lista_precios, L.fecha_inicio, L.fecha_fin
                            FROM Lista_de_precios L
                            WHERE  L.alta_logica = 1 AND L.cuil_cliente LIKE '%"+cuil+"%' ";
            }
            if (cuil != "" && fecha_inicio != "" && activa == false)
            {
                sql = @"SELECT L.cuil_cliente, L.id_lista_precios, L.fecha_inicio, L.fecha_fin
                            FROM Lista_de_precios L 
                            WHERE L.fecha_inicio >='" + fecha_inicio + "' AND L.alta_logica = 1" +
                            "AND L.cuil_cliente LIKE '%"+cuil+"%'";
            }
            if (cuil != "" && fecha_inicio != "" && activa == true)
            {
                sql = @"SELECT L.cuil_cliente, L.id_lista_precios, L.fecha_inicio, L.fecha_fin
                            FROM Lista_de_precios L 
                            WHERE  L.fecha_inicio >= '" + fecha_inicio + "' " +
                            "AND  L.alta_logica = 1 AND L.cuil_cliente LIKE '%"+cuil+"%' AND L.fecha_fin IS NULL ";
            }
            to_monkee = bd.Consulta(sql);
            return to_monkee;
        }


        public DataTable Buscar_idLista_txtAdm(string cuil)
        {
            string sql = @"Select C.id_lista, L.fecha_fin
                    From Clientes C, Lista_de_precios L
                    Where C.cuil_cliente = '" + cuil + "'AND C.id_lista=L.id_lista_precios AND (L.fecha_fin  IS Null )";
            DataTable tabla_id = bd.Consulta(sql);
            return tabla_id;
        }
        public DataTable Buscar_ArticulosLista_Adm(string id)
        {
            string sql = @"Select A.id_articulo, A.descripcion, L.precio_dif
                        FROM Articulos A, Detalle_lista L
                        WHERE A.id_articulo = L.id_articulo AND L.id_lista = '" + id + "' AND L.alta_logica = 1";
            DataTable tabla_cuils = bd.Consulta(sql);
            return tabla_cuils;

        }

        public DataTable Buscar_cuils_Seleccion() 
        {
            string sql = @"Select C.cuil_cliente
                        From Clientes C
                        Where C.alta_logica=1";
            DataTable tabla_cuils = bd.Consulta(sql);
            return tabla_cuils;
        }

        public String Buscar_Razon_Cliente(string cuil) 
        {
            string sql = @"SELECT C.razon_social
                        FROM Clientes C
                        WHERE C.cuil_cliente ='"+cuil+"'";
            DataTable tabla_razon = bd.Consulta(sql);
            return tabla_razon.Rows[0]["razon_social"].ToString();

        }

        public bool Buscar_id_existente(string id) 
        {
            string sql = @"Select L.id_lista_precios
                          From Lista_de_precios L
                           WHERE L.id_lista_precios ='"+id+"'";
            DataTable tabla = bd.Consulta(sql);

            if (tabla.Rows.Count == 0) 
            {
                return false;
            }

            else 
            {
                return true;
            }
        }

        public int Sugerir_id() 
        {
            string sql = @"Select Max(L.id_lista_precios)
                        FROM Lista_de_precios L";

            DataTable tabla = bd.Consulta(sql);

            return (int)tabla.Rows[0][0] + 1;
        }

        public DataTable Buscar_DatosArticulo(string id) 
        {
            string sql = @"SELECT A.descripcion, A.precio_venta
                        FROM ARTICULOS A
                        WHERE id_articulo ='"+id+"'";
            DataTable tabla = bd.Consulta(sql);
            return tabla;
        }

        public DataTable Buscar_IDArticulos() 
        {
            string sql = @"SELECT A.id_articulo
                            FROM Articulos A
                            WHERE A.alta_logica = 1";
            DataTable tabla = bd.Consulta(sql);

            return tabla;
        }

       

        //registramos fechafin de la lista vigente

        public void Baja_lista_Anterior(string cuil) 
        {
            string sql = @"UPDATE Lista_de_precios 
                        SET fecha_fin = CONVERT(DATE, GETDATE())
                        WHERE Lista_de_precios.cuil_cliente = '"+cuil+"' AND Lista_de_precios.fecha_fin IS NULL";
            bd.Consulta(sql);
        }

        // registrar nueva lista
        public void Reg_Nueva_Lista(string id, string cuil) 
        {
            string sql = @"INSERT INTO Lista_de_precios 
                        VALUES ('"+id+ "', CONVERT(DATE, GETDATE()), NULL, 1, '"+cuil+"')";
            bd.Consulta(sql);
        }

        //registrar los detalles
        public void Reg_detalle_lista(string id_lista, string id_articulo, string precio) 
        {
            string sql = @"INSERT INTO Detalle_lista
                         VALUES ('"+id_lista+"','"+id_articulo+"','"+precio+"',1)";
            bd.Consulta(sql);
        }
    }
}
