using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04___Clases__pruebas_iniciales_3
{
    class PersonaInglesa : Persona
    {
        public PersonaInglesa(string nombre, short anioNacimiento) 
               : base(nombre, anioNacimiento) {}

        public override void Saludar()
        {
            // Se puede acceder al atributo nombre porque en la clase "Persona" este tiene
            // un modificador de acceso protected
            Console.WriteLine($"Hi, I'm {nombre}, nice to meet you.");
        }

        // Destructor: es llamado por el sistema al finalizar el programa o para
        // liberar memoria.
        ~PersonaInglesa() 
        {
            Console.WriteLine("Destructor de \"PersonaInglesa\" en acción.");
        }
    }
}
