using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "Finish")
            {
                string[] inputParams = input.Split();
                
                string command = inputParams[0];

                if (command == "Add")
                {
                    int value = int.Parse(inputParams[1]);
                    numbers.Add(value);
                }
                else if (command == "Remove")
                {
                    int value = int.Parse(inputParams[1]);
                    numbers.Remove(value); 
                }
                else if (command == "Replace")
                {
                    int value = int.Parse(inputParams[1]);
                    int replacement = int.Parse(inputParams[2]);
                    
                    numbers.RemoveAt(1);
                    numbers.Insert(1, replacement);
                    
                }
                else if(command == "Collapse")
                {
                    int value = int.Parse(inputParams[1]);
                    numbers.RemoveAll(x => x < value);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));

            
        }
    }
}
