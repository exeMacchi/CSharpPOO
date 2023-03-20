using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03___Clases__herencia
{
    class Humano : Mamiferos
    {
        public Humano(string nombreHumano) : base(nombreHumano) {}

        public override void Pensar()
        {
            Console.WriteLine("Soy capaz de razonar.");
        }
    }
}
