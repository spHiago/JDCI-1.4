/*4. Create a method named “QuadraticEquationPos” that receives three inputs and
returns the positive value option of the quadratic equation;*/

using System;

namespace QuadraticEquationPos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me three numbers, and i`ll return you the quadratic equation of them, ik sounds complicated.");
            Console.WriteLine("The value of (a):");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The value of (b):");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The value of (c):");
            double c = Convert.ToDouble(Console.ReadLine());
            QuadraticEquationPos(a, b, c);
        }
        static double QuadraticEquationPos(double a, double b, double c)
        {
            double delta = (b * b) - 4 * a * c;
            if (delta > 0)
            {
                double x1 = (-(b) + Math.Sqrt(delta)) / 2 * a;
                double x2 = (-(b) - Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine($"Duas raízes : x1 = {x1}, x2 = {x2}");
            }
            else if (delta == 0)
            {
                double x = -(b) / (2 * a);
                Console.WriteLine($"Uma raiz: x = {x}");
            }
            else
            {
                Console.WriteLine("Nao ha raizes reais.");
            }
            return delta;
        }
    }
}