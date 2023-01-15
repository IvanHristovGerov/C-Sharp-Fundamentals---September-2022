using System;

namespace _05._Care_of_Puppies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Четем количеството закупеха храна в кг и да го преобр. в гр.

            //2. Създаваме си променлива за общото количество храна и за храната на текущото хранене.

            //2. До получаване на командата "Adopted" въртим цикъл
            //=> Четем количество грана в гр. която яде на хранене и я добавяме към изяденото до момента

            //4. Проверяваме дали храната е била достатъчно

            int boughtFood = int.Parse(Console.ReadLine())*1000; //oт кг в гр.

            int totalEatenFood = 0;
            int eatenFood;

            string input = Console.ReadLine();

            while (input != "Adopted")
            {

                totalEatenFood += int.Parse(input);

                input = Console.ReadLine();
            }

            if (boughtFood >= totalEatenFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {boughtFood - totalEatenFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {totalEatenFood - boughtFood} grams more.");
            }


        }
    }
}
