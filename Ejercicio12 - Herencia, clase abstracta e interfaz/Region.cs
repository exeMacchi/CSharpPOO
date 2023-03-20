using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12___Herencia__clase_abstracta_e_interfaz
{
    abstract class Region
    {
        public Region(string nombreRegion) { this.nombreRegion = nombreRegion; }

        private string nombreRegion;
        public string NombreRegion { get { return nombreRegion; } }
    }
}
