using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Modular division %10 -> returns last digit %
            //Integer division %10 -> removes last digit /

            int n = int.Parse(Console.ReadLine());
            
            int factorialSum = 0;
            int numCopy = n;
            while (numCopy > 0)
            {
                int lastDigit = numCopy % 10; //Take last digit
                numCopy /= 10; // removes last digit

                int factorial = 1;
                for (int i = 2; i <= lastDigit; i++)
                {
                    factorial *= i;
                }
                factorialSum += factorial;

            }

            if (factorialSum == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
