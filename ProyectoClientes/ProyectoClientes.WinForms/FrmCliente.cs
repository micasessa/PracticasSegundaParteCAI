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
    public partial class FrmCliente : Form
    {
        private ClienteNegocio _clienteNegocio;
        private List<Cliente> _clientes;
        public FrmCliente(Form main)
        {
            InitializeComponent();
            this.Owner = main;

            //Inicializo atrib clientenegocio
            _clienteNegocio = new ClienteNegocio();

        }

        private void _btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = _txtCodigo.Text;

                long dni = Convert.ToInt32(_txtDni.Text);
                string nombre = _txtNombre.Text;
                string apellido = _txtApellido.Text;
                string email = _txtEmail.Text;
                string direccion = _txtDireccion.Text;
                long telefono = Convert.ToInt32(_txtTelefono.Text);
                DateTime fechaNacimiento = dateTimePicker1.Value;
                bool activo = _chckActivo.Checked;
               



            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void _btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            _txtCodigo.Clear();
            _txtDni.Clear();
            _txtNombre.Clear();
            _txtApellido.Clear();
            _txtEmail.Clear();
            _txtDireccion.Clear();
            _txtTelefono.Clear();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
