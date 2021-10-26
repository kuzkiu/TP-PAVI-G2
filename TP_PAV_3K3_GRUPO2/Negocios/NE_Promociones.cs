using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3K3_GRUPO2.Clases;

namespace TP_PAV_3K3_GRUPO2.Negocios
{
    class NE_Promociones
    {
        public string id_promocion { get; set; }
        public string fecha_inicio { get; set; }
        public string fecha_fin { get; set; }
        public string precio_costo { get; set; }
        public string total { get; set; }
        public string stock { get; set; }
        public string alta_logica { get; set; }
        public string id_articulo { get; set; }
        public string cantidad { get; set; }
        public string precio_dif { get; set; }


        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public string FormatearDato(string dato, string TipoDato)
        {
            switch (TipoDato)
            {
                case "texto":
                case "System.String":
                    return "'" + dato.Trim() + "'";
                case "numero":
                case "System.Int16":
                case "System.Int32":
                case "System.Int64":
                case "System.Double":
                    return dato.Replace(",", ".").Trim();
                case "fecha":
                default:
                    return dato;
            }
        }

        public DataTable BuscarPorIdPromocion(string idPromo)
        {
            string sql = @"SELECT p.id_promocion, p.fecha_inicio, p.total, a.id_articulo, dt.cantidad
                         FROM Promocion p JOIN Detalle_Promocion dt ON dt.id_promocion = p.id_promocion JOIN Articulo a ON dt.id_articulo = a.id_articulo
                         WHERE p.id_promocion = " + FormatearDato(idPromo, "numero");
            return _BD.EjecutarSelect(sql);
        }

        public DataTable BuscarPorFecha(string fecha)
        {
            string sql = @"SELECT p.id_promocion, p.fecha_inicio, p.total, a.id_articulo, dt.cantidad
                         FROM Promocion p JOIN Detalle_Promocion dt ON dt.id_promocion = p.id_promocion JOIN Articulo a ON dt.id_articulo = a.id_articulo
                         WHERE p.fecha_inicio = " + FormatearDato(fecha, "fecha");
            return _BD.EjecutarSelect(sql);
        }

        public void cargarCombo(ref ComboBox01 combo)
        {
            combo.DisplayMember = "descripcion";
            combo.ValueMember = "id_articulo";
            combo.DataSource = _BD.EjecutarSelect("SELECT a.descripcion, a.id_articulo FROM Articulos a");
        }

        public void ModificarStock()
        {
            string sqlModificar = "";
            sqlModificar = @"UPDATE Articulos SET ";
            sqlModificar += "stock = " + this.stock;
            sqlModificar += " WHERE id_articulo = " + this.id_articulo;
            _BD.Modificar(sqlModificar);
        }

        public void Insertar()
        {

            string sqlInsert = "";
            sqlInsert = @"INSERT INTO Promocion (id_promocion, fecha_inicio, fecha_fin, 
            precio_costo, total, stock, alta_logica) VALUES (";
            sqlInsert += id_promocion;
            sqlInsert += ", '" + fecha_inicio + "'";
            sqlInsert += ", '" + fecha_fin + "'";
            sqlInsert += ", " + precio_costo;
            sqlInsert += ", " + total;
            sqlInsert += ", " + stock;
            sqlInsert += ", " + 1 + ")";
            _BD.Insertar(sqlInsert);
        }

        public void InsertarDetalle()
        {

            string sqlInsert = "";
            sqlInsert = @"INSERT INTO Detalle_promocion (id_promocion, id_ariculo, cantidad, 
            precio_dif, alta_logica) VALUES (";
            sqlInsert += id_promocion;
            sqlInsert += ", " + id_articulo;
            sqlInsert += ", " + cantidad;
            sqlInsert += ", " + precio_dif;
            sqlInsert += ", " + 1 + ")";
            _BD.Insertar(sqlInsert);
        }





    }
}
