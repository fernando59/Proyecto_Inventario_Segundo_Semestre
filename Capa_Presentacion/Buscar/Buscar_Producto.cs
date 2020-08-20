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
namespace Capa_Presentacion.Buscar
{
    public partial class Buscar_Producto : Form
    {
        Logica_Producto logica_Producto = new Logica_Producto();
        private string id_Producto = null;
        string buscar = null;
        public Buscar_Producto(string buscar)
        {
            InitializeComponent();
            this.buscar = buscar;
        }

        private void Buscar_Producto_Load(object sender, EventArgs e)
        {
            Mostrar_Grid();
        }
        public void Mostrar_Grid()
        {
            try
            {
                dataProducto.DataSource = logica_Producto.Mostrar_Producto();
                dataProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataProducto.Columns[0].HeaderText = "Cédula de Identidad";
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

        private void dataProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (buscar == "cliente")
            {
                Venta_Form venta = Owner as Venta_Form;
                venta.txtProducto.Text = dataProducto.CurrentRow.Cells[1].Value.ToString();
                venta.txtStock.Text = dataProducto.CurrentRow.Cells[4].Value.ToString();
                venta.txtPrecio.Text = dataProducto.CurrentRow.Cells[3].Value.ToString();
                venta.Id_Productos = dataProducto.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                Pedido_Form pedido = Owner as Pedido_Form;
                pedido.txtProducto.Text = dataProducto.CurrentRow.Cells[1].Value.ToString();
                pedido.txtStock.Text = dataProducto.CurrentRow.Cells[4].Value.ToString();
                pedido.txtPrecio.Text = dataProducto.CurrentRow.Cells[3].Value.ToString();
                pedido.Id_producto = dataProducto.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
