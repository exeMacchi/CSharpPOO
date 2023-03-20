using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09___Clases__polimorfismo_2
{
    class Coche : Vehiculo
    {
        public override void PrenderMotor()
        {
            Console.WriteLine("Prendiendo motor del auto...");
        }
        public override void Conducir()
        {
            Console.WriteLine("Pisteando como un campeón...");
        }
        public override void ApagarMotor()
        {
            Console.WriteLine("Apagando el motor del auto...");
        }
    }
}
