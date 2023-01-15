using System;

namespace _01._String_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] commandInfo = command
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string cmdName = commandInfo[0];

                if (cmdName == "Change")
                {
                    string ch = commandInfo[1];
                    string replacement = commandInfo[2];

                    message = message.Replace(ch, replacement);
                    Console.WriteLine(message);
                }

                if (cmdName == "Includes")
                {
                    string subStr = commandInfo[1];
                    if (message.Contains(subStr))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                    
                }

                if (cmdName == "End")
                {
                    string subStr = commandInfo[1];

                    if (message.EndsWith(subStr))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }

                if (cmdName == "Uppercase")
                {
                    message = message.ToUpper();
                    Console.WriteLine(message);
                }

                if (cmdName == "FindIndex")
                {
                    string ch = commandInfo[1];

                    Console.WriteLine(message.IndexOf(ch));
               
                }


                if (cmdName == "Cut")
                {
                    int startIndex = int.Parse(commandInfo[1]);
                    int count = int.Parse(commandInfo[2]);
                    
                    string newMessage = message.Substring(startIndex, count);
                    Console.WriteLine(newMessage);
    
                }




                command = Console.ReadLine();
            }
        }
    }
}
