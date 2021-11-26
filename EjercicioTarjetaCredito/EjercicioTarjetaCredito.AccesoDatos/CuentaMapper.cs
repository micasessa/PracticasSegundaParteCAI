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
    public class CuentaMapper
    {
        
        //Para Listar
        public Cuenta TraerTodos(int idCliente)
        {
            string json2 = WebHelper.Get("tarjeta"+ idCliente.ToString());
            Cuenta resultado = MapList(json2);
            return resultado;
        }

        private Cuenta MapList(string json)
        {
            Cuenta lst = JsonConvert.DeserializeObject<Cuenta>(json);
            return lst;
        }

        //Para agregar
        public ResultadoTransaccion Ingresar(Cuenta cuenta)
        {
            NameValueCollection obj = ReverseMap(cuenta);
            string json = WebHelper.Post("Cuenta", obj);
            ResultadoTransaccion lst = JsonConvert.DeserializeObject < ResultadoTransaccion>(json);
            return lst;
        }

        private NameValueCollection ReverseMap(Cuenta cuenta)
        {
            NameValueCollection cuen = new NameValueCollection();
            cuen.Add("id", cuenta.Id.ToString());
            cuen.Add("idCliente", cuenta.IdCliente.ToString());
            cuen.Add("Saldo", cuenta.Saldo.ToString());
            cuen.Add("Descripcion", cuenta.Descripcion);
            return cuen;
        }
    }
}
