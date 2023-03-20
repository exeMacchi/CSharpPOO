using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13___Programación_genérica_con_herencia_clase_Object
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
