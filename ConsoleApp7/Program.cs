using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlmacenEmpleados<Director> empleados = new AlmacenEmpleados<Director>(3);
            empleados.agregar(new Director(4500));
        
        }

        class AlmacenEmpleados<T> where T: IParaEmpleados
        {

            public AlmacenEmpleados(int z)
            {
                datosEmpleado = new T[z];
            }
            
            public void agregar( T obj)
            {

                datosEmpleado[i] = obj;

                i++;

            }

            public T getEmpleado(int i)
            {
                return datosEmpleado[i];
            }

            private int i = 0;

            private T[] datosEmpleado;

        }

        class Secretaria : IParaEmpleados
        {
            public Secretaria(double salario)
            {
                this.salario = salario;

            }

            private double salario;

            public double getSalario()
            {

                return this.salario;
            }
        }

        class Electricista
        {
            public Electricista(double salario)
            {
                this.salario = salario;

            }

            private double salario;

            public double getSalario()
            {

                return this.salario;
            }

        }

        class Director : IParaEmpleados
        {

            public Director(double salario)
            {
                this.salario = salario;

            }

            private double salario;

            public double getSalario()
            {

                return this.salario;

            }
        }

        interface IParaEmpleados
        {
            double getSalario();
        }
    }
}
