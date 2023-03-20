using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09___Clases__polimorfismo_2
{
    class Avion : Vehiculo
    {
        public override void PrenderMotor()
        {
            Console.WriteLine("Prendiendo turbinas...");
        }
        public override void Conducir()
        {
            Console.WriteLine("Pilotando avión...");
        }

        public override void ApagarMotor()
        {
            Console.WriteLine("Apagando turbinas..."); 
        }
    }
}
