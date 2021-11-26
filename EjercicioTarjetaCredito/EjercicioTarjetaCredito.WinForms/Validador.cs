using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioTarjetaCredito.WinForms
{
    public static class Validador
    {
        public static void ValidacionString(TextBox _text)
        {
            //Valido que no este vacio
            if (string.IsNullOrEmpty(_text.Text))
                throw new Exception("Ingrese un valor. El campo no puede quedar vacio");
        }

        public static void ValidacionInt(TextBox _text)
        {
            //primero valido que no este vacio
            if (string.IsNullOrEmpty(_text.Text))
                throw new Exception("Ingrese un valor. El campo no puede quedar vacio");

            //Valido que lo que haya ingresado sea un numero y no un string
            int numero;
            if (!int.TryParse(_text.Text, out numero)) 
                throw new Exception($"Ingrese Valores Numérico");

        }
        public static void ValidacionDouble(TextBox _text)
        {
            //primero valido que no este vacio
            if (string.IsNullOrEmpty(_text.Text))
                throw new Exception("Ingrese un valor. El campo no puede quedar vacio");

            //Valido que lo que haya ingresado sea un numero y no un string
            double numero;
            if (!double.TryParse(_text.Text, out numero))
                throw new Exception($"Ingrese Valores Numérico");

        }

        

    }
}
