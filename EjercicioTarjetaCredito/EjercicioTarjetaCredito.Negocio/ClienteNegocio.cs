using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioTarjetaCredito.Entidades.Enum;
using EjercicioTarjetaCredito.Entidades.Excepciones;
using EjercicioTarjetaCredito.Entidades;
using EjercicioTarjetaCredito.AccesoDatos;


namespace EjercicioTarjetaCredito.Negocio
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
        public List<Cliente> GetClientes()
        {
            _listaclientes = _clienteMapper.TraerTodos();
            return _listaclientes;
        }

        public ResultadoTransaccion AddCliente(string nombre, string apellido, DateTime fechaNac, long dni, string tel, string dir, bool act, string email = "micasessa@yahoo.com")
        {
            Cliente cliente = new Cliente();

            cliente.Nombre = nombre;
            cliente.Apellido = apellido;
            cliente.FechaNac = fechaNac;
            cliente.DNI = dni;
            cliente.Telefono = tel;
            cliente.Direccion = dir;
            cliente.Activo = act;
            cliente.Email = email;
            ResultadoTransaccion result = _clienteMapper.Ingresar(cliente);
            return result;
        }

     }
}
