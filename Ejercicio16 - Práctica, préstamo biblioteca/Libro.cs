using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16___Práctica__préstamo_biblioteca
{
    class Libro : Material
    {
        public Libro(string codigo, string titulo, string autor, string anioPublicacion,
                     int numeroDePaginas)
               : base(codigo, titulo)
        {
            this.autor = autor;
            this.anioPublicacion = anioPublicacion;
            this.numeroDePaginas = numeroDePaginas;
        }

        private string autor;
        private string anioPublicacion;
        private int numeroDePaginas;

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public string AnioPublicacion
        {
            get { return anioPublicacion; }
            set { anioPublicacion = value; }
        }
        public int NumeroDePaginas
        {
            get { return numeroDePaginas; }
            set 
            {
                if (value > 0) { numeroDePaginas = value; }
                else { numeroDePaginas = 0; }
            }
        }

        public override string ToString()
        {
            return ($"======== Libro ========\n" +
                    $"{base.ToString()}\n" +
                    $"Autor: {autor}\n" +
                    $"Año de publicación: {AnioPublicacion}\n" +
                    $"Número de páginas: {NumeroDePaginas}");
        }
    }
}
