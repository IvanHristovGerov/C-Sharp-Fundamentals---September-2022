using System;

namespace _08._Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++) //represent rows
            {
                for (int col = 1; col <= row; col++) //nested loop represent collumns
                {
                    Console.Write($"{row} ");
                }

                Console.WriteLine();
            }
        }
    }
}
