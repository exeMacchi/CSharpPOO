using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08___Clases__polimorfismo_1
{
    class Ejercicio08
    {
        static void Main()
        {
            const int MAX_ANIMALES = 3;
            Animal[] animales = new Animal[MAX_ANIMALES];

            animales[0] = new Animal();
            animales[1] = new Perro();
            animales[2] = new Gato();

            // Polimorfismo
            foreach(Animal animal in animales)
            {
                Console.WriteLine(animal.Comunicarse());
            }
        }
    }
}
