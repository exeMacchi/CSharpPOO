using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03___Clases__herencia
{
    class Caballo : Mamiferos 
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo)                                                                                                               
        {                                                                                                                
           // Al haber un constructor personalizado en la clase padre Mamiferos, es
           // necesario que el constructor de la clase hija Caballo llame al de la clase
           // padre para que los miembros que se heredan de la clase padre sean
           // inicializados en la clase derivada.
        }
        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar.");
        }
    }
}
