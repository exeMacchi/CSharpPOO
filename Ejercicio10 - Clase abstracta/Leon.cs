using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10___Clase_abstracta
{
    class Leon : Animal
    {
        public Leon(string nombreLeon, string nombreCientificoLeon, int edadLeon)
               : base(nombreLeon, nombreCientificoLeon, edadLeon) { }

        public override string Ruido()
        {
            return ($"Soy {Nombre} el león, ROOOWWW...");
        }
    }
}
