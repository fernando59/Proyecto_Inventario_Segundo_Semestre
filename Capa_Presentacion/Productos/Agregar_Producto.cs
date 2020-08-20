using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidades;
using Capa_Negocio;
namespace Capa_Presentacion
{
    public partial class Agregar_Producto : Form
    {
        Logica_Producto logica_Producto = new Logica_Producto();
        public string id = null;
        public Agregar_Producto()
        {
            InitializeComponent();
        }

        private void Agregar_Producto_Load(object sender, EventArgs e)
        {
            Listar_Categoria();
            ID2.Enabled = false;
        }

        private void btnAgregarPro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescripcion.Text == "" || txtNombrePro.Text == "" || txtPrecioPro.Text ==""|| txtStockPro.Text=="")
                {
                    DialogResult resultado = new DialogResult();
                    Form mensaje = new MessageBox.VacioForm();
                    resultado = mensaje.ShowDialog();
                }
                else
                {
                    
                    Producto producto = new Producto();
                    producto.Nombre = txtNombrePro.Text;
                    producto.Descripcion = txtDescripcion.Text;
                    producto.Id = Convert.ToInt32( id);
                    producto.precio = Convert.ToDecimal(txtPrecioPro.Text);
                    producto.Stock = Convert.ToInt32(txtStockPro.Text);
                    producto.Id_categoria = Convert.ToInt32(cbCategoria.SelectedValue);
                    if (logica_Producto.Modificar_Producto(producto) > 0)
                    {
                        DialogResult resultado = new DialogResult();
                        Form mensaje = new MessageBox.MessageBoxModificar();
                        resultado = mensaje.ShowDialog();
                        Borrar();
                        this.Close();
                        
                    }
                    else
                    {
                        logica_Producto.Insertar_Producto(producto);
                        MessageCorrecto();
                        Borrar();
                        this.Close();
                    }
                      

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

        
        }
        //Listar Categoria
        public void Listar_Categoria()
        {
            cbCategoria.DataSource = logica_Producto.Listar_Categoria();
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "Id_Categoria";
        }
       //Borrar textbox
       private void Borrar()
        {
            txtDescripcion.Text = "";
            txtNombrePro.Text = "";
            txtPrecioPro.Text = "";
            txtStockPro.Text = "";
            ID2.Text = "";
            id = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new MessageboxForm();
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }
           
        }

        private void btnEliminar_Producto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            if (txtNombrePro.Text == "" || txtDescripcion.Text == "" || txtPrecioPro.Text == "" || txtStockPro.Text == "")
            {
                //MessageBox.Show("Datos incompletos");
            }
            else
            {
                //DialogResult resultado = MessageBox.Show("¿Esta seguro que desea eliminar el registro?", "Salir", MessageBoxButtons.YesNo);
                //if (resultado == DialogResult.Yes)
                //{
                //    producto.Id = Convert.ToInt32(ID.Text);
                    logica_Producto.Eliminar_Producto(producto);
                    btnEliminar_Producto.Enabled = false;
                    Borrar();
                //}
            }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Messagebox
        private void MessageCorrecto()
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new MessageBox.MessageInsertar();
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK)
            {

            }
            else
            {

            }
        }
    }
}
