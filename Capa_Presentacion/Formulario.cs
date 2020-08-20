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
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using Capa_Entidades;
using Capa_Negocio;
namespace Capa_Presentacion
{
    public partial class Formulario : Form
    {
        Logica_Producto logica_Producto = new Logica_Producto();
       public  int activo = 0;
        public Formulario()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 78;
                Panel_Contenedor.Width = 1116;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //DialogResult resultado = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo);
            //if (resultado == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            //else
            //{

            //}
          
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
           
        }
        private void Abrir_Form<MiForm>() where MiForm:Form,new()
        {
            Form formulario;
            //BUsca en la coleccion formulario
            formulario = Panel_Contenedor.Controls.OfType<MiForm>().FirstOrDefault();
          
            //SI el formulario existe
            if (formulario == null)
            {

                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                Panel_Contenedor.Controls.Add(formulario);
                Panel_Contenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void Abrir_Form2<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            //BUsca en la coleccion formulario
            formulario = Controls.OfType<MiForm>().FirstOrDefault();
            //SI el formulario existe
            if (formulario == null)
            {
                
                formulario = new MiForm();
                
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void btnProductos1_Click(object sender, EventArgs e)
        {
           
            Abrir_Form<Productos_Formulario>();
           

        }
       
        private void btnInicio_Click(object sender, EventArgs e)
        {
            //Abrir_Form<Inicio>();
            Inicio formulario = new Inicio();
            //BUsca en la coleccion formulario
            formulario = Panel_Contenedor.Controls.OfType<Inicio>().FirstOrDefault();

            //SI el formulario existe
            if (formulario == null)
            {

                formulario = new Inicio();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                Panel_Contenedor.Controls.Add(formulario);
                Panel_Contenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.Mostrar_Total();
                formulario.Mostrar_Total_Venta();
            }
            else
            {
                formulario.BringToFront();
                formulario.Mostrar_Total();
                formulario.Mostrar_Total_Venta();
            }

        }
    
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new MessageboxForm();
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {

            }
        }
    

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            Abrir_Form<Venta_Form>();
        }

        private void lblTotal_Prueba_Click(object sender, EventArgs e)
        {
            
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            btnInicio_Click(null,e);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog obtener_imagen = new OpenFileDialog();
            obtener_imagen.InitialDirectory = "C:\\";
            //obtener_imagen.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|.jpg;*.jpeg|PNG(*.png)|*.png|GIF(*.gif)|*.gif";
            if (obtener_imagen.ShowDialog() == DialogResult.OK)
            {
                pictureImagen.ImageLocation = obtener_imagen.FileName;
            }
          
        }
        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            button2.Enabled = true;
        }

        private void btnUsuario_Opciones_Click(object sender, EventArgs e)
        {
            Abrir_Form2<Registrar_Editar>();
        }

        private void MenuHorizontal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Abrir_Form<Persona.btnModificar>();
        }
        //Para arrastrar el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnProveedor_Click(object sender, EventArgs e)
        {
           
            Abrir_Form<Persona.Registrar_Proveedor>();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
        
            Abrir_Form<Pedido_Form>();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        //private void MostrarLabel()
        ////{
        ////    Logica_Personas logica_Personas = new Logica_Personas();
        ////    Login_venta login = new Login_venta();
            
        ////    lblUsuario= logica_Personas.Validar_Usuario();
        //}
        private void MenuHorizontal_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Size = new Size(sw,sh);
            this.Location = new Point(lx,ly);
            button2.Enabled = false;

        }
    }
}
