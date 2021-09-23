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
        public string id_articulo { get; set; }
        public string id_rubro { get; set; }
        public string id_marca { get; set; }
        public string descripcion { get; set; }
        public string precio_costo { get; set; }
        public string precio_venta { get; set; }
        public string stock_actual { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

   public DataTable BuscarArticulos()
        {
          
            string sql = @"SELECT A.id_articulo, A.descripcion, R.nombre, M.nombre, A.precio_costo,
            A.precio_costo, A.stock_actual FROM Articulos AS A
            INNER JOIN Rubro AS R ON A.id_rubro = R.id_rubro
            INNER JOIN Marca AS M ON A.id_marca = M.id_marca
            WHERE  A.Alta_logica = 1";
            DataTable tabla = new DataTable();
            return _BD.EjecutarSelect(sql);
            
 
        }
        public void Insertar()
        {
            string ultimoID = @"SELECT MAX(id_articulo) maximo FROM articulos";
            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(ultimoID);
            int MaxID = 0;
            if (tabla.Rows.Count > 0)
            {
                MaxID = Convert.ToInt32(tabla.Rows[0][0]) + 1;
            }

            string sqlInsert = "";
            sqlInsert = @"INSERT INTO articulos (id_articulo, id_rubro, id_marca, 
            descripcion, precio_costo, precio_venta, stock_actual, alta_logica) VALUES (";
            sqlInsert +=  MaxID;
            sqlInsert += ", " + id_rubro;
            sqlInsert += ", "+ id_marca;
            sqlInsert += ", '"+ descripcion +"'";
            sqlInsert += ", "+ precio_costo;
            sqlInsert += ", " + precio_venta;
            sqlInsert += ", " + stock_actual;
            sqlInsert += ", " + 1 + ")";
            _BD.Insertar(sqlInsert);
        }
        public void Modificar()
        {
            string sqlModificar = "";
            sqlModificar = @"UPDATE articulos SET ";
            sqlModificar += "id_rubro = " + id_rubro;
            sqlModificar += ", id_marca = " + id_marca;
            sqlModificar += ", descripcion = '" + descripcion + "'";
            sqlModificar += ", precio_costo = '" + precio_costo + "'";
            sqlModificar += ", precio_venta = '" + precio_venta + "'";
            sqlModificar += ", stock_actual = " + stock_actual;
            sqlModificar += " WHERE id_articulo = " + id_articulo;
            _BD.Modificar(sqlModificar);
        }
        public void Eliminar()
        {
            string sqlEliminar = "";
            sqlEliminar = @"UPDATE articulos SET ";
            sqlEliminar += "id_rubro = " + id_rubro;
            sqlEliminar += ", id_marca = " + id_marca;
            sqlEliminar += ", descripcion = '" + descripcion + "'";
            sqlEliminar += ", precio_costo = '" + precio_costo + "'";
            sqlEliminar += ", precio_venta = '" + precio_venta + "'";
            sqlEliminar += ", stock_actual = " + stock_actual;
            sqlEliminar += ", alta_logica = " + 0;
            sqlEliminar += " WHERE id_articulo = " + id_articulo;
            _BD.Eliminar(sqlEliminar);
        }
    }

}
