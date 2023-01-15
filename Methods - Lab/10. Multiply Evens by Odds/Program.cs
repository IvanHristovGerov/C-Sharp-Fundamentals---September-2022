using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();//"1234"

            int absValue = Math.Abs(int.Parse(input)); //1234

            int sumOfEvenDigits = GetSumOfEvenDigits(absValue.ToString());
            int sumOfOddnDigits = GetSumOfOddDigits(absValue.ToString());

            int result = sumOfEvenDigits * sumOfOddnDigits;
            Console.WriteLine(result);

        }

        private static int GetSumOfOddDigits(string input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int currNumber = int.Parse(input[i].ToString());
                if (currNumber % 2 != 0)
                {
                    sum += currNumber;
                }
            }
            return sum;
        }

        private static int GetSumOfEvenDigits(string input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int currNum = int.Parse(input[i].ToString());

                if (currNum % 2 == 0)
                {
                    sum += currNum;
                }
            }
            return sum;
        }
    }
}
