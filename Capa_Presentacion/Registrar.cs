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
    public partial class Registrar : Form
    {
        Logica_Personas logica_Personas = new Logica_Personas();
        public Registrar()
        {
            InitializeComponent();
        }

        private void Registrar_Load(object sender, EventArgs e)
        {

           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Insertar();
        }
        //Insertar 
        private void Insertar()
        {
            if (txtContrasena.Text=="Contraseña" || txtEmail.Text=="Email" || txtUsuario.Text =="Usuario")
            {
                DialogResult resultado = new DialogResult();
                Form mensaje = new MessageBox.VacioForm();
                resultado = mensaje.ShowDialog();
            }
            else
            {
                Usuario usuario = new Usuario();
                usuario.usuario = txtUsuario.Text;
                usuario.contrasena = txtContrasena.Text;
                usuario.email = txtEmail.Text;
                logica_Personas.Insertar_usuario(usuario);
                DialogResult resultado = new DialogResult();
                Form mensaje = new MessageBox.MessageInsertar();
                resultado = mensaje.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    Close();
                }
                
            }
           
        }
        private void Borrar()
        {

            txtUsuario.Text = "";
            txtEmail.Text = "";
            txtContrasena.Text = "";
        }
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtContraseña_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Contraseña")
            {
                txtContrasena.Text = "";
                txtContrasena.Focus();
                txtContrasena.ForeColor = Color.Black;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "Contraseña";
                txtContrasena.ForeColor = Color.Black;
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
