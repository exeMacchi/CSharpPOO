using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07___Vector_de_objetos_2
{
    class Empleados
    {
        private string nombre;
        private byte edad;

        public void SetNombre(string nombre) { this.nombre = nombre; }
        public string GetNombre() { return this.nombre; }

        public void SetEdad(byte edad) { this.edad = edad; }
        public byte GetEdad() { return this.edad; }
    }
}
