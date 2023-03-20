using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06___Vector_de_objetos_1
{
    class Perro
    {
        // Atributos
        private string nombre;
        private string color;
        private string origen;
        private string raza;

        // Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Origen
        {
            get { return origen; }
            set { origen = value; }
        }

        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }
    }
}
