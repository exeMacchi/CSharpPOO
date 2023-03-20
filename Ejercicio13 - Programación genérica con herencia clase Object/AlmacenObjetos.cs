using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13___Programación_genérica_con_herencia_clase_Object
{
    class AlmacenObjetos
    {
        public AlmacenObjetos(int cantElementos)
        {
            datosElemento = new Object[cantElementos];
            i = 0;
        }

        private int i;
        private Object[] datosElemento;

        public Object GetObjeto(int i) { return datosElemento[i]; }

        public void AgregarObjeto(Object objeto)
        {
            datosElemento[i] = objeto;
            i++;
        }
    }
}
