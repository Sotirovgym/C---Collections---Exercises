using System;
using System.Collections.Generic;
using System.Linq;

class GroupContinentsCountriesAndCities
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var continentsData = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

        for (int i = 0; i < n; i++)
        {
            var inputData = Console.ReadLine();

            var tokens = inputData.Split(' ');

            var continent = tokens[0];
            var country = tokens[1];
            var city = tokens[2];

            if (! continentsData.ContainsKey(continent))
            {
                continentsData[continent] = new SortedDictionary<string, SortedSet<string>>();
            }

            if (! continentsData[continent].ContainsKey(country))
            {
                continentsData[continent][country] = new SortedSet<string>();
            }

            continentsData[continent][country].Add(city);
        }

        foreach (var continentByCountries in continentsData)
        {
            var continents = continentByCountries.Key;
            var countries = continentByCountries.Value;
            

            Console.WriteLine($"{continents}:");

            foreach (var countriesByCities in countries)
            {
                var country = countriesByCities.Key;
                var city = countriesByCities.Value;

                Console.WriteLine($"  {country} -> {string.Join(", ", city)}");
            }
        }
    }
}

