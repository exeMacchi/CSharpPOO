using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16___Práctica__préstamo_biblioteca
{
    class Ejercicio16
    {
        static void Main()
        {
            Usuario usuario1 = new Usuario("33.016.244", "Lionel Andrés Messi Cuccitini",
                                            "37 Avenue Hoche", "123-456789", false);


            Material[] materiales = new Material[5];
            materiales[0] = new Libro("1AA", "El faro", "1909", "Edgar Allan Poe", 200);
            materiales[1] = new Pelicula("2BB", "Sleepy Hollow", "Tim Burton", "1999");
            materiales[2] = new Libro("3CC", "El camino de los reyes", "Brandon Sanderson",
                                      "2010", 1300);
            materiales[3] = new Pelicula("4DD", "Fight Club", "David Fincher", "1999");
            materiales[4] = new Material("5EE", "Hollow Knight");

            // Mostrar información del usuario antes de realizar las operaciones
            Console.WriteLine($"Información del usuario {usuario1.NombreCompleto}: ");
            Console.WriteLine(usuario1);
            Console.WriteLine();

            // Agregar nuevo préstamo
            Prestamo p1 = new Prestamo(usuario1, "20/03/2023", "27/03/2023", materiales[0]);
            if (usuario1.NuevoPrestamo(p1))
            {
                Console.WriteLine($"Información del préstamo {p1.UsuarioPrestamo.NombreCompleto}: ");
                Console.WriteLine(usuario1);
            }
            else if (usuario1.Sanciones)
            {
                Console.WriteLine("No se pudo realizar el préstamo porque el usuario tiene " +
                    "sanciones pendientes.");
            }
            else if (usuario1.ContadorMaterialesPrestados > usuario1.MaxPrestamos)
            {
                Console.WriteLine("No se pudo realizar el préstamo porque el usuario llegó " +
                                  "al límite de préstamos permitidos.");
            }
            else
            {
                Console.WriteLine("No se pudo realizar el préstamo.");
            }


            Prestamo p2 = new Prestamo(usuario1, "20/03/2023", "27/03/2023", materiales[3]);
            if (usuario1.NuevoPrestamo(p2))
            {
                Console.WriteLine($"Información del préstamo {p2.UsuarioPrestamo.NombreCompleto}: ");
                Console.WriteLine(usuario1);
            }
            else if (usuario1.Sanciones)
            {
                Console.WriteLine("No se pudo realizar el préstamo porque el usuario tiene " +
                    "sanciones pendientes.");
            }
            else if (usuario1.ContadorMaterialesPrestados > usuario1.MaxPrestamos)
            {
                Console.WriteLine("No se pudo realizar el préstamo porque el usuario llegó " +
                                  "al límite de préstamos permitidos.");
            }
            else
            {
                Console.WriteLine("No se pudo realizar el préstamo.");
            }

            // Quitar un préstamo
            if (usuario1.QuitarPrestamo(materiales[0]))
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("El préstamo ha sido eliminado.");
                Console.WriteLine();
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("No se ha localizado el material solicitado " +
                                  "en la base de datos.");
                Console.WriteLine();
                Console.ResetColor();
            }

            // Se muestra la información del usuario luego de finalizar las operaciones
            Console.WriteLine($"Información del usuario {usuario1.NombreCompleto}: ");
            Console.WriteLine(usuario1);
            Console.WriteLine();
        }
    }
}
