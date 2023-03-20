using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11___Interfaz
{
    class Circulo : IGeometria
    {
        public Circulo (double radio) { this.radio = radio; }

        private double radio;

        public double Radio { get { return radio; } }

        public double CalcularArea() { return (Math.PI * Radio * Radio); }

        public double CalcularPerimetro() { return (2 * Math.PI * Radio); }
    }
}
