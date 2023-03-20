using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05___Clases__métodos_estáticos
{
    class Funciones
    {
        // No es necesario crear una instancia para utilizar estos métodos.

        public static double pedirNumero()
        {
            Console.Write("Ingrese un número real: ");
            return double.Parse(Console.ReadLine());
        }

        public static double SumaDosNumeros(double N1, double N2) { return N1 + N2; }

        public static void PasoPorReferencia(double resultadoSuma, 
                                             out double numReferencia)
        {
            numReferencia = resultadoSuma;
        }

        public static double DividirDosNumeros(double N1, double N2)
        {
            return Math.Round((N1 / N2), 2);
        }
    }
}
