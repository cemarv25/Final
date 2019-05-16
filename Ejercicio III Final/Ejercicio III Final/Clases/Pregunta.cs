using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_III_Final.Clases
{
    class Pregunta
    {
        public static string nombre;
        public static string apellido;
        public static void preguntaNombre()
        {

            Console.WriteLine("Introduce tu nombre");
            nombre = Console.ReadLine();
        }

        public static void preguntaApellido()
        {
            Console.WriteLine("Introduce tu apellido");
            apellido = Console.ReadLine();
        }
    }
}
