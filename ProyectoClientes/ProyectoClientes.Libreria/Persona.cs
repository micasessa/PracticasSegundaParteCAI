using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClientes.Libreria
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
    }
}
