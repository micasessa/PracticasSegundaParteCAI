using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            NameValueCollection obj = ReverseMap(cliente);
            string json = WebHelper.Post("cliente", obj);
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            _clientes.Add(cliente);
        }

        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection cl = new NameValueCollection();
            cl.Add("dni", cliente.Dni.ToString());
            cl.Add("nombre", cliente.Nombre);
            cl.Add("apellido", cliente.Apellido);
            cl.Add("direccion", cliente.Direccion);
            cl.Add("email", cliente.Email);
            cl.Add("telefono", cliente.Telefono);
            cl.Add("fechaNacimiento", cliente.FechaNac.ToString());
            cl.Add("activo", cliente.Activo.ToString());
            return cl;
        }
    }
}
