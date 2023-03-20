using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05___Clases__métodos_estáticos
{
    class Ejercicio05
    {
        static void Main()
        {
            double Num1, Num2, resultadoSuma = 0, resultadoDivision = 0, numReferencia;

            Num1 = Funciones.pedirNumero();
            Num2 = Funciones.pedirNumero();

            resultadoSuma = Funciones.SumaDosNumeros(Num1, Num2);
            resultadoDivision = Funciones.DividirDosNumeros(Num1, Num2);

            Funciones.PasoPorReferencia(resultadoSuma, out numReferencia);

            Console.WriteLine();
            Console.WriteLine($"Resultado suma: {resultadoSuma}");
            Console.WriteLine($"Resultado suma por referencia: {numReferencia}");
            Console.WriteLine($"Resultado división: {resultadoDivision}\n");
        }
    }
}
