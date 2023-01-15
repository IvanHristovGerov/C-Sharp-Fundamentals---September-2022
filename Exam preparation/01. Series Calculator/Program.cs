using System;

namespace _01._Series_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата име на сериал, брой сезони, брой епизоди за сезон и продължителност на епизод в мин.

            //2. Пресмятаме колко време е необходимо, за да изгледаме всички сезони

            // => пресмятаме времето за 1 епизод => продължителност на епизода + 20% от времето за реклами
            // => пресмятаме времето за 1 сезон => времето за 1 епизод * брой епизоди + 10м. специално време
            // => пресмятаме времето за всички сезони => времето за 1 сезон * броя сезони

            //3. Отпечатваме резултат => "Total time needed to watch the {име на сериал} series is {време} 

            string seriesName = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int episodes = int.Parse(Console.ReadLine());
            double duration = double.Parse(Console.ReadLine());

            double episodesTime = duration + duration * 0.2; // *20/100
            double seasonTime = episodesTime * episodes + 10;
            double time = seasonTime * seasons;

            Console.WriteLine($"Total time needed to watch the {seriesName} series is {Math.Floor(time)} minutes.");

        }
    }
}
