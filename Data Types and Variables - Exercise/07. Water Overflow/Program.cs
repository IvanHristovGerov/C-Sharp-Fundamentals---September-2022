using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int litres = int.Parse(Console.ReadLine());

                if (sum + litres > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    
                }
                else
                {
                    sum += litres;
                }
                

            }
            Console.WriteLine(sum);




        }
    }
}
