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
        public string Nombre { get => _nombre; }
        public string Apellido { get => _apellido; }
        public TipoDocumento TipoDocumento { get => _tipoDocumento; }

        //Constructores
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
