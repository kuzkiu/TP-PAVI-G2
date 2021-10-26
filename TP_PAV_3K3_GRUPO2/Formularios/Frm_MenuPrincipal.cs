using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3K3_GRUPO2.Formularios.Base;
using TP_PAV_3K3_GRUPO2.Formularios;
using TP_PAV_3K3_GRUPO2.Formularios.Rubro;
using TP_PAV_3K3_GRUPO2.Formularios.Cargo;
using TP_PAV_3K3_GRUPO2.Formularios.Ventas;
using TP_PAV_3K3_GRUPO2.Formularios.ListadePrecios;
using TP_PAV_3K3_GRUPO2.Formularios.Sucursal;
using TP_PAV_3K3_GRUPO2.Formularios.Reportes.Ventas;
namespace TP_PAV_3K3_GRUPO2
{

    public partial class Frm_MenuPrincipal : Form
    {
        //variables inicio de sesion
        private String usuario;
        private String contraseña;

        //Variables empleado
        private String Cuil;
        private String RazonS;
        private String TipoDoc;
        private String NumDoc;
        private String TipoTel;
        private String NumTel;
        private String Calle;
        private String Calle_Num;
        private String Depto;
        private String Piso;
        private String Barrio;
        private String Localidad;

        //variables articulo
        public String Descripcion;
        public String Pre_Costo;
        public String Pre_Venta;
        public String Stock;
        public String Marca;
        public String Rubro;

        //variables de Rubro
        public String _id_Rubro;
        public String _nombre;

        //variables de Cargo
        public String _Cod_cargo_;
        public String Denominacion;


        public Frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        //Inicio de sesion
        private void Form1_Load(object sender, EventArgs e)
        {
            Frm_Login log = new Frm_Login();
            log.ShowDialog();
            if (log.usuario == "")
            {
                MessageBox.Show("No se valido ningún");
                log.Dispose();
                return;
            }
            this.usuario = log.usuario;
            this.contraseña = log.contraseña;
            log.Dispose();
            MessageBox.Show("usuario :" + this.usuario + "contraseña:" + this.contraseña);
        }

        //Registrar Cliente
        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AdmCliente Adm = new Frm_AdmCliente();
            Adm.ShowDialog();
            Adm.Dispose();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            {
                Frm_Login login = new Frm_Login();
                login.ShowDialog();
                if (this.usuario == "")
                {
                    MessageBox.Show("No se valido ningún");
                    login.Dispose();
                    return;
                }
                if (this.contraseña == "")
                { 
                    this.usuario = login.usuario;
                    this.contraseña = login.contraseña;
                    login.Dispose();
                    MessageBox.Show("usuario :" + this.usuario + "n" + " password:" + this.contraseña);
                }
            }
        }

        private void registrarPromocionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AltaArticulos reg_prod = new Frm_AltaArticulos();
            reg_prod.ShowDialog();
            //if (reg_prod.Descripcion == "")
            //{
            //    MessageBox.Show("No se ingresado una descripción");
            //    reg_prod.Dispose();
            //    return;
            //}

            //if (reg_prod.PCosto == "")
            //{
            //    MessageBox.Show("No se valido ningún precio costo");
            //    reg_prod.Dispose();
            //    return;
            //}

            //if (reg_prod.PVenta == "")
            //{
            //    MessageBox.Show("No se valido ningún precio de venta");
            //    reg_prod.Dispose();
            //    return;
            //}

            //if (reg_prod.Stock == "")
            //{
            //    MessageBox.Show("No se valido ningún stock");
            //    reg_prod.Dispose();
            //    return;
            //}

            ////if (reg_prod.Marca == "")
            ////{
            ////    MessageBox.Show("No se valido ninguna mParca");
            ////    reg_prod.Dispose();
            ////    return;
            ////}

            ////if (reg_prod.Rubro == "")
            ////{
            ////    MessageBox.Show("No se valido ningún rubro");
            ////    reg_prod.Dispose();
            ////    return;
            ////}

            //this.Descripcion = reg_prod.Descripcion;
            //this.Pre_Costo = reg_prod.PCosto;
            //this.Pre_Venta = reg_prod.PVenta;
            //this.Stock = reg_prod.Stock;
            ////this.Marca = reg_prod.Marca;
            ////this.Rubro = reg_prod.Rubro;
            //reg_prod.Dispose();
            //MessageBox.Show("Artículo cargado correctamente");

        }

        private void modificarTelefonoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_RegEmpleado reg_prod = new Frm_RegEmpleado();
            //reg_prod.ShowDialog();

        }

        //ALTA RUBRO
        private void registrarRubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RegRubro _reg_rubro = new Frm_RegRubro();
            _reg_rubro.ShowDialog();


            this._id_Rubro = _reg_rubro.idRubro;
            this._nombre = _reg_rubro.nombreRubro;
            _reg_rubro.Dispose();
            MessageBox.Show("Rubro cargado correctamente");



        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RegMarca reg_prod = new Frm_RegMarca();
            reg_prod.ShowDialog();
        }

        private void administrarRubroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //ALTA CARGO
        private void registrarCargoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_RegCargo _reg_cargo = new Frm_RegCargo();
            _reg_cargo.ShowDialog();

           

            this._Cod_cargo_ = _reg_cargo.Codigo_cargo;
            this.Denominacion = _reg_cargo._denominacion_;
            _reg_cargo.Dispose();
            //MessageBox.Show("Cargo cargado correctamente");


        }


        //BAJA CARGO
        private void eliminarCargoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_BajaCargo _baja_cargo = new Frm_BajaCargo();
            _baja_cargo.ShowDialog();

        }

        private void modificarCargoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_ModificarCargo _modif_cargo = new Frm_ModificarCargo();
            _modif_cargo.ShowDialog();

        }


        //BAJA RUBRO
        private void eliminarRubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BajaRubro _baja_rubro_ = new Frm_BajaRubro();
            _baja_rubro_.ShowDialog();
        }

        private void modificarArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ModificarArticulos _modArt = new Frm_ModificarArticulos();
            _modArt.ShowDialog();
        }

        private void mostrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ConsultaArticulos _modArt = new Frm_ConsultaArticulos();
            _modArt.ShowDialog();
        }

        private void eliminarEmpleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_EliminarArticulos _modArt = new Frm_EliminarArticulos();
            _modArt.ShowDialog();
        }

        //modificar rubro
        private void consultarRubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ModificarRubro _modifRubro_ = new Frm_ModificarRubro();
            _modifRubro_.ShowDialog();
        }

        private void consultarCargoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_ConsultarCargo _consultar_cargo = new Frm_ConsultarCargo();
            _consultar_cargo.ShowDialog();
        }

        private void mostrarRubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ConsultarRubro _consultaRubro_ = new Frm_ConsultarRubro();
            _consultaRubro_.ShowDialog();
        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RegistrarVentas _regVenta_ = new Frm_RegistrarVentas();
            _regVenta_.ShowDialog(); 
        }

        private void administrarListasDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Consultar_Listas lista = new Frm_Consultar_Listas();
            lista.ShowDialog();
            lista.Dispose();
        }

        private void administrarSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AdministrarSucursal adm_suc = new Frm_AdministrarSucursal();
            adm_suc.ShowDialog();
            adm_suc.Dispose();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_ReporteVentas rep_ventas = new Frm_ReporteVentas();
            rep_ventas.ShowDialog();
            rep_ventas.Dispose();
        }

        private void listasDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ReporteListaDePrecios report_lista = new Frm_ReporteListaDePrecios();
            report_lista.ShowDialog();
            report_lista.Dispose();
        }
    }
}

