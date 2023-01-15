using System;
using System.Linq;

namespace Problem_2___The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine()); //15
            int[] lift = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray(); // [0 0 0 0

            for (int i = 0; i < lift.Length; i++)
            {
                if (lift[i] < 4)  
                {
                    while (lift[i] < 4 && people >0)
                    {
                        lift[i]++;
                        people--;
                    }
                }
            }

            // [4, 4, 4, 4] false
            // [4, 4, 4, 1] true
            if (people == 0 && lift.Any(x => x < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(String.Join(" ", lift));
            }

            else if (people == 0 && lift.All(x=> x == 4))
            {
                Console.WriteLine(String.Join(" ", lift));
            }
            else
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(String.Join(" ", lift));
            }






            //result -> 4 4 4 3
        }
    }
}
