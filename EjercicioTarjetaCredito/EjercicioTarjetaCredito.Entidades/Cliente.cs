using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTarjetaCredito.Entidades
{
    public class Cliente 
    {
        private int _id;

        private string _nombre;
        private string _apellido;
        private string _direccion;
        private long _DNI;
        private string _email;

        private DateTime _fechaNac;
        private string _telefono;
        private bool _activo;
        private Cuenta _cuenta;
        
        public string Apellido { get => _apellido; set => _apellido = value; }

       
        public long DNI { get => _DNI; set => _DNI = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        public int id { get => _id; set => _id = value; }

        
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Email { get => _email; set => _email = value; }

        
        public bool Activo { get => _activo; set => _activo = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }

        public DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }

        public string DisplayParaCombo
        {
            get
            {
                return $"{this._apellido}, {this._nombre}";
            }
        }

        public Cuenta Cuenta { get => _cuenta; set => _cuenta = value; }

        public Cliente()
        {

        }

        public override string ToString()
        {
            return string.Format("{0}) {1} - {2}, {3}", this.id, this._DNI.ToString(), this._apellido, this._nombre);
        }
    }
}