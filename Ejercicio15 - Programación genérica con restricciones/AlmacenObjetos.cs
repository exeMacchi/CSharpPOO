using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15___Programación_genérica_con_restricciones
{
    // Clase genérica que solo acepta tipos que implementen la interfaz IEmpleados
    class AlmacenObjetos<T> where T : IEmpleados 
    {
        public AlmacenObjetos(int cantElementos)
        {
            datosElemento = new T[cantElementos];
            i = 0;
        }

        private int i;
        private T[] datosElemento;

        public T GetObjeto(int i) { return datosElemento[i]; }

        public void AgregarObjeto(T obj)
        {
            datosElemento[i] = obj;
            i++;
        }
    }
}
