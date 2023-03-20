using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01___Clases__pruebas_iniciales_1
{
    class Persona
    {
        private string nombre;
        private byte edad;

        public string GetNombre() { return nombre; }
        public byte GetEdad() { return edad; }

        public void SetNombre(string name) { this.nombre = name; }
        public void SetEdad(byte age) { this.edad = age; }

        public string Saludar()
        {
            return $"Hola, soy {nombre}, y tengo {edad} años. Mucho gusto.";
        }
    }
}
