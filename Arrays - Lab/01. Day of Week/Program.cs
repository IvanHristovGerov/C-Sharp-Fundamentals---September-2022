using System;

namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string[] dayOfWeek = new string[7];
            dayOfWeek[0] = "Monday";
            dayOfWeek[1] = "Tuesday";
            dayOfWeek[2] = "Wednesday";
            dayOfWeek[3] = "Thursday";
            dayOfWeek[4] = "Friday";
            dayOfWeek[5] = "Saturday";
            dayOfWeek[6] = "Sunday";

            int day = int.Parse(Console.ReadLine());

            if (day >=1 && day <= 7)  //if(day <1 || day >7) ==> Console.Writeline("Invalid day!")
                                      // Console.WriteLine(dayOfWeek[day-1]);

            {
                Console.WriteLine(dayOfWeek[day-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

            //string [] dayOfWeek = new string [7] { "Monday";
             //                                       
             //                                       "Wednesday"
        }    //                                       "Thursday";
    }        //                                       "Friday";
}            //                                       "Saturday";
             //                                       "Sunday";