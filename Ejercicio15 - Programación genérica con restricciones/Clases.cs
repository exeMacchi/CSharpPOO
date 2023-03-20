namespace Ejercicio15___Programación_genérica_con_restricciones
{
    abstract class Empleado : IEmpleados
    {
        public Empleado(double salario)
        {
            this.salario = salario;
        }
        private double salario;

        public double Salario { get { return salario; } }

        public abstract double GetSalario();
    }

    class Director : Empleado
    {
        public Director(double salario) : base(salario) {}

        public override double GetSalario() { return Salario; }
    }

    class Secretario : Empleado 
    {
        public Secretario(double salario) : base(salario) { }

        public override double GetSalario() { return Salario; }
    }

    class Obrero : Empleado
    {
        public Obrero(double salario) : base(salario) {}

        public override double GetSalario() { return Salario; }
    }

    class Estudiante
    {
        public Estudiante(int edad)
        {
            this.edad = edad;
        }

        private int edad;

        public int Edad { get { return edad;} }
    }
}