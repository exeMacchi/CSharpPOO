using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07___Vector_de_objetos_2
{
    class Funciones
    {
        public static void InstanciarVector(Empleados[] vEmpleados)
        {
            for (int i = 0; i < vEmpleados.Length; i++)
            {
                vEmpleados[i] = new Empleados();
            }
        }

        public static void RellenarVector(Empleados[] vEmpleados)
        {
            Console.WriteLine("----------------- Cargando información -----------------");
            for (int i = 0; i < vEmpleados.Length; i++)
            {
                Console.WriteLine($"Empleado número {i + 1}");
                Console.Write($"   Nombre: ");
                vEmpleados[i].SetNombre(Console.ReadLine());

                Console.Write($"   Edad: ");
                vEmpleados[i].SetEdad(Convert.ToByte(Console.ReadLine()));
            }
            Console.Clear();
        }

        public static void MostrarVector(Empleados[] vEmpleados)
        {
            Console.WriteLine("----------------- Información empleados -----------------");
            for (int i = 0; i < vEmpleados.Length; i++)
            {
                Console.WriteLine($"Empleado {i + 1}");
                Console.WriteLine($"Nombre: {vEmpleados[i].GetNombre()}");
                Console.WriteLine($"Edad: {vEmpleados[i].GetEdad()}");

                Console.WriteLine();
            }

            /* 
                Utilizando el bucle for each
                foreach (Empleados empleado in vEmpleados)
                {
                    Console.WriteLine(empleado.GetNombre());
                    Console.WriteLine(empleado.GetEdad());
                    Console.WriteLine();
                }
            */
        }
    }
}
