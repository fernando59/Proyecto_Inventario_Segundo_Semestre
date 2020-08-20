using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidades;
using Capa_Negocio;
namespace Capa_Presentacion
{
    public partial class Venta_Form : Form
    {
        Logica_Venta logica_Venta = new Logica_Venta();
        public string Id_Cliente = null;
        public string Id_Productos = null;
        public Venta_Form()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
          
            Mostrar_Grid();
        }
        //MostrarVenta
        public void Mostrar_Grid()
        {
            Venta venta = new Venta();
            venta.Fecha = dateFecha.Text;
            dataVenta.DataSource = logica_Venta.Mostrar_Venta(venta);
            dataVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataVenta.Columns[0].HeaderText = "Id";
            dataVenta.Columns[1].HeaderText = "Nombre";
            dataVenta.Columns[2].HeaderText = "Precio";
            dataVenta.Columns[3].HeaderText = "Cantidad";
            dataVenta.Columns[4].HeaderText = "Cliente";

        }

       
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscar = "cliente";
            Buscar.Buscar_Producto buscar_Producto = new Buscar.Buscar_Producto(buscar);
            AddOwnedForm(buscar_Producto);
            buscar_Producto.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarCLiente_Click(object sender, EventArgs e)
        {
            string buscar = "cliente";
            Buscar.Buscar_Cliente buscar_Cliente = new Buscar.Buscar_Cliente(buscar);
            AddOwnedForm(buscar_Cliente);
            buscar_Cliente.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Insertar_Venta();
           
        }
        //Insertar venta
        private void Insertar_Venta()
        {
            if (txtNombrecliente.Text=="" || txtPrecio.Text=="" || txtProducto.Text=="" || txtTelefono.Text=="" || txtStock.Text== "") 
            {
                DialogResult resultado = new DialogResult();
                Form mensaje = new MessageBox.VacioForm();
                resultado = mensaje.ShowDialog();
            }
            else
            {
                Venta venta = new Venta();
                venta.Fecha = dateFecha.Text;
                venta.Id_cliente = Convert.ToInt32(Id_Cliente);
                venta.Tipo_Pago = comboPago.Text;
                logica_Venta.Insertar_Venta(venta);
                String idVentaaux = logica_Venta.Obtener_idVenta(venta);
                Detalle_Venta detalle_Venta = new Detalle_Venta();
                detalle_Venta.Id_Productos = Convert.ToInt32(Id_Productos);
                detalle_Venta.cantidad = Convert.ToInt32(Numeros.Value.ToString());
                detalle_Venta.Id_Venta = Convert.ToInt32(idVentaaux);
                detalle_Venta.precio = Convert.ToDecimal(txtPrecio.Text);
                logica_Venta.Insertar_DetalleVenta(detalle_Venta);
                detalle_Venta.Stock = Convert.ToInt32(Numeros.Value.ToString());
                logica_Venta.Restar_Stock(detalle_Venta);
                DialogResult resultado = new DialogResult();
                Form mensaje = new MessageBox.MessageInsertar();
                resultado = mensaje.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    Mostrar_Grid();
                  

                }
                Enviar_Mensaje();
                Borrar();
            }
           


        }
        //Restar stock
        private void Restar_Stock()
        {

        }
        //Borrar textbox
        private void Borrar()
        {
            txtNombrecliente.Text = "";
            txtPrecio.Text = "";
            txtProducto.Text = "";
            txtStock.Text = "";
            txtTelefono.Text = "";
            Id_Cliente = null;
            Id_Productos = null;
        }
        //Enviar gmal
        private void Enviar_Mensaje()
        {
          
            MailMessage mensaje = new MailMessage();
            mensaje.To.Add("fer_mercado_2000@hotmail.com");
            mensaje.Subject = "¡¡¡¡ Venta Realizada !!!";
            mensaje.SubjectEncoding = Encoding.UTF8;
            mensaje.Body = " Venta realiza por :"+txtNombrecliente.Text+" producto "+txtProducto.Text+" "+comboPago.Text;
            mensaje.BodyEncoding = Encoding.UTF8;
            mensaje.IsBodyHtml = true;
            mensaje.From = new MailAddress("fer_mercado_2000@hotmail.com");
            SmtpClient cliente = new SmtpClient();
            cliente.Credentials = new NetworkCredential("fer_mercado_2000@hotmail.com", "familia2000");
            cliente.Port = 25;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.live.com";
            cliente.Send(mensaje);


        }

        private void dataVenta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataVenta.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (Convert.ToString((e.Value)) == "Debe")
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.Red;
                    
                }
                else
                {
                    if (Convert.ToString((e.Value)) == "Fiado")
                    {
                        e.CellStyle.ForeColor = Color.Black;
                        e.CellStyle.BackColor = Color.Orange;
                    }
                }
            }
       
        }
        private void dtgResumen_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //try
            //{
            //    >for (int count = 0; count < dtgResumen.Rows.Count; count++)
            //    {
            //        if (Convert.ToInt32(dtgResumen.Rows[count].Cells[5].Value) != 0)
            //        {
            //            dtgResumen.Rows[count].DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            //        }
            //            >else
            //                {
            //            dtgResumen.Rows[count].DefaultCellStyle.BackColor = System.Drawing.Color.White;
            //        }
            //    }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar_Grid();
        }

        private void dateFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
