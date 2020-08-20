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

namespace Capa_Presentacion.Buscar
{
    public partial class Buscar_Proveedor : Form
    {
        Logica_Personas logica_Personas = new Logica_Personas();
        public Buscar_Proveedor()
        {
            InitializeComponent();
        }

        private void Buscar_Proveedor_Load(object sender, EventArgs e)
        {
            Mostrar_Proveedor();
        }
        //Mostrar Proveedor
        private void Mostrar_Proveedor()
        {
            dataProveedor.DataSource = logica_Personas.Mostrar_proveedor();
            dataProveedor.Columns[0].Visible = false;
        }

        private void dataProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Pedido_Form pedido = Owner as Pedido_Form;
            pedido.txtNombreproveedor.Text = dataProveedor.CurrentRow.Cells[1].Value.ToString();
            pedido.txtTelefono.Text = dataProveedor.CurrentRow.Cells[4].Value.ToString();
            pedido.id_proveedor = dataProveedor.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
