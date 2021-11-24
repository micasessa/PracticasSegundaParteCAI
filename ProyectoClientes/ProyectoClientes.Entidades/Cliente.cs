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
        private string _id;
        private string _email;
        private DateTime _fechaNacimiento;
        private bool _activo;
        private string _direccion;
        private string _telefono;

        //Propiedades

        public long Dni { get => _dni; set => _dni = value; }
        public string Id { get => _id; set => _id = value; }        
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime FechaNac { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public bool Activo { get => _activo; set => _activo = value; }

        //Constructores
        public Cliente() : base()
        { }
        public Cliente(long dni, string nombre, string apellido, string direccion, string telefono) : base(nombre, apellido)
        {
            _dni = dni;
            _direccion = direccion;
            _telefono = telefono;
        }

        public  Cliente (string nombre, string apellido, DateTime fechaNac, long dni, string tel, string dir, bool act, string email = "micasessa@yahoo.com") : base(nombre, apellido)
        {            
            _dni = dni;
            _direccion = dir;
            _telefono = tel;
            _fechaNacimiento = fechaNac;
            _activo = act;
            _email = email;
        }
        public Cliente(string id, long dni, string nombre, string apellido, string direccion, string telefono, DateTime fechaNac, bool activo, string email) : base(nombre, apellido)
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
