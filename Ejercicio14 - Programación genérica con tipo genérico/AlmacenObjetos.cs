using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14___Programación_genérica_con_tipo_genérico
{
    class AlmacenObjetos<T> // Declaración de una clase genérica
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
