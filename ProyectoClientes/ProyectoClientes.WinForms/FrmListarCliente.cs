using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClientes.Entidades;
using ProyectoClientes.Negocio;
using Newtonsoft.Json;



namespace ProyectoClientes.WinForms
{
    public partial class FrmListarCliente : Form
    {
        private FrmAgregarCliente _frmAgregarCliente;
        private ClienteServicio _clienteServicio;

        public FrmListarCliente(Form propietario)
        {
            _frmAgregarCliente = new FrmAgregarCliente;
            _clienteServicio = new ClienteServicio;

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
