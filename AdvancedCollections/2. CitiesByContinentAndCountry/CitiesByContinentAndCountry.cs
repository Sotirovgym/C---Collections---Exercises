using System;
using System.Collections.Generic;
using System.Linq;

class CitiesByContinentAndCountry
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var continetsData = new Dictionary<string, Dictionary<string, List<string>>>();

        for (int i = 0; i < n; i++)
        {
            var inputLine = Console.ReadLine();

            var tokens = inputLine.Split(' ');
            var continet = tokens[0];
            var country = tokens[1];
            var city = tokens[2];

            if (! continetsData.ContainsKey(continet))
            {
                continetsData[continet] = new Dictionary<string, List<string>>();                
            }

            if (! continetsData[continet].ContainsKey(country))
            {
                continetsData[continet][country] = new List<string>();
              
            }

            continetsData[continet][country].Add(city);
        }

        foreach (var continentByCountry in continetsData)
        {
            var continents = continentByCountry.Key;
            var countries = continentByCountry.Value;

            Console.WriteLine($"{continents}: ");

            foreach (var citiesByCountry in countries)
            {
                var country = citiesByCountry.Key;
                var city = citiesByCountry.Value;

                Console.WriteLine($"{country} -> {string.Join(", ", city)}");
            }
        }

    }
}

