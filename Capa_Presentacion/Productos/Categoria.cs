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
    public partial class Categoria : Form
    {

        Logica_Producto logica_Producto = new Logica_Producto();
        private string id_Categoria=null;
       
        public Categoria()
        {
            InitializeComponent();
        }
        //Guardar
        private void Guardar()
        {
            if (txtDescripcionCa.Text=="" || txtNombreCat.Text=="")
            {
                DialogResult resultado = new DialogResult();
                Form mensaje = new MessageBox.VacioForm();
                resultado = mensaje.ShowDialog();
            }
            else
            {
                Categoria_E categoria = new Categoria_E();
                categoria.Nombre = txtNombreCat.Text;
                categoria.Descripcion = txtDescripcionCa.Text;
                categoria.Id_categoria = Convert.ToInt32(id_Categoria);
                if (logica_Producto.Modificar_Categoria(categoria) > 0)
                {
                    DialogResult resultado = new DialogResult();
                    Form mensaje = new MessageBox.MessageBoxModificar();
                    resultado = mensaje.ShowDialog();
                    btnEliminar.Enabled = false;
                    Borrar();
                    Mostrar_Grid();
                }
                else
                {

                    logica_Producto.Insertar_Categorias(categoria);
                    DialogResult resultado = new DialogResult();
                    Form mensaje = new MessageBox.MessageInsertar();
                    resultado = mensaje.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {

                    }
                    Borrar();
                    Mostrar_Grid();
                }
            }
           
        }

        private void Categoria_Load(object sender, EventArgs e)
        {

            Mostrar_Grid();
            btnEliminar.Enabled = false;
        }
        //Mostrar Grid
        public void Mostrar_Grid()
        {
            try
            {
                dtCategoria.DataSource = logica_Producto.Mostrar_Categoria();
                dtCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtCategoria.Columns[0].HeaderText = "ID";
                dtCategoria.Columns[1].HeaderText = "Nombre";
                dtCategoria .Columns[2].HeaderText = "Descripción";
                dtCategoria.Columns[3].Visible = false;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

        }
            private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Categoria_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
            id_Categoria = dtCategoria.CurrentRow.Cells["Id_Categoria"].Value.ToString();
            txtNombreCat.Text = dtCategoria.CurrentRow.Cells["Nombre"].Value.ToString();
            txtDescripcionCa.Text = dtCategoria.CurrentRow.Cells["Descripcion"].Value.ToString();
           
        }

        private void btnBuscar_Categoria_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria_E categoria = new Categoria_E();

                categoria.Buscar = txtBuscar_Categoria.Text;
                dtCategoria.DataSource = logica_Producto.Buscar_Categoria(categoria);
                dtCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtCategoria.Columns[3].Visible = false;
                
            }
            catch (Exception ex)
            {
                //M/*essageBox.Show(ex.ToString());*/
            }
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
        //Borrar Textbox
        private void Borrar()
        {
            txtNombreCat.Text = "";
            txtDescripcionCa.Text = "";
            id_Categoria = null;
        }

        private void txtBuscar_Categoria_TextChanged(object sender, EventArgs e)
        {
            
            if (txtBuscar_Categoria.Text == "")
            {
                dtCategoria.DataSource = logica_Producto.Mostrar_Categoria();
                dtCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtCategoria.Columns[3].Visible = false;
            }
        }

        private void dtCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            id_Categoria = dtCategoria.CurrentRow.Cells["Id_Categoria"].Value.ToString();
            txtNombreCat.Text = dtCategoria.CurrentRow.Cells["Nombre"].Value.ToString();
            txtDescripcionCa.Text = dtCategoria.CurrentRow.Cells["Descripcion"].Value.ToString();
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            Guardar();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Categoria_E categoria = new Categoria_E();
            categoria.Id_categoria = Convert.ToInt32(id_Categoria);
            logica_Producto.Eliminar_Categoria(categoria);
            DialogResult resultado = new DialogResult();
            Form mensaje = new MessageBox.MessageEliminar();
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Borrar();
                Mostrar_Grid();
            }
        }
    }
}
