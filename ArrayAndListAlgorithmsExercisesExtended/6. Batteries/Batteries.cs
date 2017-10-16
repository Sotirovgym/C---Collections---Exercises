using System;
using System.Collections.Generic;
using System.Linq;

class Batteries
{
    static void Main()
    {
        var capacity = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        var usagePerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        var hours = int.Parse(Console.ReadLine());

        var count = 0;
        var percentage = new List<double>();
        var result = new List<string>();

        for (int i = 0; i < capacity.Length; i++)
        {
            var temp = capacity[i];

            var capacityLeft = usagePerHour[i] * hours;           
            var powerLeft = capacity[i] -= capacityLeft;

            if (powerLeft <= 0)
            {
                count++;
                percentage.Add(capacity[i] / temp * 100);
                result.Add($"Battery {count}: dead (lasted {Math.Ceiling(temp / usagePerHour[i])} hours)");
            }
            else
            {
                count++;
                percentage.Add(capacity[i] / temp * 100);
                result.Add($"Battery {count}: {powerLeft:f2} mAh ({percentage[i]:f2})%");
            }
            
        }

        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}

