using System;
using System.Linq;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] arr = new int[3];
            for (int i = 0; i < 3; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());      
            }

            int min = SmallestNum(arr);
            Console.WriteLine(min);
        }

        static int SmallestNum(int[]arr)
        {
            int min = arr.Min();
            return min;

        }
    }
}
