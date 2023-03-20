using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04___Clases__pruebas_iniciales_3
{
    class Persona
    {
        public Persona(string nombre, short anioNacimiento)
        {
            this.nombre = nombre;
            this.anioNacimiento = anioNacimiento;
        }

        protected string nombre;
        private short anioNacimiento;

        public void SetNombre(string nombre) { this.nombre = nombre; }
        public string GetNombre() { return nombre; }

        public void SetAnioNacimiento(short anio) { anioNacimiento = anio; }
        public short GetAnioNacimiento() { return anioNacimiento; }

        public virtual void Saludar()
        {
            Console.WriteLine($"Hola, mi nombre es {nombre}, mucho gusto.");
        }
    }
}
