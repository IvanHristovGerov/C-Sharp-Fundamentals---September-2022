﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<int> targets = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();  //command comes like this Shoot 5 10
            while (command != "End")
            {
                //Shoot 5 10
                string[] commandInfo = command.Split(); //["Shoot, 5, 10"] 
                string commandName = commandInfo[0];
                int index = int.Parse(commandInfo[1]);
                int value = int.Parse(commandInfo[2]);

                if (commandName == "Shoot")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= value;

                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (commandName == "Add")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (commandName == "Strike")
                {
                    //Example:
                    //Strike 2 2
                    //[1, 2, 3, 4, 5]
                    //как става:
                    //index e 2=>  0 >= 0 && 4 < 5  value= 2 => 2+2=4
                    if (index - value >= 0 && index + value < targets.Count)
                    {
                        //Remove the target at the given index and the ones before and after it, depending on the radius.
                        targets.RemoveRange(index - value, value * 2 + 1); 

                        //така махаме таргета от дадения индекс + индексите преди и след него.
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }

                }
                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join("|", targets));
        }
    }
}
