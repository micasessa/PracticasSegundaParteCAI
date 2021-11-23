using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClientes.Entidades
{
    public class Validador
    {        
        public static string pedirString(string mensaje)
        {
            string retorno = "";
            do
            {
                Console.WriteLine(mensaje);
                retorno = Console.ReadLine();
                if (retorno == "")
                {
                    Console.WriteLine("El string no puede estar vacio");
                }
            } while (retorno == "");
            return (retorno);
        }
        public static int pedirInteger(string mensaje, int minimo, int maximo)
        {
            int numero = minimo - 1;
            bool pudeConvertir;

            do
            {
                Console.WriteLine(mensaje);
                pudeConvertir = Int32.TryParse(Console.ReadLine(), out numero);
                if (pudeConvertir)
                {
                    if (numero < minimo || numero > maximo)
                    {
                        Console.WriteLine(mensaje);
                    }
                }
                else
                {
                    Console.WriteLine("Debe ingresar un valor numerico");
                    numero = minimo - 1;
                }
            } while (numero < minimo || numero > maximo);

            return numero;
        }

        public static int pedirInt(string mensaje)
        {
            int numero = 0;
            bool pudeConvertir = true;

            do
            {
                Console.WriteLine(mensaje);
                pudeConvertir = Int32.TryParse(Console.ReadLine(), out numero);
                if (pudeConvertir)
                {
                    if (numero > 0)
                    {
                        pudeConvertir = true;
                    }
                }
                else
                {
                    Console.WriteLine("Debe ingresar un valor numerico");
                }
            } while (!pudeConvertir && numero > 0);

            return numero;
        }
        public static double pedirDouble(string mensaje)
        {
            double retorno = 0;
            bool valido = false;
            do
            {
                Console.WriteLine(mensaje);
                valido = Double.TryParse(Console.ReadLine(), out retorno);
                if (!valido)
                {
                    Console.WriteLine("Debe ingresar un numero");
                }
            } while (!valido);
            return (retorno);
        }

        public static string ValidarNumero(string input, string campoEsperado)
        {
            int nro;
            string error = "";
            if (!int.TryParse(input, out nro))
            {
                error = campoEsperado + " debe ser numérico" + "\n";
            }
            else if (nro < 0)
            {
                error = campoEsperado + " debe ser positivo" + "\n";
            }
            return error;
        }
        public static string ValidarString(string input, string campoEsperado)
        {
            string error = "";
            if (input == "")
            {
                error = campoEsperado + " no puede ser vacío" + "\n";
            }
            return error;
        }
        public static string ValidarComboBox(int num, string campoEsperado)
        {
            string error = "";
            if (num == -1)
            {
                error = "Seleccione un " + campoEsperado + "\n";
            }
            return error;
        }
        public static string ValidarFecha(DateTime input, string campoEsperado)
        {
            string error = "";
            if (input <= DateTime.Today)
            {
                error = campoEsperado + " la fecha debe ser posterior al día de hoy" + "\n";
            }
            return error;
        }
    }
}
