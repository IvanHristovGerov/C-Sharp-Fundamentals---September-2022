namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            int targetIndex = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            long leftSum = numbers.Take(targetIndex)
            .Where(num => IsValid((int)num, (int)numbers[targetIndex], type)).Sum();

            long rightSum = numbers.Skip(targetIndex + 1)
                .Where(num => IsValid((int)num, (int)numbers[targetIndex], type)).Sum();

            Console.WriteLine(leftSum >= rightSum ? "Left - " + leftSum : "Right - " + rightSum);
        }

        public static bool IsValid(int number, int targetNumber, string type)
        {
            if (type == "cheap")
            {
                if (targetNumber > number)
                {
                    return true;
                }
            }
            else
            {
                if (targetNumber <= number)
                {
                    return false;
                }
            }

            return false;
        }
    }
}