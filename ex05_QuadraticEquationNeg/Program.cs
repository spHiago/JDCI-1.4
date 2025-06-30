/*4. Create a method named “QuadraticEquationPNeg” that receives three inputs and
returns the negative value option of the quadratic equation;*/

using System;

namespace QuadraticEquationPNeg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me three numbers, and i`ll return you the positive quadratic equation of them, ik sounds complicated.");
            Console.WriteLine("The value of (a):");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The value of (b):");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The value of (c):");
            double c = Convert.ToDouble(Console.ReadLine());
            QuadraticEquationNeg(a, b, c);
            Console.WriteLine($"O valor da sua raiz negativa é {QuadraticEquationNeg(a, b, c)}.");
        }
        static double QuadraticEquationNeg(double a, double b, double c)
        {
            double delta = (b * b) - 4 * a * c;

            double x2 = (-(b) - Math.Sqrt(delta)) / 2 * a;
            return x2;
        }
    }
}