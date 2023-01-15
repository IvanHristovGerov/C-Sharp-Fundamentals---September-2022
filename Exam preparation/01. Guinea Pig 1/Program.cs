using System;

namespace _01._Guinea_Pig_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal food = decimal.Parse(Console.ReadLine());
            decimal hay = decimal.Parse(Console.ReadLine());
            decimal cover = decimal.Parse(Console.ReadLine());
            decimal weight = decimal.Parse(Console.ReadLine());

            for (int i = 1; i <= 30; i++)
            {
                food -= 0.3m;  //Намаляма храната с 300 гр. защото работим в кг!!!

                if (i % 2 == 0)  // Всеки 2ри ден
                {
                    hay -= food * 0.05m;
                }

                if (i % 3 == 0)  //Всеки 3ти ден
                {
                    cover -= weight / 3; // делим на 3 защото взимаме 1/3 от тежестта
                }

                if (food <= 0 || hay <= 0 || cover <= 0)
                {
                    break;
                }
            }

            if (food <= 0 || hay <= 0 || cover <= 0)
            {
                Console.WriteLine("Merry must go to the pet store!");
            }

            else
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:f2}, Hay: {hay:f2}, Cover: {cover:f2}.");  
            }
        }
    }
}
