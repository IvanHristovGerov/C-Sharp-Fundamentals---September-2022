using System;
using System.Text.RegularExpressions;

namespace MessageDecrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"([!])(?<command>[A-Z][A-Za-z]{2,})\1():([[])(?<string>[A-Z][A-Za-z]{7,})(])";
            string commandPattern = @"(?<command>[A-Za-z]{2,})";
            string messagePattern = @"([[])(?<string>[A-Z][A-Za-z]{7,})(])";
            string command = "";
            string message = "";
            string translatedText = "";

            Regex regex = new Regex(pattern);
            Regex commandRegex = new Regex(commandPattern);
            Regex messageRegex = new Regex(messagePattern);
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);
                Match commandMatch = commandRegex.Match(input);
                Match messageMatch = messageRegex.Match(input);

                if (!match.Success)
                {
                    Console.WriteLine("The message is invalid");
                    continue;
                }

                command = commandMatch.Value.Trim(new char[] { '!' });
                message = messageMatch.Value.Trim(new char[] { '[', ']' });

                foreach (char ch in message)
                {
                    translatedText += System.Convert.ToInt32(ch) + " ";
                }
                Console.WriteLine(command + ": " + translatedText.TrimEnd());
            }

        }
    }
}
