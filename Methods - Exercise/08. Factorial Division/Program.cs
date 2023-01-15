using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            double firstFac = Factorial(number1);
            double secondFac = Factorial(number2);

            double output = firstFac / secondFac;
            Console.WriteLine($"{output:f2}");

        }

        static int Factorial(int n)
        {
            int fac = 1;

            for (int i = 1; i <= n; i++)
            {
                fac *= i;
            }
            return fac;
        }
    }
}
