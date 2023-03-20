using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10___Clase_abstracta
{
    // Clase que no permite que se instancie directamente
    abstract class Animal
    {
        public Animal(string nombre, string nombreCientifico, int edad)
        {
            this.nombre = nombre;
            this.nombreCientifico = nombreCientifico;
            this.edad = edad;
        }

        private string nombre;
        private string nombreCientifico;
        private int edad;

        public string Nombre { get { return nombre; } }
        public string NombreCientifico { get { return nombreCientifico; } }
        public int Edad { get { return edad; } }

        // Método que se obliga a desarrollar en la clase derivada
        public abstract string Ruido();
    }
}
