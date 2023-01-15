using System;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Step 1 - Reading the input
            string text = Console.ReadLine();
            //Step 2 => text = aaaabbbcc => previous char = text [0]
            char previousChar = text[0];  //'a'
            Console.Write(previousChar);
            //step 3 - iterate through the text starting from 1 index

            for (int i = 1; i < text.Length; i++)
            {
                //Step 4 - taking the currChar and making check with the previous
                char currentChar = text[i];
                if (previousChar != currentChar) //a != b the prevouschar = b
                {
                    previousChar = currentChar;
                    Console.Write(previousChar);
                }
            }
        }
    }
}
