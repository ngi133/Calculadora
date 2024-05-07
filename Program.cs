// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Calculadora;


{
    Calculator calculator = new Calculator();

    // Ejemplos de uso
    double result = calculator.Add(2, 3); // 5.0
    Console.WriteLine($"Suma: 2 + 3 = {result}");

    result = calculator.Subtract(5, 2); // 3.0
    Console.WriteLine($"Resta: 5 - 2 = {result}");

    result = calculator.Multiply(4, 6); // 24.0
    Console.WriteLine($"Multiplicación: 4 * 6 = {result}");

    result = calculator.Divide(10, 2); // 5.0
    Console.WriteLine($"División: 10 / 2 = {result}");

    Console.ReadLine();
}
