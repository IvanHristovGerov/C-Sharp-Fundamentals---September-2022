using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int biscuits = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int otherFactory = int.Parse(Console.ReadLine());

            double biscuitsSum = 0;

            for (int i = 1; i <= 30; i++)
            {
                double biscuitsPerDay = (biscuits * workers);
                if (i % 3 == 0)
                {
                    biscuitsPerDay = biscuitsPerDay * 0.75;

                }

                biscuitsSum += biscuitsPerDay;
            }
            Console.WriteLine($"You have produced {biscuitsSum} biscuits for the past month.");

            double difference = Math.Abs(otherFactory - biscuitsSum);
            double percentage = ((difference / otherFactory) * 100);

            if (biscuitsSum>otherFactory)
            {
                Console.WriteLine($"You produce {percentage:f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {percentage:f2} percent less biscuits.");
            }

        }
    }
}
