using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16___Práctica__préstamo_biblioteca
{
    class Material
    {
        public Material(string codigo, string titulo)
        {
            this.codigo = codigo;
            this.titulo = titulo;
        }

        private string codigo;
        private string titulo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public override string ToString()
        {
            return ($"Título: {Titulo}\n" +
                    $"Código: {Codigo}");
        }
    }
}
