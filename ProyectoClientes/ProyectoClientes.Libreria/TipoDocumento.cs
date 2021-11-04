using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClientes.Libreria
{
    public class TipoDocumento
    {
        private int _codigo;
        private string _descripcion;

        //Propiedades
        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }


        //Constructor
        public TipoDocumento (int codigo, string descrip)
        {
            _codigo = codigo;
            _descripcion = descrip;
        }


    }
}
