using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12___Herencia__clase_abstracta_e_interfaz
{
    class RegionLatina : Region, IFecha
    {
        public RegionLatina(string nombreRegion) : base(nombreRegion) { }

        public string Formatear(byte dia, byte mes, int anio)
        {
            return ($"{dia}/{mes}/{anio}");
        }
    }
}
