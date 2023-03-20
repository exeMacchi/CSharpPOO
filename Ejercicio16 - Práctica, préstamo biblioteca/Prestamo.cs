using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16___Práctica__préstamo_biblioteca
{
    class Prestamo
    {
        public Prestamo(Usuario usuarioPrestamo, string fechaPrestamo,
                        string fechaDevolucion, Material materialPrestamo) 
        {
            this.usuarioPrestamo = usuarioPrestamo;
            this.fechaPrestamo = fechaPrestamo;
            this.fechaDevolucion = fechaDevolucion;
            this.materialPrestamo = materialPrestamo;
        }

        private Usuario usuarioPrestamo;
        private string fechaPrestamo;
        private string fechaDevolucion;
        private Material materialPrestamo;

        public string FechaPrestamo  {  get { return fechaPrestamo; }  }
        public string FechaDevolucion
        {
            get { return fechaDevolucion; }
            set { fechaDevolucion = value; }
        }
        public Material MaterialPrestamo { get { return materialPrestamo; } }
        public Usuario UsuarioPrestamo
        {
            get { return usuarioPrestamo; }
            set { usuarioPrestamo = value; }
        }

        public override string ToString()
        {
            return ($"Usuario: {UsuarioPrestamo.NombreCompleto}\n" +
                    $"Fecha inicio de préstamo: {FechaPrestamo}\n" +
                    $"Fecha de devolución: {FechaDevolucion}\n");
        }
    }
}
