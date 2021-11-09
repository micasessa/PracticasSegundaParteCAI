using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClientes.Libreria;


namespace ProyectoClientes.WinForms
{
    public partial class FrmListarCliente : Form
    {
        private List<Cliente> _clientes;

        public FrmListarCliente(Form propietario)
        {
            _clientes = new List<Cliente>();
            _clientes.Add(new Cliente(1, 23337468552, "Carlos", "Perez", "Av.Callao 3333", "01139451829"));

            this.Owner = propietario;
            
            
            InitializeComponent();
        }

        private void btnVolver_Click_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void FrmListarCliente_Load(object sender, EventArgs e)
        {
            CargarListaCliente();
        }

        private void CargarListaCliente()
        {
            _lstClientes.DataSource = null;
            _lstClientes.DataSource = this._clientes;
            _lstClientes.DisplayMember = "Mostrar";
            _lstClientes.ValueMember = "CUIT";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente elegido = (Cliente)_lstClientes.SelectedItem;
            MessageBox.Show(elegido.Nombre);
        }
    }
}
