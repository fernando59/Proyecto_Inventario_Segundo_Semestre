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

namespace Capa_Presentacion.Persona
{
    public partial class Registrar_Proveedor : Form
    {
        Logica_Personas logica_Persona = new Logica_Personas();
        string Id_Proveedor = null;
        public Registrar_Proveedor()
        {
            InitializeComponent();
        }

        private void Registrar_Proveedor_Load(object sender, EventArgs e)
        {
            Mostrar_Proveedor();
            btnEliminar.Enabled = false;
        }
        private void Mostrar_Proveedor()
        {
            dataproveedor.DataSource = logica_Persona.Mostrar_proveedor();

        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        /// <summary>
        /// Metodo para guardar
        /// </summary>
        private void Guardar()
        {
            if (txtApellido.Text == "" || txtcorreo.Text == "" || txtNombre.Text == "" || txtProducto.Text == "" || txtTelefono.Text == "")
            {
                DialogResult resultado = new DialogResult();
                Form mensaje = new MessageBox.VacioForm();
                resultado = mensaje.ShowDialog();
            }
            else
            {
                Proveedor proveedor = new Proveedor();
                proveedor.Nombre = txtNombre.Text;
                proveedor.Apellido = txtApellido.Text;
                proveedor.Telefono = txtTelefono.Text;
                proveedor.Id = Convert.ToInt32(Id_Proveedor);
                if (logica_Persona.Modificar_PersonaProveedor(proveedor) > 0)
                {
                    proveedor.Correo = txtcorreo.Text;
                    proveedor.producto = txtProducto.Text;
                    logica_Persona.Modificar_Proveedor(proveedor);
                    DialogResult resultado = new DialogResult();
                    Form mensaje = new MessageBox.MessageBoxModificar();
                    resultado = mensaje.ShowDialog();
                    Mostrar_Proveedor();
                    Eliminar_Textbox();
                    btnEliminar.Enabled = false;
                }
                else
                {
                    logica_Persona.Insertar_PersonaProveedor(proveedor);
                    Id_Proveedor = logica_Persona.Obtener_id_proveedor(proveedor);
                    proveedor.Id = Convert.ToInt32(Id_Proveedor);
                    proveedor.Correo = txtcorreo.Text;
                    proveedor.producto = txtProducto.Text;
                    logica_Persona.Insertar_Proveedor(proveedor);
                    DialogResult resultado = new DialogResult();
                    Form mensaje = new MessageBox.MessageInsertar();
                    resultado = mensaje.ShowDialog();
                    Eliminar_Textbox();
                    Mostrar_Proveedor();
                }
            }
        }
        //Borrar
        private void Eliminar_Textbox()
        {
            txtApellido.Text = "";
            txtcorreo.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtProducto.Text = "";
            Id_Proveedor = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
        
            Id_Proveedor = dataproveedor.CurrentRow.Cells["Id"].Value.ToString();
            txtNombre.Text = dataproveedor.CurrentRow.Cells["Nombre"].Value.ToString();
            txtProducto.Text = dataproveedor.CurrentRow.Cells["Producto"].Value.ToString();
            txtcorreo.Text = dataproveedor.CurrentRow.Cells["Correo"].Value.ToString();
            txtApellido.Text = dataproveedor.CurrentRow.Cells["Apellido"].Value.ToString();
            txtTelefono.Text = dataproveedor.CurrentRow.Cells["Telefono"].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.Id = Convert.ToInt32(Id_Proveedor);
            DialogResult resultado = new DialogResult();
            Form mensaje = new MessageBox.MessageEliminar();
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                logica_Persona.Eliminar_Proveedor(proveedor);

                Eliminar_Textbox();
                Mostrar_Proveedor();
            }
        }
    }
}
