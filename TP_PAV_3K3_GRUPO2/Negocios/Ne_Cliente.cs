using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3K3_GRUPO2.Clases;
using System.Data;

namespace TP_PAV_3K3_GRUPO2.Negocio
{
    class Ne_Cliente
    {
        Be_BaseDatos bd = new Be_BaseDatos();


        public DataTable buscarCliente(string cuil, string RazonS)
        {
            if (cuil != "" & RazonS != "")
            {
                string sql = @"SELECT C.cuil_cliente, C.razon_social, X.numero_telefono, TE.nombre, C.nro_documento, T.nombre, D.calle, D.numero, D.piso, D.depto, B.nombre_barrio, L.nombre_localidad
 FROM Clientes C, Barrio B, Localidad L, Tipo_documento T, Direccion D, telefonoXcliente X, tipo_telefono TE 
 WHERE C.id_direccion = D.id_direccion AND D.id_barrio= B.id_barrio AND B.id_localidad = L.id_localidad AND
  C.id_tipoDocumento = T.id_tipoDocumento AND C.cuil_cliente = X.cuil_cliente AND X.id_Tipo_Telefono = TE.id_tipoTelefono
  AND C.cuil_cliente LIKE '%" + cuil + "%' AND C.razon_social LIKE '%" + RazonS + "%'  AND (X.numero_telefono ='' OR (NOT(X.numero_telefono =''))) AND C.alta_logica = 1 ";

                return bd.Consulta(sql);
            }
            if (cuil == "" & RazonS == "")
            {
                string sql = @"SELECT C.cuil_cliente, C.razon_social, X.numero_telefono, TE.nombre, C.nro_documento, T.nombre, D.calle, D.numero, D.piso, D.depto, B.nombre_barrio, L.nombre_localidad
 FROM Clientes C, Barrio B, Localidad L, Tipo_documento T, Direccion D, telefonoXcliente X, tipo_telefono TE 
 WHERE C.id_direccion = D.id_direccion AND D.id_barrio= B.id_barrio AND B.id_localidad = L.id_localidad AND
  C.id_tipoDocumento = T.id_tipoDocumento AND C.cuil_cliente = X.cuil_cliente AND X.id_Tipo_Telefono = TE.id_tipoTelefono  AND (X.numero_telefono ='' OR (NOT(X.numero_telefono =''))) AND C.alta_logica = 1";

                return bd.Consulta(sql);
            }

            if (cuil != "" & RazonS == "")
            {
                string sql = @"SELECT C.cuil_cliente, C.razon_social, X.numero_telefono, TE.nombre, C.nro_documento, T.nombre, D.calle, D.numero, D.piso, D.depto, B.nombre_barrio, L.nombre_localidad
 FROM Clientes C, Barrio B, Localidad L, Tipo_documento T, Direccion D, telefonoXcliente X, tipo_telefono TE 
 WHERE C.id_direccion = D.id_direccion AND D.id_barrio= B.id_barrio AND B.id_localidad = L.id_localidad AND
  C.id_tipoDocumento = T.id_tipoDocumento AND C.cuil_cliente = X.cuil_cliente AND X.id_Tipo_Telefono = TE.id_tipoTelefono
  AND C.cuil_cliente LIKE '%" + cuil + "%'  AND (X.numero_telefono ='' OR (NOT(X.numero_telefono =''))) AND C.alta_logica = 1";

                return bd.Consulta(sql);


            }
            if (cuil == "" & RazonS != "")
            {
                string sql = @"SELECT C.cuil_cliente, C.razon_social, X.numero_telefono, TE.nombre, C.nro_documento, T.nombre, D.calle, D.numero, D.piso, D.depto, B.nombre_barrio, L.nombre_localidad
 FROM Clientes C, Barrio B, Localidad L, Tipo_documento T, Direccion D, telefonoXcliente X, tipo_telefono TE 
 WHERE C.id_direccion = D.id_direccion AND D.id_barrio= B.id_barrio AND B.id_localidad = L.id_localidad AND
  C.id_tipoDocumento = T.id_tipoDocumento AND C.cuil_cliente = X.cuil_cliente AND X.id_Tipo_Telefono = TE.id_tipoTelefono
  AND C.razon_social LIKE '%" + RazonS + "%' AND (X.numero_telefono ='' OR (NOT(X.numero_telefono =''))) AND C.alta_logica = 1";

                return bd.Consulta(sql);
            }

            DataTable tabla_nul = new DataTable();
            return tabla_nul;


         }
        public void Registrar_Telfono_Cliente(string cuil_cliente, string numero, string id_tipotel)
        {
            string sql = @"INSERT INTO telefonoXcliente
                            VALUES ('"+cuil_cliente+"','" + numero+"','"+id_tipotel+"', 1)" ;
            bd.Consulta(sql);
        }
        public void Registrar_Direccion_Cliente(string id_direccion, string id_barrio, string calle, string numero, string piso, string depto)
        {
            if (piso != "" & depto != "")
            { 
            string sql = @"INSERT INTO Direccion
                        Values('" + id_direccion + "','" + id_barrio + "','" + calle + "','" + numero + "','" + piso + "','" + depto + "', 1)";
            bd.Consulta(sql);
            }
            if (piso == "" & depto == "")
            {
                string sql = @"INSERT INTO Direccion
                        Values('" + id_direccion + "','" + id_barrio + "','" + calle + "','" + numero + "', 0 , 0 , 1)";
                bd.Consulta(sql);
            }
        }
        public void Registrar_Cliente(string cuil, string razon_social, string id_dirección, string id_tipo_doc, string nro_doc) 
        {
            string sql = @"INSERT INTO Clientes
                         Values('" + cuil + "','"+ razon_social+"','"+id_dirección+"','"+id_tipo_doc+"','"+nro_doc+"', 1 , 1)" ;
            bd.Consulta(sql);
        }

        public void Registrar_Cliente_Final(string cuil_cliente, string razons,string numero_tel, string id_tipotel, string id_direc,
            string id_bar, string calle, string num_calle, string piso, string depto, string id_tipodoc, string num_doc)
        {
            if (numero_tel != "" & id_tipotel != "")
            {
                Registrar_Direccion_Cliente(id_direc, id_bar, calle, num_calle, piso, depto);
                Registrar_Cliente(cuil_cliente, razons, id_direc, id_tipodoc, num_doc);
                Registrar_Telfono_Cliente(cuil_cliente, numero_tel, id_tipotel);
            }

            if (numero_tel == "" & id_tipotel == "")
            {
                Registrar_Direccion_Cliente(id_direc, id_bar, calle, num_calle, piso, depto);
                Registrar_Cliente(cuil_cliente, razons, id_direc, id_tipodoc, num_doc);
            }
        }

        public DataTable BuscarClienteBaja(string cuil) 
        {
            string sql = @"SELECT C.razon_social, X.numero_telefono, E.nombre, C.nro_documento, T.nombre,D.calle, D.numero, D.piso, D.depto, B.nombre_barrio, L.nombre_localidad
FROM Clientes C, Barrio B, Localidad L, Tipo_documento T, Direccion D, telefonoXcliente X, tipo_telefono E
WHERE C.id_direccion = D.id_direccion AND D.id_barrio= B.id_barrio AND B.id_localidad = L.id_localidad AND
  C.id_tipoDocumento = T.id_tipoDocumento AND C.cuil_cliente = X.cuil_cliente AND X.id_Tipo_Telefono = E.id_tipoTelefono
    AND C.cuil_cliente = " + cuil ;

            return bd.Consulta(sql);

        }

        public void BajaCliente(string cuil) 
        {
            String sql = @"Update CLIENTES 
                        SET alta_logica = 0
                        WHERE Clientes.cuil_cliente = '" + cuil+"'";
            bd.Consulta(sql);
        }

        public DataTable BuscarClienteModificacion(string cuil) 
        {
            string sql = @"SELECT C.razon_social, C.nro_documento, T.nombre, D.calle, D.numero, D.piso, D.depto, B.nombre_barrio, L.nombre_localidad 
                   FROM Clientes C, Barrio B, Localidad L, Tipo_documento T, Direccion D  
                   WHERE C.id_direccion = D.id_direccion AND D.id_barrio= B.id_barrio AND B.id_localidad = L.id_localidad AND
                   C.id_tipoDocumento = T.id_tipoDocumento AND C.cuil_cliente LIKE '%"+ cuil+ "%'";

            return bd.Consulta(sql);
        }

        public void modificar_Cliente(string cuil, string razonS, string id_tipodoc, string doc)
        {
            string sql = @"UPDATE Clientes
                           SET razon_social = '" +razonS+"' , id_tipoDocumento = " + id_tipodoc + ", nro_documento = " + doc +
                           "WHERE Clientes.cuil_cliente = " + cuil;
            bd.Consulta(sql);
        }

        public void modificar_Direccion(string id_direc, string calle, string num_calle, string depto, string piso, string id_barrio)
        {
            string sql = @"UPDATE Direccion 
                          SET id_barrio = " + id_barrio + ", calle = '" + calle +"',numero="+ num_calle +", piso =" + piso + ", depto = '" + depto +"'"+
                         "Where Direccion.id_direccion =" + id_direc;
            bd.Consulta(sql);
        }


        public void modificar_ClienteDefinitivo(string cuil, string Razons, string id_tipodoc, string doc,
            string id_direc, string calle, string num_calle, string depto, string piso, string id_barrio) 
        {
            modificar_Cliente(cuil, Razons, id_tipodoc, doc);
            modificar_Direccion(id_direc, calle, num_calle, depto, piso, id_barrio);

        
        }


        public DataTable BuscarCuils() 
        {
            string sql = @"SELECT Clientes.cuil_cliente
                        FROM Clientes
                        WHERE Clientes.alta_logica = 1";

            return bd.Consulta(sql);

        }
    }
}
