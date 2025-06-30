/*3. Create a method named “NumberModule” that receives one numeric input (double)
and returns the module value of the same;*/

using System;

namespace NumberModule
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, tell me a number and i´ll return you if your number is even or odd:");
            double number = Convert.ToDouble(Console.ReadLine());
            NumberModule(number);

        }
        static double NumberModule(double number)
        {
            if (number % 2 == 0)
                Console.WriteLine("Your number is even");
            else
                Console.WriteLine("Your number is odd");
            return number;
        }
    }
}