using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12___Herencia__clase_abstracta_e_interfaz
{
    class Ejercicio12
    {
        static void Main()
        {
            RegionLatina regLatina = new RegionLatina("Buenos Aires");
            RegionInglesa regInglesa = new RegionInglesa("Norwich");

            Console.WriteLine($"Formato de fecha en {regLatina.NombreRegion}: " +
                              $"{regLatina.Formatear(19, 03, 2023)}");

            Console.WriteLine($"Formato de fecha en {regInglesa.NombreRegion}: " +
                              $"{regInglesa.Formatear(19, 03, 2023)}");

            Console.ReadKey();
        }
    }
}
