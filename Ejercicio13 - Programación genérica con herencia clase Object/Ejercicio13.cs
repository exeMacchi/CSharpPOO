using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13___Programación_genérica_con_herencia_clase_Object
{
    class Ejercicio13
    {
        static void Main()
        {
            const int CANT_ELEMENTOS = 4;
            AlmacenObjetos nombrePersonas = new AlmacenObjetos(CANT_ELEMENTOS);

            nombrePersonas.AgregarObjeto("Exequiel");
            nombrePersonas.AgregarObjeto("Ailén");
            nombrePersonas.AgregarObjeto("Darío");
            nombrePersonas.AgregarObjeto("Eliana");

            for (int i = 0; i < CANT_ELEMENTOS; i++)
            {
                // La programación genérica con clase Object obliga el uso del casting
                string nombre = (string) nombrePersonas.GetObjeto(i);
                Console.WriteLine(nombre);
            }
            Console.WriteLine();

            AlmacenObjetos empleados = new AlmacenObjetos(CANT_ELEMENTOS);

            empleados.AgregarObjeto(new Empleado(1000));
            empleados.AgregarObjeto(new Empleado(2000));
            empleados.AgregarObjeto(new Empleado(3000));
            empleados.AgregarObjeto(new Empleado(4000));

            for (int i = 0; i < CANT_ELEMENTOS; i++)
            {
                Empleado empleado = (Empleado) empleados.GetObjeto(i);
                Console.WriteLine(empleado.Salario);
            }
            Console.WriteLine();
        }
    }
}
