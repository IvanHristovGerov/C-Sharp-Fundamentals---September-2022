using System;

namespace _08._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destinations = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] commandInfo = command
                    .Split(':', StringSplitOptions.RemoveEmptyEntries);

                string cmdName = commandInfo[0];

                if (cmdName == "Add Stop")
                {
                    int index = int.Parse(commandInfo[1]);
                    string dest = commandInfo[2];

                    if (index >= 0 && index <= destinations.Length - 1)
                    {
                        destinations = destinations.Insert(index, dest);

                    }
                    Console.WriteLine(destinations);
                }
                else if (cmdName == "Remove Stop")
                {
                    int startIndex = int.Parse(commandInfo[1]);
                    int endIndex = int.Parse(commandInfo[2]);

                    if (startIndex >= 0 && endIndex >= 0
                        && startIndex <= destinations.Length - 1 && endIndex <= destinations.Length - 1)
                    {
                        destinations = destinations.Remove(startIndex, endIndex + 1 - startIndex);

                    }
                    Console.WriteLine(destinations);

                }
                else if (cmdName == "Switch")
                {
                    string oldString = commandInfo[1];
                    string newString = commandInfo[2];

                    destinations = destinations.Replace(oldString, newString);

                    Console.WriteLine(destinations);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {destinations}");
        }
    }
}
