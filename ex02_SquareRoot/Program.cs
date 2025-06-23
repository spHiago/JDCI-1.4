/*2. Create a method named “SquareRoot” that receives one numeric input (double) and
returns the mathematical square root value of the same. The number must be a
decimal with two decimal places;*/

using System;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, digite um numero e eu lhe darei a raiz quadrada do mesmo:");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A raiz quadrada de {number} é {SquareRoot(number)}.");

        }
        static double SquareRoot(double number)
        {
            return Math.Sqrt(number);
        }
    }
}