using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14___Programación_genérica_con_tipo_genérico
{
    class Empleado
    {
        public Empleado(double salario)
        {
            this.salario = salario;
        }

        private double salario;

        public double Salario { get { return salario; } }
    }
}
