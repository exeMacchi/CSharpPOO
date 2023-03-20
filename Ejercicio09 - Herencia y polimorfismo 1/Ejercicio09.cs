using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09___Herencia_y_polimorfismo_1
{
    class Ejercicio09
    {
        static void Main()
        {
            Vehiculo[] vehiculos = new Vehiculo[3];

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
