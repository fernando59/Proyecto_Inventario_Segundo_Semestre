using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Entidades;
namespace Capa_Presentacion
{
    public partial class Productos_Formulario : Form
    {
        Logica_Producto logica_Producto = new Logica_Producto();
       
        public Productos_Formulario()
        {
            InitializeComponent();
        }

        private void Productos_Formulario_Load(object sender, EventArgs e)
        {
                Mostrar_Grid();
            comboBuscar.Text = "Nombre";
               
           
        }
       
      
        public void Mostrar_Grid()
        {
            try
            {
                dataProducto.DataSource = logica_Producto.Mostrar_Producto();
                //dataProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataProducto.Columns[0].HeaderText = "ID  ";
                dataProducto.Columns[1].HeaderText = "Nombre";
                dataProducto.Columns[2].HeaderText = "Descripción";
                dataProducto.Columns[3].HeaderText = "Precio";
                dataProducto.Columns[4].HeaderText = "Stock";
                dataProducto.Columns[6].HeaderText = "Categoria";
                dataProducto.Columns[5].Visible = false;
                dataProducto.Columns[7].Visible = false;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
           
        }

        private void btnNombrePro_Click(object sender, EventArgs e)
        {
            Agregar_Producto agregar_Producto = new Agregar_Producto();
            agregar_Producto.btnEliminar_Producto.Hide();
            agregar_Producto.btnAgregarPro.Location=new Point(150, 472);
            
            //Para hacer que se cargue el data grid despues de cerrarse el form
            agregar_Producto.FormClosed += new System.Windows.Forms.FormClosedEventHandler(form2_FormClosed);
            agregar_Producto.Show();
           

        }
        private void form2_FormClosed(object sender, FormClosedEventArgs e)
        {

            Mostrar_Grid();

        }
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
           
        }
        //Buscar
        private void Buscar()
        {
            try
            {
              
                
                if (comboBuscar.Text == "Categoria")
                {
                    Producto producto = new Producto();

                    producto.Buscar = txtBuscar.Text;
                    dataProducto.DataSource = logica_Producto.Buscar_ProductoCategoria(producto);
                    dataProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataProducto.Columns[5].Visible = false;
                    dataProducto.Columns[7].Visible = false;
                }
                else
                {
                    Producto producto = new Producto();

                    producto.Buscar = txtBuscar.Text;
                    dataProducto.DataSource = logica_Producto.Buscar_Producto(producto);
                    dataProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataProducto.Columns[5].Visible = false;
                    dataProducto.Columns[7].Visible = false;
                }
               
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }
        private void btnModificarPro_Click(object sender, EventArgs e)
        {
            Agregar_Producto agregar_Producto = new Agregar_Producto();
            agregar_Producto.ID2.Enabled = true;
            agregar_Producto.ID2.ForeColor = Color.Black;
            agregar_Producto.ID2.Text= dataProducto.CurrentRow.Cells["Id"].Value.ToString();
            agregar_Producto.txtNombrePro.Text = dataProducto.CurrentRow.Cells["Nombre"].Value.ToString();
            agregar_Producto.txtDescripcion.Text = dataProducto.CurrentRow.Cells["Descripcion"].Value.ToString();
            agregar_Producto.txtPrecioPro.Text = dataProducto.CurrentRow.Cells["precio"].Value.ToString();
            agregar_Producto.txtStockPro.Text = dataProducto.CurrentRow.Cells["Stock"].Value.ToString();
            agregar_Producto.cbCategoria.Text = dataProducto.CurrentRow.Cells["Nombre_Categoria"].Value.ToString();
            agregar_Producto.id= dataProducto.CurrentRow.Cells["Id"].Value.ToString();
            agregar_Producto.Show();
           
            //Para hacer que se cargue el data grid despues de cerrarse el form
            agregar_Producto.FormClosed += new System.Windows.Forms.FormClosedEventHandler(form2_FormClosed);
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                dataProducto.DataSource = logica_Producto.Mostrar_Producto();
                dataProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataProducto.Columns[5].Visible = false;
                dataProducto.Columns[7].Visible = false;
            }
        }

        private void btnEliminarpro_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
        }

        private void dataProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkBusqueda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
       
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Buscar();
                e.Handled = true;//Quitar el sonido
            }
        }
    }
}
