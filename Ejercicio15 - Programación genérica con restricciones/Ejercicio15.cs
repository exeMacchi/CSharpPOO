using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15___Programación_genérica_con_restricciones
{
    class Ejercicio15
    {
        static void Main()
        {
            const int MAX_EMPLEADOS = 4;

            AlmacenObjetos<Director> directores = new AlmacenObjetos<Director>(MAX_EMPLEADOS);
            AlmacenObjetos<Secretario> secretarios = new AlmacenObjetos<Secretario>(MAX_EMPLEADOS);
            AlmacenObjetos<Obrero> obreros = new AlmacenObjetos<Obrero>(MAX_EMPLEADOS);

            // No se puede instanciar el objeto estudiantes porque la clase Estudiante no
            // implementa la interfaz IEmpleado que sí implementan las clases derivadas de
            // la clase Empleado
             AlmacenObjetos<Estudiante> estudiantes = new AlmacenObjetos<Estudiante>(MAX_EMPLEADOS);
        }
    }
}
