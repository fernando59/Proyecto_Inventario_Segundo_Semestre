using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Capa_Entidades;
using Capa_Negocio;

namespace Capa_Presentacion
{
    public partial class Login_venta : Form
    {
        Logica_Personas logica_Persona = new Logica_Personas();
        Usuario usuario = new Usuario();
        public Login_venta()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DarkGray;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "CONTRASEÑA")
            {
                txtContrasena.Text = "";
                txtContrasena.Focus();
                txtContrasena.ForeColor = Color.Black;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "CONTRASEÑA";
                txtContrasena.ForeColor = Color.DarkGray;
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void Ingresar()
        {
           
            usuario.usuario = txtUsuario.Text;
            usuario.contrasena = txtContrasena.Text;
            String usuariovalido = logica_Persona.Validar_Usuario(usuario);
            String contrasenavalido = logica_Persona.Validar_Contrasena(usuario);
            if (usuario.usuario == usuariovalido && usuario.contrasena==contrasenavalido)
            {

                Hide();
                Formulario formulario = new Formulario();
                formulario.Show();
            }
            else
            {
                
                lblError.Location = new Point(33,208);
                lblError.ForeColor = Color.Red;
                lblError2.Location = new Point(33, 222);
                lblError2.ForeColor = Color.Red;
                //DialogResult resultado = new DialogResult();
                //Form mensaje = new MessageBox.VacioForm();
                //resultado = mensaje.ShowDialog();

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void Login_venta_Load(object sender, EventArgs e)
        {
           
            
        }

        private void linkregistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrar registrar = new Registrar();
            registrar.Show();
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
           
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Ingresar();
                e.Handled = true;//Quitar el sonido
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Ingresar();
                e.Handled = true;//Quitar el sonido
            }
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
