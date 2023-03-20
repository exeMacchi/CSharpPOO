using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10___Clase_abstracta
{
    class Ejercicio10
    {
        static void Main()
        {
            // No se puede instanciar la clase Animal porque es abstracta
            // Animal animal = new Animal();

            Leon alex = new Leon("Alex", "Leonitis", 4);

            // Método abstracto desarrollado en la clase Leon
            Console.WriteLine(alex.Ruido());

            Console.ReadKey();
        }
    }
}
