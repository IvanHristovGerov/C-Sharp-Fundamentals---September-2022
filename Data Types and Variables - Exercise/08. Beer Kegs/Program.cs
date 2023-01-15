using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double biggestVolume = 0;
            string biggestKeg = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string model = (Console.ReadLine());
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = (double)(Math.PI * height * (radius * radius));

                if (volume > biggestVolume)
                {
                    biggestKeg = model;
                    biggestVolume = volume;
                }

            }
            Console.WriteLine(biggestKeg);
        }
    }
}
