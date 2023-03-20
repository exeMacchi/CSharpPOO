using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03___Clases__herencia
{
    class Gorila : Mamiferos
    {
        public Gorila(string nombreGorila) : base(nombreGorila) {}

        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar.");
        }
    }
}
