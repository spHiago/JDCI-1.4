/*6. Create a method named “Factorial” that receives one numeric input (integer) and
returns the factorial value of the input;*/

using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero positivo e eu lhe darei seu fatorial:");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (FactorialCalculator(numero) != -1)
            {
                Console.WriteLine($"O fatorial de {numero} é {FactorialCalculator(numero)}");
            }
            else
            {
                Console.WriteLine("A calculadora nao foi programada para calcular numeros negativos.");
            }
        }
        static int FactorialCalculator(int numero)
        {
            int fatorial = 1;
            if (numero <= 0)
                return -1;
            else
            {
                for (int i = 1; i <= numero; i++)
                {
                    fatorial *= i;
                }
            }
            return fatorial;
        }
    }
}