using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTarjetaCredito.Entidades
{   
    public class OperadorFormulario
    {
        private List<TarjetaCredito> _tarjetas;
        private int _cantidadTarjetas;
        private int _limitePromedio;

        //constructor
        public OperadorFormulario(List <TarjetaCredito> lst)
        {
            _tarjetas = lst;
        }

        //PROPIEDADES
        public List<TarjetaCredito> TraerTarjetas
        {
            get{ return _tarjetas; }
        }

        //Hago que me traiga la cant de tarjetas, validando antes que NO sea null
        public int Cantidad
        {
            get
            {
                if (_tarjetas != null)
                {
                    return _tarjetas.Count;
                }
                else return 0;
            }
        }

        //Calcula el limite promedio de todas las tarjetas que vinieron por el constructor
        public double LimitePromedio
        {
            get
            {   //Hago la misma validac q cantidad
                if (_tarjetas != null)
                {   //Primero pongo en cero los valores
                    double promedio = 0;
                    double total = 0;

                    //Busco por c/a tarj cred en la lista que traje, sacar el total del limite de compra
                    foreach(TarjetaCredito tc in _tarjetas)
                    {
                        total = tc.LimiteCompra;
                    }
                    //saco el promedio:
                    promedio = total / _tarjetas.Count;
                    return promedio;

                }
                else return 0;
            }
        }
    }
}
