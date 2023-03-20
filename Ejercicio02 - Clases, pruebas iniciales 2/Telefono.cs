using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02___Clases__pruebas_iniciales_2
{
    class Telefono
    {
        // Constructores
        public Telefono(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        // Atributos
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private byte codigoOperador;

        // Propiedades: funcionalidad de C# parecida a los getters y setters
        public string Modelo { get { return modelo; } }

        public string Marca  { get { return marca;  } }

        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }

        public byte CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (value >= 0 && value <= 3)
                {
                    codigoOperador = value;
                }
                else
                {
                    codigoOperador = 0;
                }
            }
        }

        // Métodos
        public string Llamar() { return "Realizando llamada..."; }
        public string Llamar(string contacto) { return "Llamando a " + contacto; }
    }
}
