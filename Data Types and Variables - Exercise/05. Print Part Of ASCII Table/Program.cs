using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            //char -> int / int->char

            for (int i = startIndex; i <= endIndex; i++)
            {
                char currCh = (char)i; //Casting from char to int
                Console.Write(currCh + " ");
            }
        }
    }
}
