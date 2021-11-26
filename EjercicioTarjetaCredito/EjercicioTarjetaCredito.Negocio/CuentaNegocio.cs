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
    public class CuentaNegocio
    {
        private CuentaMapper _cuentaMapper;
        private List<Cuenta> _listaCuentas;

        public CuentaNegocio()
        {
            _cuentaMapper = new CuentaMapper();
        }

        public Cuenta TraerPorCliente (int idCliente)
        {
            return _cuentaMapper.TraerTodos(idCliente);
        }

        
        
        public Cuenta Alta(Cuenta cuenta)
        {
            ResultadoTransaccion result = _cuentaMapper.Ingresar(cuenta);
            if (result.IsOk)
            {
                Cuenta cuentaNueva = _cuentaMapper.TraerTodos(cuenta.IdCliente);
                return cuentaNueva;
            } else
            {
                return null;
            }
        }
    }
}
