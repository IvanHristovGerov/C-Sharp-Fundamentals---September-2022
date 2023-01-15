using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = (Console.ReadLine().Split().Select(int.Parse).ToArray());

            while (arr.Length > 1)
            {
                int[] newArr = new int[arr.Length - 1];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    newArr[i] = arr[i] + arr[i + 1];
                }
                arr = newArr;
            }
            Console.WriteLine(arr[0]);
        }
    }
}
