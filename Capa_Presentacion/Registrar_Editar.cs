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
    public partial class Registrar_Editar : Form
    {
        Logica_Personas logica_persona = new Logica_Personas();
        string id_registrar = null;
        public Registrar_Editar()
        {
            InitializeComponent();
        }

        private void Registrar_Editar_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
        private void Mostrar()
        {
           
            dataRegistrar.DataSource = logica_persona.Mostrar_Usuario();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            id_registrar = dataRegistrar.CurrentRow.Cells["Id"].Value.ToString();
            txtUsuario.Text = dataRegistrar.CurrentRow.Cells["Usuario"].Value.ToString();
            txtContraseña.Text = dataRegistrar.CurrentRow.Cells["Contrasena"].Value.ToString();
            txtEmail.Text = dataRegistrar.CurrentRow.Cells["Email"].Value.ToString();
       
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text=="" || txtContraseña.Text=="" || txtEmail.Text == "")
            {
                DialogResult resultado = new DialogResult();
                Form mensaje = new MessageBox.VacioForm();
                resultado = mensaje.ShowDialog();
            }
            else
            {
                Usuario usuario = new Usuario();
                usuario.id = Convert.ToInt32(id_registrar);
                usuario.contrasena = txtContraseña.Text;
                usuario.usuario = txtUsuario.Text;
                usuario.email = txtEmail.Text;
                logica_persona.Modificar_usuario(usuario);
                DialogResult resultado = new DialogResult();
                Form mensaje = new MessageBox.MessageInsertar();
                resultado = mensaje.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    Mostrar();
                    //Enviar_Mensaje();
                    Borrar();
                }
            }
            
        }
        private void Borrar()
        {
            txtEmail.Text = "";
            txtContraseña.Text = "";
            txtUsuario.Text = "";
            id_registrar = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
