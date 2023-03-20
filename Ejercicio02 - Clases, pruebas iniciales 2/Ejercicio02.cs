using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02___Clases__pruebas_iniciales_2
{
    class Ejercicio02
    {
        static void Main()
        {
            Telefono miTelefono = new Telefono("Motorola", "G9 Play");
            Telefono suTelefono = new Telefono("iPhone", "14 Pro Max");

            miTelefono.NumeroTelefonico = "123-456789";
            suTelefono.NumeroTelefonico = "321-531351";

            miTelefono.CodigoOperador = 3;
            suTelefono.CodigoOperador = 4;

            MostrarDatosTelefono(miTelefono, 1);
            MostrarDatosTelefono(suTelefono, 2);

            Console.WriteLine(miTelefono.Llamar());
            Console.WriteLine(suTelefono.Llamar("Ricardo"));
            Console.WriteLine();
        }
        static void MostrarDatosTelefono(Telefono telefono, byte opcion)
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("=============== Datos miTeléfono ===============");
                    Console.WriteLine($"Marca: {telefono.Marca}");
                    Console.WriteLine($"Modelo: {telefono.Modelo}");
                    Console.WriteLine($"Número telefónico: {telefono.NumeroTelefonico}");
                    Console.WriteLine($"Código operador: {telefono.CodigoOperador}");
                    Console.WriteLine($"================================================\n");
                    break;

                case 2:
                    Console.WriteLine("=============== Datos suTeléfono ===============");
                    Console.WriteLine($"Marca: {telefono.Marca}");
                    Console.WriteLine($"Modelo: {telefono.Modelo}");
                    Console.WriteLine($"Número telefónico: {telefono.NumeroTelefonico}");
                    Console.WriteLine($"Código operador: {telefono.CodigoOperador}");
                    Console.WriteLine($"================================================\n");
                    break;
            }
        }
    }
}
