using System;
using System.Collections.Generic;
using System.Linq;

class AverageStudentGrades
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var namesAndGrades = new Dictionary<string, List<double>>();

        for (int i = 0; i < n; i++)
        {
            var inputLine = Console.ReadLine();

            var tokens = inputLine.Split(' ');
            var name = tokens[0];
            var grade = double.Parse(tokens[1]);

            if (! namesAndGrades.ContainsKey(name))
            {
                namesAndGrades[name] = new List<double>();
                namesAndGrades[name].Add(grade);
            }
            else
            {
                namesAndGrades[name].Add(grade);
            }

        }       

        foreach (var pair in namesAndGrades)
        {
            var name = pair.Key;
            var studentGrades = pair.Value;
            var avarage = studentGrades.Average();

            Console.Write($"{name} -> ");

            foreach (var grade in studentGrades)
            {
                Console.Write($"{grade:f2} ");
            }

            Console.WriteLine(" avg: ({0:f2})", avarage);
        }

        
    }
}

