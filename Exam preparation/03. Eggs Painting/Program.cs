using System;

namespace _03._Eggs_Painting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата размер, цвят и брой партиди

            //2. В зависимост от размера и цвета намираме цената на една партида

            //3. Намираме цената за всички партиди

            //4. Намираме колко пари ще е печалбата - 35% за разходи. (35% от цената)

            //5. Отпечатваме печалбата

            string size = Console.ReadLine();
            string color = Console.ReadLine();
            int batches = int.Parse(Console.ReadLine());

            double price;



            if (size == "Large")
            {
                if (color == "Red")
                {
                    price = 16;
                }
                else if (color == "Green")
                {
                    price = 12;
                }
                else
                {
                    price = 9;
                }
            }
            else if (size == "Medium")
            {
                if (color == "Red")
                {
                    price = 13;
                }
                else if (color == "Green")
                {
                    price = 9;
                }
                else
                {
                    price = 7;
                }
            }
            else
            {
                if (color == "Red")
                {
                    price = 9;
                }
                else if (color == "Green")
                {
                    price = 8;
                }
                else
                {
                    price = 5;
                }
            }

            price *= batches;

            price -= price * 0.35; // *35/100

            Console.WriteLine($"{price:f2} leva.");

        }
    }
}
