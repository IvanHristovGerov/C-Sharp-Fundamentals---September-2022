using System;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string encryptedString = string.Empty; // var sb = new StringBuilder();

            foreach (char currChar in input)
            {
                int currPosition = currChar; //currChar = "p" in int => 80
                currPosition += 3;
                encryptedString += (char)currPosition; //sb.Append((char)currPosition);

            }
            Console.WriteLine(encryptedString);
        }
    }
}
