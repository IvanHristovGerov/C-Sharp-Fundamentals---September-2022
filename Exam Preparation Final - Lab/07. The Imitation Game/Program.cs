using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] commandInfo = command
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);

                string cmdName = commandInfo[0];

                if (cmdName == "Move")
                {
                    int number = int.Parse(commandInfo[1]);
                    message = message.Remove(0, number) + message.Substring(0, number);

                }
                else if (cmdName == "Insert")
                {
                    int index = int.Parse(commandInfo[1]);
                    string value = commandInfo[2];

                    message = message.Insert(index, value);
                }
                else if (cmdName == "ChangeAll")
                {
                    string substring = commandInfo[1];
                    string replacement = commandInfo[2];

                    message = message.Replace(substring, replacement);
                }


                command = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}