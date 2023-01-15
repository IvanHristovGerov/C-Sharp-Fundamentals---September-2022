using System;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 way -> void Method(string text) -> Console.Writeline()
            //2 way -> int Method(string text) -> Main: Console.Writeline();
            // second way is mostly used

            string text = Console.ReadLine();

           int vowelsCount = GetVowelsCount(text);
            Console.WriteLine(vowelsCount);
        }
        static int GetVowelsCount(string text)
        {
            int vowelsCount = 0;
            char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i', 'y' };

            foreach (char letter in text.ToLower()) //Прави всичко с малку букви
            {
                if (vowels.Contains(letter))
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
    }
}
