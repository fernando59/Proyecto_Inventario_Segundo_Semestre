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
    public partial class btnModificar : Form
    {
        Logica_Personas logica_Personas = new Logica_Personas();
        private string Id_Cliente = null;
        public btnModificar()
        {
            InitializeComponent();
        }

        private void Registrar_Cliente_Load(object sender, EventArgs e)
        {
            Mostrar_Cliente();
            btnEliminar.Enabled = false;
        }
        //Mostrar grid
        private void Mostrar_Cliente()
        {
            dataCliente.DataSource = logica_Personas.Mostrar_cliente();
            dataCliente.Columns[0].Visible = false;
           
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            Insertar_PersonaCliente();
        }
        //insertar PersonaCLiente
        private void Insertar_PersonaCliente()
        {
            if (txtApellido.Text == "" || txtDireccion.Text == "" || txtNombre.Text == ""  || txtTelefono.Text == "")
            {
                DialogResult resultado = new DialogResult();
                Form mensaje = new MessageBox.VacioForm();
                resultado = mensaje.ShowDialog();

            }
            else
            {
                Cliente cliente = new Cliente();
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Telefono = txtTelefono.Text;
                cliente.Id = Convert.ToInt32(Id_Cliente);
                if (logica_Personas.Modificar_PersonaCliente(cliente) > 0)
                {
                    cliente.Direccion = txtDireccion.Text;
                    logica_Personas.Modificar_Cliente(cliente);
                    DialogResult resultado = new DialogResult();
                    Form mensaje = new MessageBox.MessageBoxModificar();
                    resultado = mensaje.ShowDialog();
                    Mostrar_Cliente();
                    Eliminar_Textbox();
                    btnEliminar.Enabled = false;
                }
                else
                {
                    logica_Personas.Insertar_PersonaCliente(cliente);
                    Id_Cliente = logica_Personas.Obtener_id(cliente);
                    cliente.Id = Convert.ToInt32(Id_Cliente);
                    cliente.Direccion = txtDireccion.Text;
                    logica_Personas.Insertar_Cliente(cliente);
                    DialogResult resultado = new DialogResult();
                    Form mensaje = new MessageBox.MessageInsertar();
                    resultado = mensaje.ShowDialog();
                    Eliminar_Textbox();
                    Mostrar_Cliente();
                    
                }
               
            }
               

        }
        //Borrar
        private void Eliminar_Textbox()
        {
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            Id_Cliente = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Id_Cliente = dataCliente.CurrentRow.Cells["Id"].Value.ToString();
            txtNombre.Text = dataCliente.CurrentRow.Cells["Nombre"].Value.ToString();
            txtApellido.Text = dataCliente.CurrentRow.Cells["Apellido"].Value.ToString();
            txtDireccion.Text = dataCliente.CurrentRow.Cells["Direccion"].Value.ToString();
            txtTelefono.Text = dataCliente.CurrentRow.Cells["Telefono"].Value.ToString();
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
           
        }
        private void Eliminar()
        {
            Cliente cliente = new Cliente();
            cliente.Id = Convert.ToInt32(Id_Cliente);
            DialogResult resultado = new DialogResult();
            Form mensaje = new MessageBox.MessageEliminar();
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                logica_Personas.Eliminar_Cliente(cliente);
                
                Eliminar_Textbox();
                Mostrar_Cliente();
            }
        }
    }
}
