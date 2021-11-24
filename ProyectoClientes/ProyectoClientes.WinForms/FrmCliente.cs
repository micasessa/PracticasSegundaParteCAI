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
                //Valido primero
                Validaciones();
                string codigo = _txtCodigo.Text;

                long dni = Convert.ToInt32(_txtDni.Text);
                string nombre = _txtNombre.Text;
                string apellido = _txtApellido.Text;
                string email = _txtEmail.Text;
                string direccion = _txtDireccion.Text;
                string telefono = _txtTelefono.Text;
                DateTime fechaNacimiento = dateTimePicker1.Value;
                bool activo = _chckActivo.Checked;

                TransactionResult resultado = null;
                //Significa que no hay cliente en el sistema
                if (string.IsNullOrEmpty(codigo)) 
                {
                    resultado = _clienteNegocio.AddCliente(nombre, apellido, fechaNacimiento, dni, telefono, direccion, activo, email);
                } else
                {
                    resultado = _clienteNegocio.ModificarCliente(codigo, nombre, apellido, fechaNacimiento, dni, telefono, direccion, activo, email);
                    //aca puedo mandar un mensaje
                }
                MessageBox.Show(resultado.Id.ToString());
                Limpiar();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Validaciones()
        {
            //FALTAN VALICACIONES DE FECHANAC + ACTIVO
            long dni = Convert.ToInt32(_txtDni.Text);
            string nombre = _txtNombre.Text;
            string apellido = _txtApellido.Text;
            string email = _txtEmail.Text;
            string direccion = _txtDireccion.Text;
            string telefono = _txtTelefono.Text;
            DateTime fechaNacimiento = dateTimePicker1.Value;
            bool activo = _chckActivo.Checked;

            
            if (string.IsNullOrEmpty(_txtDni.Text))
            {
                throw new Exception("El campo debe estar completo. Por favor completar con dni ");
            }
            if (string.IsNullOrEmpty(_txtNombre.Text) || )
            {
                throw new Exception("El campo debe estar completo. Por favor completar con nombre ");
            }
            if (string.IsNullOrEmpty(_txtApellido.Text))
            {
                throw new Exception("El campo debe estar completo. Por favor completar con apellido ");
            }
            if (string.IsNullOrEmpty(_txtEmail.Text))
            {
                throw new Exception("El campo debe estar completo. Por favor completar con email ");
            }
            if (string.IsNullOrEmpty(_txtDireccion.Text))
            {
                throw new Exception("El campo debe estar completo. Por favor completar con direccion ");
            }
            if (string.IsNullOrEmpty(_txtTelefono.Text))
            {
                throw new Exception("El campo debe estar completo. Por favor completar con telefono ");
            }
            
            
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

        private void _btnVolverBoton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void _btnRecargar_Click(object sender, EventArgs e)
        {
            try
            {
                Recargar();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Recargar()
        {
            _clientes = _clienteNegocio.TraerClientes();
        }
    }
}
