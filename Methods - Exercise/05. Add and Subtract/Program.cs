using System;
using System.Diagnostics.CodeAnalysis;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = int.Parse(Console.ReadLine());
            numbers[1] = int.Parse(Console.ReadLine());
            numbers[2] = int.Parse(Console.ReadLine());
            
            
            int firstSum = AddfirstTwo(numbers);
            int secondSum = SubstractSum(numbers);

            

            Console.WriteLine(secondSum);
           
         
        }

        static int AddfirstTwo(int[] numbers)
        {
           int firstSum = numbers[0] + numbers[1];
            return firstSum;
          
        }
        static int SubstractSum(int[] numbers)
        {
            int secondSum = ((numbers[0] + numbers[1]) - numbers[2]);
            return secondSum;

        }
      
    }
}
