using System;
using System.Linq;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.- Initialize emply field

          
            int n = int.Parse(Console.ReadLine()); //Field size
            int[] field= new int[n];
            //bool[] boolField = new bool[n]; //Emply-->False, Ladybug-->True 

            //2.- Spawn ladybugs on the valid indexes
            int[] intialIndexes = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //This collection remains unchanged!!!
            foreach (int index in intialIndexes)
            {
                if (index >=0 && index <field.Length)
                {
                    //Valid index => Initialize ladybug on this index
                    field[index] = 1; //1 means ladybug
                }
            }

            //3. Proceed game moves (Start Game)
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries); //Разделяме командата със "spaces" и я разделяме на стрингове (0 right 1)
                int ladybugIndex = int.Parse(cmdArgs[0]);
                string direction = cmdArgs[1];
                int flyLength = int.Parse(cmdArgs[2]);

                //3.1 Validate ladybugIndex is inside the field!
                if (ladybugIndex < 0 || ladybugIndex >=field.Length)
                {
                    //Invalid index==> Nothing happens
                    continue; //continue is to skip this step
                }

                //3.2 Validate ladybugIndex contains ladybug!
                if (field[ladybugIndex]==0)
                {
                    //There is no ladybug there => Nothing happens
                    continue;
                }

                //3.3 Try to proceed move
                //Right(move) -->ladybugIndex + flyLength
                //Left(move) --> ladybugIndex - flyLength
                //First -->Our ladybug starts flying => it removes from the field, it is in the air.
                field[ladybugIndex] = 0;
                if (direction == "left")
                {
                    flyLength *= -1; //(flylength=1 ==> -1
                }
                //Right => 0 + 1 = 1
                //Left => 1 +(-1) = 0
                int nextIndex = ladybugIndex + flyLength;

                while (nextIndex >= 0 && nextIndex < field.Length && field[nextIndex] == 1)
                {
                    nextIndex += flyLength;
                }

                //There are two possibilities:
                //Variant a: nextIndex is calculated somewhere in the field.
                //Variant b: nextIndex cannot be calculated in the field.
                if (nextIndex < 0 || nextIndex >= field.Length)
                {
                    //Variant b
                    //Outside of the field
                    continue;
                }
                //Variant a
                //Land the ladybug on the valid next index
                field[nextIndex] = 1;


            }

            Console.WriteLine(String.Join(" ", field));
        }
    }
}
