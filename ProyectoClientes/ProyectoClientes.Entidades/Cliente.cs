using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ProyectoClientes.Entidades
{
    public class Cliente : Persona
    {
        //Id (int) , Cuit (long),
        //Email, FechaNacimiento (datetime), Activo (bool),
        //campos string: Nombre, Apellido, Direccion, Telefono.
        private long _dni;
        private int _id;
        private string _email;
        private DateTime _fechaNacimiento;
        private bool _activo;
        private string _direccion;
        private string _telefono;

        //Propiedades
        public int Id => _id;
        public long Dni => _dni;
        public string Email => _email;
        public DateTime FechaNac => _fechaNacimiento;
        public bool Activo => _activo;
        public string Direccion => _direccion;
        public string Telefono => _telefono;

        //Constructores
        public Cliente(int id, long dni, string nombre, string apellido, string direccion, string telefono) : base(nombre, apellido)
        {
            _id = id;
            _dni = dni;
            _direccion = direccion;
            _telefono = telefono;
        }
        public Cliente(int id, long dni, string nombre, string apellido, string direccion, string telefono, DateTime fechaNac, bool activo, string email) : base(nombre, apellido)
        {
            _id = id;
            _dni = dni;
            _direccion = direccion;
            _telefono = telefono;
            _fechaNacimiento = fechaNac;
            _activo = activo;
            _email = email;
        }

        //Metodos
        public string Mostrar
        {
            get
            {
                return "Cliente " + _nombre;
            }
        }

    }
}
