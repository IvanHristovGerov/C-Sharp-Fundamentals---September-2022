using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = (Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i]; //така взимаме числото на СЕГАШНИЯ индекс.

                bool isTopInteger = true; //Pass through all numbers to its right.

                for (int j = i+1; j < numbers.Length; j++)
                {
                    int nextNum = numbers[j];
                    if (nextNum>=currNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    Console.Write(currNum + " ");
                }


                //Pass through all numbers to its left
               //for (int k = 0; k < i; k++)
               //{
               //
               //}
            }

        }


    }
}
