using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClientes.Entidades
{
    public class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected TipoDocumento _tipoDocumento;

        //Propiedades
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public TipoDocumento TipoDocumento { get => _tipoDocumento; }

        //Constructores
        public Persona()
        { }
        public Persona (string nombre, string apellido, TipoDocumento tipoDoc)
        {
            _nombre = nombre;
            _apellido = apellido;
            _tipoDocumento = tipoDoc;
        }
        public Persona(string nombre, string apellido)
        {
            _nombre = nombre;
            _apellido = apellido;
        }

        public override string ToString()
        {
            return $"{this._nombre} {this._apellido}";
        }
    }
}
