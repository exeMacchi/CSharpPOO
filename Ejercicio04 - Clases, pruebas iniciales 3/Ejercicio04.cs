using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04___Clases__pruebas_iniciales_3
{
    class Ejercicio04
    {
        static void Main()
        {
            Persona persona1 = new Persona("Lionel", 1987);
            persona1.Saludar();

            PersonaInglesa persona2 = new PersonaInglesa("Joy", 1986);
            persona2.Saludar();

            Console.ReadKey();
        }
    }
}
