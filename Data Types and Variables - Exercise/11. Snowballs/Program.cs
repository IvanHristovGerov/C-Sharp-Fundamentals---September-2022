using System;
using System.Numerics;
namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //maxValue is used for comparison and finding the max value!
            BigInteger maxValue = BigInteger.MinusOne;
            // THese are just variables holding some properties of the maxed snowball
            int maxSnow = 0;
            int maxtime = 0;
            int maxQuality = 0;
            for (int i = 0; i < n; i++)
            {
                //1 iterations -> 1 snowball
                //for each snowball ->3 lines
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowbowTime = int.Parse(Console.ReadLine());
                int snowbowQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowbowTime), snowbowQuality);

                if (snowballValue > maxValue)
                {
                    maxValue = snowballValue;
                    maxSnow = snowballSnow;
                    maxtime = snowbowTime;
                    maxQuality = snowbowQuality;
                }
            }
            Console.WriteLine($"{maxSnow} : {maxtime} = {maxValue} ({maxQuality})");
        }
    }
}
