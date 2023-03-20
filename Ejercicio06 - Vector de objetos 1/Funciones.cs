using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06___Vector_de_objetos_1
{
    class Funciones
    {
        public static void InstanciarPerros(Perro[] perros)
        {
            for (int i = 0; i < perros.Length; i++)
            {
                perros[i] = new Perro();
            }
        }

        public static void PedirDatosPerros(Perro[] perros)
        {
            for (int i = 0; i < perros.Length; i++)
            {
                Console.WriteLine($"=========== Perro nro. {i + 1} ===========");

                Console.Write("Ingrese el nombre del perro: ");
                perros[i].Nombre = Console.ReadLine();
                Console.Write("Ingrese la raza del perro: ");
                perros[i].Raza = Console.ReadLine();
                Console.Write("Ingrese el color del perro: ");
                perros[i].Color = Console.ReadLine();
                Console.Write("Ingrese el origen del perro: ");
                perros[i].Origen = Console.ReadLine();

                Console.WriteLine();
            }
        }

        public static void MostrarMenuPerros(Perro[] perros)
        {
            byte opcion;
            Console.Clear();

            Console.WriteLine($"1. {perros[0].Nombre}");
            Console.WriteLine($"2. {perros[1].Nombre}");
            Console.WriteLine($"3. {perros[2].Nombre}");
            Console.WriteLine($"4. {perros[3].Nombre}");

            do
            {
                Console.Write("Seleccione un perro para mostrar su informacion: ");
                opcion = Convert.ToByte(Console.ReadLine());

            } while (opcion > 4 || opcion < 0);

            MostrarInfoPerro(opcion, perros);
        }

        public static void MostrarInfoPerro(byte opcion, Perro[] perros)
        {
            opcion--;
            switch (opcion)
            {
                case 0:
                    InfoPerro(perros, opcion);
                    break;

                case 1:
                    InfoPerro(perros, opcion);
                    break;

                case 2:
                    InfoPerro(perros, opcion);
                    break;

                case 3:
                    InfoPerro(perros, opcion);
                    break;
            }
        }

        static void InfoPerro(Perro[] perros, byte i)
        {
            Console.WriteLine("============================");
            Console.WriteLine($"Nombre: {perros[i].Nombre}");
            Console.WriteLine($"Raza: {perros[i].Raza}");
            Console.WriteLine($"Color: {perros[i].Color}");
            Console.WriteLine($"Origen: {perros[i].Origen}");
            Console.WriteLine("============================");
            Console.ReadKey();
        }
    }
}
