using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _10._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(=|\/)(?<name>[A-Z][A-Za-z]{2,})\1";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matches = Regex.Matches(input, pattern);

            List<string> destinations = new List<string>();
            int travelPoints = 0;

            foreach (Match match in matches)
            {
                string destination = match.Groups["name"].Value;
                destinations.Add(destination);

                travelPoints += destination.Length;


            }
            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
