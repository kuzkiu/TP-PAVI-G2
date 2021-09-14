using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3K3_GRUPO2.Formularios.Articulos;

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
            Frm_AltaClientes reg_cli = new Frm_AltaClientes();
            reg_cli.ShowDialog();
            if (reg_cli.Cuil == "")
            {
                MessageBox.Show("No se ingresado ningún Cuil");
                reg_cli.Dispose();
                return;
            }

            if (reg_cli.RazonS == "")
            {
                MessageBox.Show("No se valido ninguna Razon Social");
                reg_cli.Dispose();
                return;
            }

            if (reg_cli.TipoDoc == "")
            {
                MessageBox.Show("No se valido ningún tipo de documento");
                reg_cli.Dispose();
                return;
            }

            if (reg_cli.NumDoc == "")
            {
                MessageBox.Show("No se valido ningún número de documento");
                reg_cli.Dispose();
                return;
            }

            if (reg_cli.Calle == "")
            {
                MessageBox.Show("No se valido ningún");
                reg_cli.Dispose();
                return;
            }

            if (reg_cli.TipoTel == "")
            {
                MessageBox.Show("No se valido ningún tipo de feléfono");
                reg_cli.Dispose();
                return;
            }

            if (reg_cli.Telefono == "")
            {
                MessageBox.Show("No se valido ningún número de telefono");
                reg_cli.Dispose();
                return;
            }

            if (reg_cli.NumeroDir == "")
            {
                MessageBox.Show("No se valido ningún número de dirección");
                reg_cli.Dispose();
                return;
            }

            if (reg_cli.Barrio == "")
            {
                MessageBox.Show("No se valido ningún barrio");
                reg_cli.Dispose();
                return;
            }
            if (reg_cli.Localidad == "")
            {
                MessageBox.Show("No se valido ninguna localidad.");
                reg_cli.Dispose();
                return;
            }

            this.Cuil = reg_cli.Cuil;
            this.RazonS = reg_cli.RazonS;
            this.TipoDoc = reg_cli.TipoDoc;
            this.NumDoc = reg_cli.NumDoc;
            this.TipoTel = reg_cli.TipoTel;
            this.NumTel = reg_cli.Telefono;
            this.Calle = reg_cli.Calle;
            this.Calle_Num = reg_cli.NumeroDir;
            this.Depto = reg_cli.Depto;
            this.Piso = reg_cli.Piso;
            this.Barrio = reg_cli.Barrio;
            this.Localidad = reg_cli.Localidad;

            reg_cli.Dispose();
            MessageBox.Show("Datos Cargados Correctamente");
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
            if (reg_prod.Descripcion == "")
            {
                MessageBox.Show("No se ingresado una descripción");
                reg_prod.Dispose();
                return;
            }

            if (reg_prod.PCosto == "")
            {
                MessageBox.Show("No se valido ningún precio costo");
                reg_prod.Dispose();
                return;
            }

            if (reg_prod.PVenta == "")
            {
                MessageBox.Show("No se valido ningún precio de venta");
                reg_prod.Dispose();
                return;
            }

            if (reg_prod.Stock == "")
            {
                MessageBox.Show("No se valido ningún stock");
                reg_prod.Dispose();
                return;
            }

            //if (reg_prod.Marca == "")
            //{
            //    MessageBox.Show("No se valido ninguna mParca");
            //    reg_prod.Dispose();
            //    return;
            //}

            //if (reg_prod.Rubro == "")
            //{
            //    MessageBox.Show("No se valido ningún rubro");
            //    reg_prod.Dispose();
            //    return;
            //}

            this.Descripcion = reg_prod.Descripcion;
            this.Pre_Costo = reg_prod.PCosto;
            this.Pre_Venta = reg_prod.PVenta;
            this.Stock = reg_prod.Stock;
            //this.Marca = reg_prod.Marca;
            //this.Rubro = reg_prod.Rubro;
            reg_prod.Dispose();
            MessageBox.Show("Artículo cargado correctamente");

        }

        private void modificarTelefonoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        //reg rubro
        private void registrarRubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RegRubro _reg_rubro = new Frm_RegRubro();
            _reg_rubro.ShowDialog();

            if (_reg_rubro.idRubro == "")
            {
                MessageBox.Show("No se ingresado un id para el rubro");
                _reg_rubro.Dispose();
                return;
            }

            if (_reg_rubro.nombreRubro == "")
            {
                MessageBox.Show("No se ingresado un nombre para el rubro");
                _reg_rubro.Dispose();
                return;
            }

            this._id_Rubro = _reg_rubro.idRubro;
            this._nombre = _reg_rubro.nombreRubro;
            _reg_rubro.Dispose();
            MessageBox.Show("Rubro cargado correctamente");
        }

        private void modificarArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

