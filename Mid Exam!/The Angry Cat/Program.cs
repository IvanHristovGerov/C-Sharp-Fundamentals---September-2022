using System;
using System.Linq;

namespace The_Angry_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine()
                .Split(',')
                .Select(int.Parse)
                .ToArray();


            int entryPoint = int.Parse(Console.ReadLine());
            bool item = Console.ReadLine() == "cheap";

            int entryValue = prices [entryPoint];

            int rightSum = 0;
            int leftSum = 0;


            for (int i = 0; i < entryPoint; i++)
            {
                if (item)
                {
                    if (prices[i] < entryValue) leftSum += prices[i];

                }
                else if (prices[i] >= entryValue) leftSum += prices[i];
            }

            for (int i = entryPoint + 1; i < prices.Length; i++)
            {
                if (item)
                {
                    if (prices[i] < entryValue) rightSum += prices[i];
                }
                else if (prices[i] >= entryValue) rightSum += prices[i];


            }
            


            if (leftSum <= rightSum)
            {
                Console.WriteLine($"Right - {rightSum}");
            }

            else
            {
                Console.WriteLine($"Left - {leftSum}");
            }
              

        }
    }
}
