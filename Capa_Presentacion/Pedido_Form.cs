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
    public partial class Pedido_Form : Form
   
    {
        Logica_Pedido logica_Pedido = new Logica_Pedido();
        public string id_proveedor = null;
        public string Id_producto = null;
        public Pedido_Form()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscar="proveedor";
            Buscar.Buscar_Producto buscar_Producto = new Buscar.Buscar_Producto(buscar);
            AddOwnedForm(buscar_Producto);
            buscar_Producto.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Pedido();
        }

        private void Pedido()
        {
            if (txtNombreproveedor.Text=="" || txtPrecio.Text=="" || txtStock.Text=="" || txtTelefono.Text=="" || txtProducto.Text == "")
            {
                DialogResult resultado = new DialogResult();
                Form mensaje = new MessageBox.VacioForm();
                resultado = mensaje.ShowDialog();
            }
            else
            {
                Pedido pedido = new Pedido();
                pedido.Fecha = dateFecha.Text;
                pedido.Id_proveedor = Convert.ToInt32(id_proveedor);
                pedido.Tipo_Pago = comboPago.Text;
                logica_Pedido.Insertar_Pedido(pedido);
                String idVentaaux = logica_Pedido.Obtener_Pedido(pedido);
                Detalle_Pedido detalle_Pedido = new Detalle_Pedido();
                detalle_Pedido.Id_Productos = Convert.ToInt32(Id_producto);
                detalle_Pedido.cantidad = Convert.ToInt32(Numeros.Value.ToString());
                detalle_Pedido.Id_pedido = Convert.ToInt32(idVentaaux);
                detalle_Pedido.precio = Convert.ToDecimal(txtPrecio.Text);
                logica_Pedido.Insertar_DetallePedido(detalle_Pedido);
                detalle_Pedido.Stock = Convert.ToInt32(Numeros.Value.ToString());
                logica_Pedido.Sumar_Stock(detalle_Pedido);
                DialogResult resultado = new DialogResult();
                Form mensaje = new MessageBox.MessageInsertar();
                resultado = mensaje.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    Mostrar_Grid();
                    //Enviar_Mensaje();
                    Borrar();
                }
                
            }
            

        }
    
        //Restar stock
        private void Restar_Stock()
        {

        }
        //Borrar textbox
        private void Borrar()
        {
            txtNombreproveedor.Text = "";
            txtPrecio.Text = "";
            txtProducto.Text = "";
            txtStock.Text = "";
            txtTelefono.Text = "";
            id_proveedor = null;
            Id_producto = null;
        }
    

        private void Pedido_Form_Load(object sender, EventArgs e)
        {
            Mostrar_Grid();
        }
        //Mostrar Pedido
        public void Mostrar_Grid()
        {

            dataPedido.DataSource = logica_Pedido.Mostrar_Pedido();
            dataPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataPedido.Columns[0].HeaderText = "Id";
            dataPedido.Columns[1].HeaderText = "Nombre";
            dataPedido.Columns[2].HeaderText = "Apellido";
            dataPedido.Columns[3].HeaderText = "Producto";
            dataPedido.Columns[4].HeaderText = "Cantidad";

        }

        private void btnBuscarCLiente_Click(object sender, EventArgs e)
        {
           
            Buscar.Buscar_Proveedor buscar_proveedor = new Buscar.Buscar_Proveedor();
            AddOwnedForm(buscar_proveedor);
            buscar_proveedor.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
