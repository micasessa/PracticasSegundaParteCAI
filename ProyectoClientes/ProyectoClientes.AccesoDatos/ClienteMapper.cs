using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoClientes.Entidades;

namespace ProyectoClientes.AccesoDatos
{
    public class ClienteMapper
    {
        private List<Cliente> _clientes;

        //constructor
        public ClienteMapper()
        {
            _clientes = new List<Cliente>();
            _clientes.Add(new Cliente(1, 23337468552, "Carlos", "Perez", "Av.Callao 3333", "01139451829"));
            _clientes.Add(new Cliente(2, 24447468552, "Sandra", "Martinez", "Av.Callao 3333", "01133492782"));
        }

        public List<Cliente> TraerClientes()
        {
            return _clientes;
        }

        public void Agregar (Cliente cliente)
        {
            _clientes.Add(cliente);
        }
    }
}
