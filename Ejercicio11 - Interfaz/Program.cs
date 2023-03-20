using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11___Interfaz
{
    class Program
    {
        static void Main()
        {
            Circulo circulito = new Circulo(PedirRadio());

            Console.Write("Área del círculo: ");
            Console.WriteLine(circulito.CalcularArea().ToString("#.##"));

            Console.Write("Perímetro del círculo: ");
            Console.WriteLine(circulito.CalcularPerimetro().ToString("#.##"));
        }

        static double PedirRadio()
        {
            Console.Write("Ingrese el radio del círculo: ");
            return double.Parse(Console.ReadLine());
        }
    }
}
