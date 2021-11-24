using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoClientes.Entidades;
using ProyectoClientes.AccesoDatos;
using ProyectoClientes.Negocio;

namespace ProyectoClientes.Negocio
{
    public class ClienteNegocio
    {
        private ClienteMapper _clienteMapper;
        private List<Cliente> _listaclientes;

        //Constructor
        public ClienteNegocio()
        {
            _clienteMapper = new ClienteMapper();
        }
        //metodos
        public List<Cliente> GetClientes()
        {
            return _clienteMapper.TraerClientes();
        }
        public TransactionResult AddCliente (string nombre, string apellido, DateTime fechaNac, long dni, string tel, string dir, bool act, string email = "micasessa@yahoo.com")
        {
            Cliente cliente = new Cliente();

            cliente.Nombre = nombre;
            cliente.Apellido = apellido;
            cliente.FechaNac = fechaNac;
            cliente.Dni = dni;
            cliente.Telefono = tel;
            cliente.Direccion = dir;
            cliente.Activo = act;
            cliente.Email = email;
            TransactionResult result = _clienteMapper.Ingresar(cliente);
            return result;
        }
        public TransactionResult ModificarCliente(string codigo, string nombre, string apellido, DateTime fechaNac, long dni, string tel, string dir, bool act, string email = "micasessa@yahoo.com")
        {
            Cliente cliente = new Cliente();
            cliente.Id = codigo;
            cliente.Nombre = nombre;
            cliente.Apellido = apellido;
            cliente.FechaNac = fechaNac;
            cliente.Dni = dni;
            cliente.Telefono = tel;
            cliente.Direccion = dir;
            cliente.Activo = act;
            cliente.Email = email;
            TransactionResult result = _clienteMapper.Actualizar(cliente);
            return result;
        }



    }
}
