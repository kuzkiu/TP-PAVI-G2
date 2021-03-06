using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3K3_GRUPO2.Clases;
using System.Data;

namespace TP_PAV_3K3_GRUPO2.Negocios
{

    class NE_Ventas
    {
        public string nro_factura { get; set; }
        public string id_tipoFactura { get; set; }
        public string fecha_venta { get; set; }
        public string id_sucursal { get; set; }
        public string nro_doc_emp { get; set; }
        public string cuil_cliente { get; set; }
        public string id_formaDePago { get; set; }
        public string monto_total { get; set; }
        public string alta_logica { get; set; }
        public string id_articulo { get; set; }
        public string precio_unitario { get; set; }
        public string cantidad { get; set; }
        public string stock_actual { get; set; }
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable BuscarArticulos()
        {

            string sql = @"SELECT A.id_articulo, A.descripcion, A.precio_costo, A.stock_actual FROM Articulos AS A
            WHERE  A.Alta_logica = 1";
            DataTable tabla = new DataTable();
            return _BD.EjecutarSelect(sql);


        }
        public DataTable FiltrarArticulos(string descripcion)
        {

            string sql = @"SELECT A.id_articulo, A.descripcion, A.precio_costo, A.stock_actual FROM Articulos AS A
            WHERE A.descripcion LIKE '%" + descripcion + "%' AND A.Alta_logica = 1";
            DataTable tabla = new DataTable();
            return _BD.EjecutarSelect(sql);


        }
        public DataTable BuscarVentasPorMesPorSucursal(string fechadesde, string fechahasta, int sucursal)
        {

            string sql = @"SELECT e.nombre, f.fecha_venta, f.nro_factura, f.monto_total
            FROM Factura f
            INNER JOIN Sucursal s ON  f.id_sucursal = s.id_sucursal
            INNER JOIN Empleado e ON  f.nro_doc_emp = e.nro_doc_emp
            WHERE f.id_sucursal = '" + sucursal + "' AND f.fecha_venta BETWEEN '" + fechadesde + "' AND '" + fechahasta + "'";
            DataTable tabla = new DataTable();
            return _BD.EjecutarSelect(sql);


        }
        public DataTable BuscarVentasPorMesPorSucursalEst(string fechadesde, string fechahasta)
        {
            //INNER JOIN Sucursal s ON  f.id_sucursal = s.id_sucursal

            string sql = @"SELECT s.descripcion
            , count(*) cant_factura
            , sum(f.monto_total) monto_total
            FROM Factura f
            INNER JOIN Sucursal s ON  f.id_sucursal = s.id_sucursal
            WHERE f.fecha_venta BETWEEN '" + fechadesde + "' AND '" + fechahasta + "'" +
            "GROUP BY s.descripcion";
            DataTable tabla = new DataTable();
            return _BD.EjecutarSelect(sql);


        }
        public DataTable BuscarVentasPorMesPorEmpleadoEst(string fechadesde, string fechahasta)
        {
            //INNER JOIN Sucursal s ON  f.id_sucursal = s.id_sucursal

            string sql = @"SELECT e.nombre
            , count(*) cant_factura
            , sum(f.monto_total) monto_total
            FROM Factura f
            INNER JOIN Empleado e ON  f.nro_doc_emp = e.nro_doc_emp
            WHERE f.fecha_venta BETWEEN '" + fechadesde + "' AND '" + fechahasta + "'" +
            "GROUP BY e.nombre";
            DataTable tabla = new DataTable();
            return _BD.EjecutarSelect(sql);


        }
        public DataTable BuscarVentasPorMesPorEmpleado(string fechadesde, string fechahasta, int empleado)
        {

            string sql = @"SELECT s.descripcion, f.fecha_venta, f.nro_factura, f.monto_total
            FROM Factura f
            INNER JOIN Sucursal s ON  f.id_sucursal = s.id_sucursal
            INNER JOIN Empleado e ON  f.nro_doc_emp = e.nro_doc_emp
            WHERE f.nro_doc_emp = '" + empleado + "' AND f.fecha_venta BETWEEN '" + fechadesde + "' AND '" + fechahasta + "'";
            DataTable tabla = new DataTable();
            return _BD.EjecutarSelect(sql);


        }
        public void Insertar()
        {

            string sqlInsert = "";
            sqlInsert = @"INSERT INTO factura (nro_factura, id_tipoFactura, fecha_venta, 
            id_sucursal, nro_doc_emp, cuil_cliente, id_formaDePago, monto_total, alta_logica) VALUES (";
            sqlInsert += nro_factura;
            sqlInsert += ", " + id_tipoFactura;
            sqlInsert += ", '" + fecha_venta + "'";
            sqlInsert += ", " + id_sucursal;
            sqlInsert += ", " + nro_doc_emp;
            sqlInsert += ", " + cuil_cliente;
            sqlInsert += ", " + id_formaDePago;
            sqlInsert += ", " + monto_total;
            sqlInsert += ", " + 1 + ")";
            _BD.Insertar(sqlInsert);
        }
        public void InsertarDetalle()
        {

            string sqlInsert = "";
            sqlInsert = @"INSERT INTO detalle_factura (nro_factura, id_tipoFactura, id_articulo, 
            precio_unitario, cantidad, alta_logica) VALUES (";
            sqlInsert += nro_factura;
            sqlInsert += ", " + id_tipoFactura;
            sqlInsert += ", " + id_articulo;
            sqlInsert += ", " + precio_unitario;
            sqlInsert += ", " + cantidad;
            sqlInsert += ", " + 1 + ")";
            _BD.Insertar(sqlInsert);
        }
        public void ModificarStock()
        {
            string sqlModificar = "";
            sqlModificar = @"UPDATE articulos SET ";
            sqlModificar += "stock_actual = " + stock_actual;
            sqlModificar += " WHERE id_articulo = " + id_articulo;
            _BD.Modificar(sqlModificar);
        }
    }
}
