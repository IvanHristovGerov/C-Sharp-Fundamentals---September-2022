using System;

namespace _04._Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Четем броя на топките, чиито цветове ще проверяваме

            //2. Създаваме променливи за различните цветове топки(Red, Orange, Yellow, White, Black и Other)
            //3. Създаваме променлива за броя точки

            //4. Пускаме цикъл, който се върти от първата до последната топка вкл.
            // => Вътре в цикъла ще проверяваме цвета 
            // => Спрямо цвета ще манипулираме по различен начин точките

            //5. Отпечатваме изхода

            int n = int.Parse(Console.ReadLine());
            int redBalls = 0;
            int orangeBalls = 0;
            int yellowBalls = 0;
            int whiteBalls = 0;
            int blackBalls = 0;
            int otherBalls = 0;

            int points = 0;

            for (int i = 1; i <=n ; i++)
            {
                string color = Console.ReadLine();

                switch (color)
                {
                    case "red":
                        points += 5;
                            redBalls++;
                        break;
                    case "orange":
                        points += 10;
                        orangeBalls++;
                        break;
                    case "yellow":
                        points += 15;
                        yellowBalls++;
                        break;
                    case "white":
                        points += 20;
                        whiteBalls++;
                        break;
                    case "black":
                        points /= 2;
                        blackBalls++;
                        break;



                    default:
                        otherBalls++;
                        break;
                }
            }

            Console.WriteLine($"Total points:{points}");

               Console.WriteLine($"Orange balls: {orangeBalls}");
               Console.WriteLine($"Yellow balls: {yellowBalls}");
               Console.WriteLine($"White balls: {whiteBalls}");
               Console.WriteLine($"Other colors picked: {otherBalls}");
               Console.WriteLine($"Divides from black balls: {blackBalls}");

        }
    }
}
