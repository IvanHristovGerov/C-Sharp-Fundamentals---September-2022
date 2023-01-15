using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies =
                 new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string companyName = cmdArgs[0];
                string employeeId = cmdArgs[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies[companyName] = new List<string>();
                    companies[companyName].Add(employeeId);

                }
                else
                {
                    if (!companies[companyName].Any(e => e == employeeId))
                    {
                        companies[companyName].Add(employeeId);
                    }
                }


            }


            foreach (var kvp in companies)
            {
                string companyName = kvp.Key;
                List<string> identifications = kvp.Value;
                Console.WriteLine(companyName);

                foreach (var employeeId in identifications)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }
        }
    }