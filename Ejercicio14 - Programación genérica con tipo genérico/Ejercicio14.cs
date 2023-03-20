using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14___Programación_genérica_con_tipo_genérico
{
    class Ejercicio14
    {
        static void Main()
        {
            const int MAX_ELEMENTOS = 4;
            // Se indica el tipo que la clase genérica va a almacenar. Esto ayuda a
            // encontrar errores en tiempo de compilación.
            AlmacenObjetos<string> nombres = new AlmacenObjetos<string> (MAX_ELEMENTOS);

            nombres.AgregarObjeto("Exequiel");
            nombres.AgregarObjeto("Ailen");
            nombres.AgregarObjeto("Dario");
            nombres.AgregarObjeto("Eliana");

            for (int i = 0; i < MAX_ELEMENTOS; i++)
            {
                // No hace falta el casting
                string nombre = nombres.GetObjeto(i);
                Console.WriteLine(nombre);
            }
            Console.WriteLine();

            AlmacenObjetos<Empleado> empleados = new AlmacenObjetos<Empleado>(MAX_ELEMENTOS);

            empleados.AgregarObjeto(new Empleado(1000));
            empleados.AgregarObjeto(new Empleado(2000));
            empleados.AgregarObjeto(new Empleado(3000));
            empleados.AgregarObjeto(new Empleado(4000));

            for (int i = 0; i < MAX_ELEMENTOS; i++)
            {
                Empleado empleado = empleados.GetObjeto(i);
                Console.WriteLine(empleado.Salario);
            }
            Console.WriteLine();
        }
    }
}
