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
    public class TarjetaCreditoNegocio
    {
        private TarjetaClienteMapper _tarjetaMapper;
        public TarjetaCreditoNegocio()
        {
            _tarjetaMapper = new TarjetaClienteMapper();
        }

        //Traigo la lista de todas las tarjetas
        public List<TarjetaCredito> TraerTodas()
        {
            return _tarjetaMapper.TraerTarjetas();
        }

        //Metodo que recibe info de otras clases:
        //TipoTarjetaEnum tipo, PeriodoEnum periodo, Cliente cliente, string plastico, double limiteSolicitado
        public void Alta (TipoTarjetaEnum tipoTarjeta, PeriodoEnum periodo, Cliente cliente, string plastico, double limiteSolicitado)
        {
            //1.Validamos que cliente tenga una cuenta. Si no tiene, no se puede dar de alta una tarjeta (pto E.c)            
            if (cliente.Cuenta == null)
            {
                throw new ClientesSinCuentaException();
            }
            //2.validar que el límite de compra sea menor a el saldo de la cuenta multiplicado por 18 (pto E.d)
            if (cliente.Cuenta.Saldo * 18 > limiteSolicitado)
            {
                throw new ClientesSinLimiteException();
            }

            //Si pasa OK esas 2 validaciones: se puede agregar la tarjeta (Se agrega a la clase y al mapper)
            TarjetaCredito tarjeta = new TarjetaCredito((int)tipoTarjeta, (int) periodo, limiteSolicitado, plastico, cliente.id);
            ResultadoTransaccion result = _tarjetaMapper.Agregar(tarjeta);

            if(!result.IsOk)
            {
                throw new Exception("Error al dar de alta: " + result.Error);
            }
        
        }

        //Se debe generar de forma aleatoria el número de tarjeta de crédito asignada.
        //Puede utilizarse un prefijo a elección y que los últimos 3 dígitos sea o el id del cliente o generarse con random(código al final).
        //Necesito: idcliente, tipotarjeta, periodo
        public string CalculoPlastico(Cliente cliente, TipoTarjetaEnum tipoTarj, PeriodoEnum periodo)
        {
            Random random = new Random();
            int ultimos3dígitos = random.Next(100, 999);

            string plasticoBase = "43180002020" + DateTime.Now.ToString(); //Invento de numeros
            string resultado = plasticoBase + ((int)tipoTarj).ToString() + ((int)periodo) + cliente.id.ToString();
            if (tipoTarj == TipoTarjetaEnum.Amex)
                resultado = resultado.Substring(1, 15);
            return resultado;   
        }



    }
}
