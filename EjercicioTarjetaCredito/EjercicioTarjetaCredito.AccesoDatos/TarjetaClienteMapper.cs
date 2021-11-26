using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioTarjetaCredito.Entidades;
using EjercicioTarjetaCredito.Entidades.Enum;
using Newtonsoft.Json;
using System.Collections.Specialized;


namespace EjercicioTarjetaCredito.AccesoDatos
{
    public class TarjetaClienteMapper
    {
        private List <TarjetaCredito> _tarjetasCredito;

        public List<TarjetaCredito> TraerTarjetas()
        {
            string json2 = WebHelper.Get("tarjetacredito/{registro}");
            _tarjetasCredito = MapList(json2);
            return _tarjetasCredito;
        }

        private List<TarjetaCredito> MapList(string json)
        {
            List<TarjetaCredito> lst = JsonConvert.DeserializeObject<List<TarjetaCredito>>(json);
            return lst;
        }

        public ResultadoTransaccion Agregar (TarjetaCredito tarjeta)
        {
            NameValueCollection obj = ReverseMap(tarjeta);
            string json = WebHelper.Post("tarjetacredito", obj);
            ResultadoTransaccion lst = JsonConvert.DeserializeObject<ResultadoTransaccion>(json);
            _tarjetasCredito.Add(tarjeta);
            return lst;
        }

        private NameValueCollection ReverseMap(TarjetaCredito tarjeta)
        {
            NameValueCollection t = new NameValueCollection();
            t.Add("tipo", tarjeta.Tipo.ToString());
            t.Add("periodoVencimiento", tarjeta.PeriodoVencimiento.ToString() );
            t.Add("limiteCompra", tarjeta.LimiteCompra.ToString("0.00"));
            t.Add("nroPlastico", tarjeta.NroPlastico);
            t.Add("usuario", tarjeta.Usuario);
            t.Add("idCliente", tarjeta.IdCliente.ToString());
            return t;
        }
    }
}
