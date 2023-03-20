using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09___Clases__polimorfismo_2
{
    class Ejercicio09
    {
        static void Main()
        {
            const int MAX_VEHICULOS = 3;
            Vehiculo[] vehiculos = new Vehiculo[MAX_VEHICULOS];

            vehiculos[0] = new Vehiculo();
            vehiculos[1] = new Avion();
            vehiculos[2] = new Coche();

            foreach (Vehiculo vehiculo in vehiculos)
            {
                vehiculo.PrenderMotor();
                vehiculo.Conducir();
                vehiculo.ApagarMotor();
                Console.WriteLine();
            }
        }
    }
}
