using EjercicioTarjetaCredito.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjercicioTarjetaCredito.AccesoDatos
{
    public class ClienteMapper
    {
        private List<Cliente> _clientes;

        //Metodos para LISTAR
        public List<Cliente> TraerTodos()
        {
            string json2 = WebHelper.Get("cliente"); // trae un texto en formato json de una web
            List<Cliente> resultado = MapList(json2);
            _clientes = resultado;
            return resultado;
        }
        private List<Cliente> MapList(string json)
        {
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(json); // deserializacion
            return lst;
        }

        //Metodo para AGREGAR!
        public ResultadoTransaccion Ingresar(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);
            string json = WebHelper.Post("cliente", obj);
            ResultadoTransaccion lst = JsonConvert.DeserializeObject<ResultadoTransaccion>(json);
            _clientes.Add(cliente);
            return lst;
        }

        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection cl = new NameValueCollection();
            cl.Add("dni", cliente.DNI.ToString());
            cl.Add("nombre", cliente.Nombre);
            cl.Add("apellido", cliente.Apellido);
            cl.Add("direccion", cliente.Direccion);
            cl.Add("email", cliente.Email);
            cl.Add("telefono", cliente.Telefono);
            cl.Add("fechaNacimiento", cliente.FechaNac.ToString());
            cl.Add("activo", cliente.Activo.ToString());
            return cl;
        }

        public ResultadoTransaccion Actualizar(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);
            string json = WebHelper.Put("cliente", obj);
            ResultadoTransaccion lst = JsonConvert.DeserializeObject<ResultadoTransaccion>(json);
            _clientes.Add(cliente);
            return lst;

        }
    }
}
