using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students =
                 new Dictionary<string, List<double>>();
            Dictionary<string, double> bestStudents =
                new Dictionary<string, double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                    students[name].Add(grade);
                }
                else
                {
                    students[name].Add(grade);
                }

            }


            foreach (var student in students)
            {
                int countOfGrade = student.Value.Count;
                double sum = 0.00;
                for (int i = 0; i < countOfGrade; i++)
                {
                    sum += student.Value[i];
                }
                double averageGrade = sum / countOfGrade;

                if (averageGrade >= 4.50)
                {
                    bestStudents.Add(student.Key, averageGrade);
                }
            }

            foreach (var student in bestStudents)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}