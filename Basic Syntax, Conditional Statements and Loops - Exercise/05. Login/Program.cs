﻿using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0 ; i--)
            {
                char name = username[i];
                password += name;
                
            }

            int totalTries = 1; //counter
            string enteredPassword;

            while ((enteredPassword = Console.ReadLine()) != password)
            {
                 //Inside the loop ++ the tries.
                if (totalTries >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                totalTries++;

                
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
