using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTarjetaCredito.Entidades
{
    public class TarjetaCredito
    {
        //Atributos
        private int _id;
        private int _tipo;
        private int _periodoVencimiento;
        private double _limiteCompra;
        private string _nroPlastico;
        private string _usuario;
        private int _idCliente;
        private Cliente _cliente;

        //Propiedades
        public int Id { get => _id; set => _id = value; }
        public int Tipo { get => _tipo; set => _tipo = value; }
        public int PeriodoVencimiento { get => _periodoVencimiento; set => _periodoVencimiento = value; }
        public double LimiteCompra { get => _limiteCompra; set => _limiteCompra = value; }
        public string NroPlastico { get => _nroPlastico; set => _nroPlastico = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public Cliente Cliente { get => _cliente; set => _cliente = value; }

        //Constructores
        public TarjetaCredito()
        {
        }
        public TarjetaCredito(int id, int tipo, int periodoVencimiento, double limiteCompra, string nroPlastico, string usuario, int idCliente, Cliente cliente)
        {
            _id = id;
            _tipo = tipo;
            _periodoVencimiento = periodoVencimiento;
            _limiteCompra = limiteCompra;
            _nroPlastico = nroPlastico;
            _usuario = usuario;
            _idCliente = idCliente;
            _cliente = cliente;

        }
        public TarjetaCredito( int tipo, int periodoVencimiento, double limiteCompra, string nroPlastico, int idCliente)
        {
            _tipo = tipo;
            _periodoVencimiento = periodoVencimiento;
            _limiteCompra = limiteCompra;
            _nroPlastico = nroPlastico;
            _idCliente = idCliente;
        }
    }
}
