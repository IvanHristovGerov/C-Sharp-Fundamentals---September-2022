using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = (Console.ReadLine().Split().Select(int.Parse).ToArray());
            int[] arr2 = (Console.ReadLine().Split().Select(int.Parse).ToArray());

            for (int i = 0; i < arr1.Length; i++)
            {

                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index.");
                    break;
                }
                foreach (int item in arr1)
                {
                    int sum = arr1.Sum();
                    Console.WriteLine($"Arrays are identical. Sum: {sum}");
                }


               // else
               // {
               //     int sum = arr1.Sum();
               //     Console.WriteLine($"Arrays are identical. Sum: {sum}");
               //     return;
               //
               // }
            }
        }
    }
}
