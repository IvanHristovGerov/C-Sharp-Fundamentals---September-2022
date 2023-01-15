using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Messages_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> allUsers = new Dictionary<string, List<int>>();

            string command = Console.ReadLine();
            while (command != "Statistics")
            {
                string[] commandInfo = command
                    .Split('=',StringSplitOptions.RemoveEmptyEntries);
                string cmdName = commandInfo[0];

                if (cmdName == "Add")
                {
                    string userName = commandInfo[1];
                    int sendMsg = int.Parse(commandInfo[2]);
                    int recievedMsg = int.Parse(commandInfo[3]);

                    if (!allUsers.ContainsKey(userName))
                    {
                        allUsers.Add(userName, new List<int>());
                        allUsers[userName].Add(sendMsg);
                        allUsers[userName].Add(recievedMsg);
                    }
                }

                if (cmdName == "Message")
                {
                    string sender = commandInfo[1];
                    string reciever = commandInfo[2];

                    if (allUsers.ContainsKey(sender) && allUsers.ContainsKey(reciever))
                    {
                        allUsers[sender][0]++;
                        allUsers[reciever][1]++;

                        if (allUsers[sender].Sum() >= n)
                        {
                            allUsers.Remove(sender);
                            Console.WriteLine($"{sender} reached the capacity!");
                        }
                        if (allUsers[reciever].Sum() >= n)
                        {
                            allUsers.Remove(reciever);
                            Console.WriteLine($"{reciever} reached the capacity!");
                        }
                    }
                }

                if (cmdName == "Empty")
                {
                    string user = commandInfo[1];

                    if (allUsers.ContainsKey(user))
                    {
                        allUsers.Remove(user);
                    }
                    if (user == "All")
                    {
                        allUsers.Clear();
                    }
                                    
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {allUsers.Count}");
            foreach (var user in allUsers)
            {
                int sum = user.Value.Sum();
                Console.WriteLine($"{user.Key} - {sum}");
                    
            }
        }
    }
}
