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
    public partial class Buscar_Cliente : Form
    {
        Logica_Personas logica_persona = new Logica_Personas();
        string buscar = null;
        public Buscar_Cliente(string buscar)
        {
            InitializeComponent();
            this.buscar = buscar;
        }

        private void dataCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (buscar=="cliente")
            {
                Venta_Form venta = Owner as Venta_Form;
                venta.txtNombrecliente.Text = dataCliente.CurrentRow.Cells[1].Value.ToString();
                venta.txtTelefono.Text = dataCliente.CurrentRow.Cells[4].Value.ToString();
                venta.Id_Cliente = dataCliente.CurrentRow.Cells[0].Value.ToString();
            }
          
           
        }

        private void Buscar_Cliente_Load(object sender, EventArgs e)
        {
            Mostrar_Cliente();
        }
        private void Mostrar_Cliente()
        {
            dataCliente.DataSource = logica_persona.Mostrar_cliente();
            dataCliente.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
