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
        }

        public List<Cliente> TraerClientes()
        {
            return _clientes;
        }


        //Metodo para agregar!
        public TransactionResult Ingresar (Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);
            string json = WebHelper.Post("cliente", obj);
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            _clientes.Add(cliente);
            return lst;
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

        public TransactionResult Actualizar(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);
            string json = WebHelper.Put("cliente", obj);
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            _clientes.Add(cliente);
            return lst;

        }
    }
}
