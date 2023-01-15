using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine(); //heVVodar!gniV

            string command = Console.ReadLine(); //InsertSpace:|:5

            while (command != "Reveal")
            {
                string[] commandInfo = command
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries);



                string commandName = commandInfo[0];

                if (commandName == "InsertSpace") //InsertSpace, 5
                {
                    int index = int.Parse(commandInfo[1]);
                    message = message.Insert(index, " "); //Трябва да се презапише ( message = message)
                                                          //, защото стринговете са  Immutable

                    Console.WriteLine(message);
                }
                else if (commandName == "Reverse")
                {
                    string substring = commandInfo[1];
                    int startIndex = message.IndexOf(substring);

                    if (startIndex != -1)
                    {
                        message = message.Remove(startIndex, substring.Length);
                        message += string.Join("", substring.Reverse());
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }


                }
                else if (commandName == "ChangeAll")
                {
                    string substring = commandInfo[1];
                    string replacement = commandInfo[2];

                    message = message.Replace(substring, replacement);
                    Console.WriteLine(message);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
