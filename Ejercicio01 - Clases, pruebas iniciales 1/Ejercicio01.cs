using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01___Clases__pruebas_iniciales_1
{
    class Ejercicio01
    {
        static void Main()
        {
            Persona persona = new Persona();

            persona.SetNombre(PedirNombre());
            persona.SetEdad(PedirEdad());

            Console.WriteLine();
            Console.WriteLine($"Nombre: {persona.GetNombre()}");
            Console.WriteLine($"Edad: {persona.GetEdad()}");
            Console.WriteLine($"Saludo: {persona.Saludar()}");
            Console.ReadKey();
        }

        static string PedirNombre()
        {
            Console.Write("Ingrese su nombre: ");
            return Console.ReadLine();
        }
        
        static byte PedirEdad()
        {
            Console.Write("Ingrese su edad: ");
            return byte.Parse(Console.ReadLine());
        }
    }
}
