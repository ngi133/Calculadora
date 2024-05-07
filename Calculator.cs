using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculator
    {
        // Método para sumar dos números
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Método para restar dos números
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        // Método para multiplicar dos números
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // Método para dividir dos números
        public double Divide(double a, double b)
        {
            // Verificar si el divisor es cero
            if (b == 0)
            {
                throw new DivideByZeroException("No se puede dividir entre cero.");
            }

            return a / b;
        }
    }

    // Programa principal
}
