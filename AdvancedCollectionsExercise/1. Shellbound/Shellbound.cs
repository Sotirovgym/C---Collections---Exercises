using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var regionOfShells = new Dictionary<string, HashSet<int>>();
        

        while (true)
        {
            var countryAndShellSize = Console.ReadLine();

            if (countryAndShellSize == "Aggregate")
            {
                break;
            }

            var tokens = countryAndShellSize.Split(' ');
            var country = tokens[0];
            var size = int.Parse(tokens[1]);

            if (! regionOfShells.ContainsKey(country))
            {
                regionOfShells[country] = new HashSet<int>();
            }
            
            regionOfShells[country].Add(size);
            
        }

        foreach (var region in regionOfShells)
        {
            long sum = 0l;

            foreach (var shell in region.Value)
            {
                sum += shell;
            }

            if (region.Value.Count > 1)
            {
                sum -= (sum / region.Value.Count);
            }

            Console.WriteLine($"{region.Key} -> {string.Join(", ", region.Value)} ({sum})");
        }    
        
    }
}

