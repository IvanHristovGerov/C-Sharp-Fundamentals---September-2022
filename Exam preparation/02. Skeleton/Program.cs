using System;

namespace _02._Skeleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. четем вход от конзолата:
            // минути на контролата
            // секунди на контролата - цяло число 
            // дължина на улея в метри
            // секунди за изминаване на 100

            //2. пресмятаме времето на марин
            // => Намираме колко пъти ще се забърза (на всеки 120м с 2.5 сек)
            // => Колко общо времето му => Дължината на улея * секунди за изминаване - изваждаме времето, в което се е забързал

            //3. Проверяваме дали времето му е по-малко ИЛИ равно на контролата
            //=> привеждаме контролата в сек.
            //=> правим if проверка
            //=> в зависимост от резултата отпечатваме различен изход

            int min = int.Parse(Console.ReadLine()); //
            int sec = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());   
            int speed = int.Parse(Console.ReadLine());

            double reducedTime = lenght / 120 * 2.5;

            double timeByMarin = lenght * speed - reducedTime;

            double control = sec + min * 60;
            
            if (timeByMarin <= control)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {timeByMarin:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was  {Math.Abs(control-timeByMarin):f3} second slower."); 
            }

        }
    }
}
