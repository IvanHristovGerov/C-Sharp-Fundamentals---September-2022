using System;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace _11._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            while (command != "Done")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmdName = cmdArgs[0];

                if (cmdName == "TakeOdd")
                {
                    for (int i = 1; i < input.Length; i += 2) //Taking ODD char from a string!
                    {
                        sb.Append(input[i]);
                        string result = sb.ToString();
                    }
                    Console.WriteLine(sb);
                }
                if (cmdName == "Cut")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int lengthToCut = int.Parse(cmdArgs[2]);

                    sb.Remove(index, lengthToCut);


                    Console.WriteLine(sb);
                }
                if (cmdName == "Substitute")
                {
                    string substring = cmdArgs[1];
                    string substitute = cmdArgs[2];

                    if (sb.ToString().Contains(substring))
                    {
                        sb.Replace(substring, substitute);
                        Console.WriteLine(sb);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {sb}");
        }
    }
}
