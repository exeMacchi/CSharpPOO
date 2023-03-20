using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03___Clases__herencia
{
    class Ejercicio03
    {
        static void Main()
        {
            Caballo caballito = new Caballo("Spirit");
            Humano ricardo = new Humano("Ricardo");
            Gorila iWantToBeAMonkey = new Gorila("Copito");
            Mamiferos mamifero = new Mamiferos("Apolo");
            // Principio de sustitución
            Mamiferos mamiferoHumano = new Humano("Rogelio"); 

            Console.WriteLine($"Nombre caballo: {caballito.GetNombreSerVivo()}");
            Console.WriteLine($"Nombre humano: {ricardo.GetNombreSerVivo()}");
            Console.WriteLine($"Nombre gorila: {iWantToBeAMonkey.GetNombreSerVivo()}");
            Console.WriteLine($"Nombre mamífero: {mamifero.GetNombreSerVivo()}");
            Console.WriteLine($"Nombre mamífero humano: {mamiferoHumano.GetNombreSerVivo()}");
            Console.WriteLine();

            Console.Write("Acción mamífero: "); mamifero.Pensar();
            Console.Write("Acción mamífero humano: "); mamiferoHumano.Pensar();
        }
    }
}
