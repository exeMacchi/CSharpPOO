using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07___Vector_de_objetos_2
{
    class Ejercicio07
    {
        static void Main()
        {
            const int MAX_EMPLEADOS = 5;
            Empleados[] vEmpleados = new Empleados[MAX_EMPLEADOS];

            Funciones.InstanciarVector(vEmpleados);
            Funciones.RellenarVector(vEmpleados);
            Funciones.MostrarVector(vEmpleados);

            Console.ReadKey();
        }
    }
}
