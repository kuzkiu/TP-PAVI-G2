using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3K3_GRUPO2.Negocios;

namespace TP_PAV_3K3_GRUPO2.Formularios.ListadePrecios
{
    public partial class Frm_Registrar_Lista : Form
    {
        public Frm_Registrar_Lista()
        {
            InitializeComponent();
        }

        private void Frm_Registrar_Lista_Load(object sender, EventArgs e)
        {
            Ne_Lista_de_Precios cargar_cuils = new Ne_Lista_de_Precios();
            DataTable tabla = new DataTable();
            tabla = cargar_cuils.Buscar_cuils_Seleccion();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                cmb_cuils.Items.Add(tabla.Rows[i]["cuil_cliente"]);
            }


        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Ne_Lista_de_Precios confirmar = new Ne_Lista_de_Precios();

            if (txt_id.Text == "")
            {
                MessageBox.Show("No se ha cargado un ID. \n" +
                                "Cargue uno antes de continuar");
                return;
            }
            if (confirmar.Buscar_id_existente(txt_id.Text))
            {
                MessageBox.Show("El id seleccionado ya existe \n" +
                                "Intente cargar otro. \n" +
                                "Sugerencia de id = " + confirmar.Sugerir_id());
                return;
            }


            else
            {
                Ne_Lista_de_Precios ultima_lista = new Ne_Lista_de_Precios();
                DataTable tabla_lista = ultima_lista.Buscar_Listas(cmb_cuils.Text,"",true);

                if(tabla_lista.Rows.Count != 0) 
                {
                    DialogResult resultado = MessageBox.Show("¿Desea partir de la lista anterior de este cliente?","Lista vigente",MessageBoxButtons.YesNo);

                    if (resultado == DialogResult.Yes) 
                    {
                        DataTable detalles = ultima_lista.Buscar_ArticulosLista_Adm(tabla_lista.Rows[0]["id_lista_precios"].ToString());
                        for (int i = 0; i < detalles.Rows.Count; i++)
                        { 
                            dgv_detalles.Rows.Add(1);
                            int rowEscribir = dgv_detalles.Rows.Count - 1;
                            dgv_detalles.Rows[rowEscribir].Cells[0].Value = detalles.Rows[i][0];
                            dgv_detalles.Rows[rowEscribir].Cells[1].Value = detalles.Rows[i][1];
                            dgv_detalles.Rows[rowEscribir].Cells[2].Value = detalles.Rows[i][2];
                        }
                    }
                }


                cmb_cuils.Enabled = false;
                txt_id.Enabled = false;
                cmb_id.Enabled = true;
                txt_precion.Enabled = true;
                btn_Agregar.Enabled = true;
                btn_confirmar.Enabled = false;
                btn_Cancelar.Enabled = true;
                btn_Registrar.Enabled = true;
                Ne_Lista_de_Precios cmb_articulos = new Ne_Lista_de_Precios();
                DataTable tabla_art = cmb_articulos.Buscar_IDArticulos();
                for (int i=0; i<tabla_art.Rows.Count; i++) 
                {
                    cmb_id.Items.Add(tabla_art.Rows[i]["id_articulo"].ToString());
                }


            }

        }

        private void dgw_detalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (cmb_id.Text == "")
            {
                MessageBox.Show("No se ha seleccionado un articulo para agregar");
                return;
            }

            if (txt_precion.Text == "")
            {
                MessageBox.Show("No se ha seleccionado un precio diferenciado");
                return;
            }

            if (dgv_detalles.RowCount > 0)
            {

                bool existe = false;
                for (int i = 0; i < dgv_detalles.RowCount; i++)
                {
                    if (dgv_detalles.Rows[i].Cells["id_articulo"].Value.ToString() == cmb_id.Text)
                    {
                        MessageBox.Show("El producto ya ha sido ingresado");
                        existe = true;
                        break;
                    }
                }


                if (existe == false)
                {
                    dgv_detalles.Rows.Add(cmb_id.Text,txt_descripcion.Text,txt_precion.Text);
                }
            }

            else 
            {
                dgv_detalles.Rows.Add(cmb_id.Text,txt_descripcion.Text ,txt_precion.Text);
                btn_Registrar.Enabled = true;
            }

            cmb_id.Text = "";
            txt_precion.Text = "";
            txt_precioo.Text = "";
            txt_descripcion.Text = "";
        }

        private void cmb_id_SelectedValueChanged(object sender, EventArgs e)
        {
            Ne_Lista_de_Precios buscar_articulo = new Ne_Lista_de_Precios();
            DataTable tabla_Art = buscar_articulo.Buscar_DatosArticulo(cmb_id.Text);
            txt_descripcion.Text = tabla_Art.Rows[0][0].ToString();
            txt_precioo.Text = tabla_Art.Rows[0][1].ToString();
        }

        private void dgv_detalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Agregar.Enabled = false;
            btn_modificar.Enabled = true;
            btn_Eliminar.Enabled = true;
        }

        private void dgv_detalles_DoubleClick(object sender, EventArgs e)
        {
            btn_Agregar.Enabled = false;
            btn_modificar.Enabled = true;
            btn_Eliminar.Enabled = true;
            cmb_id.Text = dgv_detalles.CurrentRow.Cells[0].Value.ToString();
            Ne_Lista_de_Precios buscar_articulo = new Ne_Lista_de_Precios();
            DataTable tabla_Art = buscar_articulo.Buscar_DatosArticulo(cmb_id.Text);
            txt_descripcion.Text = tabla_Art.Rows[0][0].ToString();
            txt_precioo.Text = tabla_Art.Rows[0][1].ToString();
            txt_precion.Text = dgv_detalles.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (cmb_id.Text == "") 
            {
                MessageBox.Show("Seleccione un ID antes de continuar");
                return;
            }

            if(txt_precion.Text == "") 
            {
                MessageBox.Show("No se ha seleccionado un precio nuevo");
                return;
            }

            else 
            {
                dgv_detalles.CurrentRow.Cells[0].Value = cmb_id.Text;
                dgv_detalles.CurrentRow.Cells[1].Value = txt_descripcion.Text;
                dgv_detalles.CurrentRow.Cells[2].Value = txt_precion.Text;
                btn_Agregar.Enabled = true;
                btn_modificar.Enabled = false;
                cmb_id.Text = "";
                txt_descripcion.Text = "";
                txt_precion.Text = "";
                txt_precioo.Text = "";
           
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            dgv_detalles.Rows.RemoveAt(dgv_detalles.CurrentRow.Index);
            cmb_id.Text = "";
            txt_descripcion.Text = "";
            txt_precion.Text = "";
            txt_precioo.Text = "";
            btn_Eliminar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_Agregar.Enabled = true;
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea guardar la lista? \n Si el cliente tiene una desde antes dejara de tener vigencia \n",
                                    "Cargando Lista de Precios", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                Ne_Lista_de_Precios registrar_lista = new Ne_Lista_de_Precios();
                registrar_lista.Baja_lista_Anterior(cmb_cuils.Text);
                registrar_lista.Reg_Nueva_Lista(txt_id.Text, cmb_cuils.Text);

                for(int i=0; i< dgv_detalles.Rows.Count; i++) 
                {
               
                    registrar_lista.Reg_detalle_lista(txt_id.Text, dgv_detalles.Rows[i].Cells[0].Value.ToString(), dgv_detalles.Rows[i].Cells[2].Value.ToString());
                }

                MessageBox.Show("Lista registrada con exito");
                this.Close();
                
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
         }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
 }
        
