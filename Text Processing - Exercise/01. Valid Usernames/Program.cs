using System;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the input from the console
            string[] usernames = Console.ReadLine().Split(", ");
            //interate through all the usernames
            foreach (string currName in usernames)
            {
                if (currName.Length>3 && currName.Length<=16)
                {
                    //Check if the username is valid
                    bool isUsernameValid = true;
                    foreach (char currChar in currName) //Разделяме го на  chararray
                    {
                        if (!(char.IsLetterOrDigit(currChar) || currChar =='-' 
                            || currChar =='_'))
                        {
                            isUsernameValid = false;
                            break;
                        }
                    }
                    if (isUsernameValid)
                    {
                        Console.WriteLine(currName);
                    }
                }
            }
        }
    }
}
