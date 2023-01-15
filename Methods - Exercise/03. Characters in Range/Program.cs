using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secontChar = char.Parse(Console.ReadLine());

            CharsBetween(firstChar, secontChar);
           
        }

        static void CharsBetween(char FirstChar, char secondChar)
        {
            int startChar = Math.Min(FirstChar, secondChar);
            int endChar = Math.Max(FirstChar, secondChar);


            for (int i = ++startChar; i < endChar; i++)
            {
                Console.Write((char)i + " ");
               
            }

            
        }


    }
}
