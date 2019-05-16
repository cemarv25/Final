using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_III_Final.Clases;

namespace Ejercicio_III_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Pregunta.preguntaNombre();
            Pregunta.preguntaApellido();
            Validador.validar(Pregunta.nombre, Pregunta.apellido);
        }
    }
}
