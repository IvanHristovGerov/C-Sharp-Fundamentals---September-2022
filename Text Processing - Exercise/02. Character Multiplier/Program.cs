using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Step 1 Converting string input "Peter George" in string[] =>
            //["Peter", "George"] by using Split();

            //Step 2 - Creating Method that takes two arguments string input [0] and input [1]

            //Step 3 - Create integer sum = 0 in which we save the final sum of multiplication/ adding if the
            //one string is longer then the other

            //Step 4 - Finding string that is bigger than the other Math.Min(stringOne.Length, stringTwo.Length)

            //Step 5 - Creater for loop string from 0 till minLength to go throught both strings
            string[] input = Console.ReadLine().Split();
            GetStringSum(input[0], input[1]);
        }

        private static void GetStringSum(string stringOne, string stringTwo)
        {
            int sum = 0;
            int minLength = Math.Min(stringOne.Length, stringTwo.Length);

            for (int i = 0; i < minLength; i++)
            {
                sum += stringOne[i] * stringTwo[i];
            }

            string longestLengthString = stringOne;

            if (longestLengthString.Length < stringTwo.Length)
            {
                longestLengthString = stringTwo;
            }
            for (int i = minLength; i < longestLengthString.Length; i++)
            {
                sum += longestLengthString[i];
            }
            Console.WriteLine(sum);
        }
    }
}
