using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09___Clases__polimorfismo_2
{
    class Vehiculo
    {
        public virtual void PrenderMotor()
        {
            Console.WriteLine("Prendiendo motores del vehículo...");
        }

        public virtual void ApagarMotor()
        {
            Console.WriteLine("Apagando motores del vehículo...");
        }

        public virtual void Conducir()
        {
            Console.WriteLine("Conduciendo vehiculo...");
        }
    }
}
