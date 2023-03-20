using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16___Práctica__préstamo_biblioteca
{
    class Pelicula : Material
    {
        public Pelicula(string codigo, string titulo, string director, string anioEstreno)
               : base(codigo, titulo)
        {
            this.director = director;
            this.anioEstreno = anioEstreno;
        }

        private string director;
        private string anioEstreno;

        public string Director
        {
            get { return director; }
            set { director = value; }
        }
        public string AnioEstreno
        {
            get { return anioEstreno; }
            set { anioEstreno = value; }
        }

        public override string ToString()
        {
            return ($"======== Película ========\n" +
                    $"{base.ToString()}\n" +
                    $"Director: {Director}\n" +
                    $"Año de estreno: {AnioEstreno}");
        }
    }
}
