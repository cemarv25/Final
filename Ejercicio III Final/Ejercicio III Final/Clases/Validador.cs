using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_III_Final.Clases
{
    class Validador:Pregunta
    {
       public static void validar(string a, string b)
       {
            a = nombre;
            b = apellido;
            if (a.Length <= 2 || b.Length <=2)
            {
                throw new System.ArgumentException("nombre/apellido no válido");
            }
       }
    }
}
