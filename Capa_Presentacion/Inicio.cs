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
namespace Capa_Presentacion
{
    public partial class Inicio : Form
    {
        Logica_Producto logica_Producto = new Logica_Producto();
        Formulario formulario=new Formulario();
        Logica_Venta logica_Venta = new Logica_Venta();
        public Inicio()
        {
            InitializeComponent();
           
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Mostrar_Total();
            Mostrar_Total_Venta();
          
        }
     
        public void Mostrar_Total()
        {
            try
            {
                
                lblTotal_Prueba.Text = Convert.ToString(logica_Producto.Mostrar_Total());
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

        }
        //Total Venta
        public void Mostrar_Total_Venta()
        {
            try
            {

                lblTotal_Venta.Text = Convert.ToString(logica_Venta.Mostrar_Total_Venta());
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

        }

        private void Fecha_Tick(object sender, EventArgs e)
        {
            try
            {
                lblHora.Text = DateTime.Now.ToString(" H:mm:ss");
                lblFecha.Text = DateTime.Now.ToLongDateString();
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
      
        }
    }
}
