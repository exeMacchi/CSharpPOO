using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16___Práctica__préstamo_biblioteca
{
    class Usuario
    {
        public Usuario(string dni, string nombreCompleto, string direccion, 
                       string numeroTelefonico, bool sanciones)
        {
            this.dni = dni;
            this.nombreCompleto = nombreCompleto;
            this.direccion = direccion;
            this.numeroTelefonico = numeroTelefonico;
            this.sanciones = sanciones;
            materialesPrestados = new Prestamo[MAX_PRESTAMOS];
            contadorMaterialesPrestados = 0;
        }

        private string dni;
        private string nombreCompleto;
        private string direccion;
        private string numeroTelefonico;
        private bool sanciones;
        private Prestamo[] materialesPrestados;
        private int contadorMaterialesPrestados;
        private const int MAX_PRESTAMOS = 5;

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }
        public bool Sanciones
        {
            get { return sanciones; }
            set { sanciones = value; }
        }
        public int ContadorMaterialesPrestados { get { return contadorMaterialesPrestados; } }

        public int MaxPrestamos { get { return MAX_PRESTAMOS; } }

        public override string ToString()
        {
            string resultado = ($"Nombre completo: {NombreCompleto}\n" +
                                $"D.N.I: {Dni}\n" +
                                $"Dirección: {Direccion}\n" +
                                $"Número telefónico: {NumeroTelefonico}\n");

            resultado += (Sanciones ? "Tiene sanciones pendientes\n"
                                    : "No tiene sanciones pendientes\n");

            if (contadorMaterialesPrestados == 0)
            {
                resultado += "No tiene préstamos en vigor";
            }
            else
            {
                resultado += ($"Tiene {contadorMaterialesPrestados} materiales en préstamo:\n");

                for (int i = 0; i < contadorMaterialesPrestados; i++)
                {
                    resultado += materialesPrestados[i].MaterialPrestamo + "\n";
                }
            }
            return resultado;
        }
        public bool NuevoPrestamo(Prestamo p)
        {
            bool resultado = false;

            if (contadorMaterialesPrestados < MAX_PRESTAMOS && !Sanciones) 
            {
                materialesPrestados[contadorMaterialesPrestados] = p;
                contadorMaterialesPrestados++;

                p.UsuarioPrestamo = this;

                resultado = true;
            }

            return resultado;
        }

        public bool QuitarPrestamo(Material m)
        {
            bool encontrado = false;
            int i = 0;

            while (i < contadorMaterialesPrestados && !encontrado)
            {
                if (materialesPrestados[i].MaterialPrestamo.Codigo == m.Codigo)
                {
                    encontrado = true;
                }
                else
                {
                    i++;
                }
            }

            if (encontrado)
            {
                for (int j = i; j < contadorMaterialesPrestados; j++)
                {
                    materialesPrestados[j] = materialesPrestados[j + 1];
                }
                contadorMaterialesPrestados--;
            }

            return encontrado;
        }
    }
}
