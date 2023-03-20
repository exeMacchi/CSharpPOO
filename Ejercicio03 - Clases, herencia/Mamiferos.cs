using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03___Clases__herencia
{
    class Mamiferos : Object // Superclase cósmica (heredada por defecto) 
    {
        public Mamiferos(string nombre) // Constructor personalizado
        {
            nombreSerVivo = nombre;
        }

        private string nombreSerVivo;

        public void SetNombreSerVivo(string nombre) { nombreSerVivo = nombre; }
        public string GetNombreSerVivo() { return nombreSerVivo; }

        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar.");
        }
        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias.");
        }
        public virtual void Pensar()
        {
            Console.WriteLine("Pensamiento institivo.");
        }
    }
}
