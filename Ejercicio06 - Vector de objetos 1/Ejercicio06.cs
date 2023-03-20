using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06___Vector_de_objetos_1
{
    class Ejercicio06
    {
        static void Main()
        {
            const int MAX_PERROS = 4;
            Perro[] perros = new Perro[MAX_PERROS];
            
            // Se instancian los espacios en memoria
            Funciones.InstanciarPerros(perros);

            // Se rellena la información
            Funciones.PedirDatosPerros(perros);

            // Un pequeño menú para seleccionar la información de una instancia
            Funciones.MostrarMenuPerros(perros);
        }
    }
}
