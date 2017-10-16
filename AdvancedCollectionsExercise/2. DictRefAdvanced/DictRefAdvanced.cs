using System;
using System.Collections.Generic;
using System.Linq;

class DictRefAdvanced
{
    static void Main()
    {
        var result = new Dictionary<string, List<int>>();

        while (true)
        {
            var command = Console.ReadLine();

            if (command == "end")
            {
                break;
            }

            var tokens = command.Split(new [] {' ', '-', '>', ','}, StringSplitOptions.RemoveEmptyEntries);
            var name = tokens[0];
            var keyOrValue = tokens[1];
            
            var number = 0;

            if (int.TryParse(keyOrValue, out number))
            {               

                if (! result.ContainsKey(name))
                {
                    result[name] = new List<int>();                   
                }

                for (int i = 1; i < tokens.Length; i++)
                {
                    result[name].Add(int.Parse(tokens[i]));
                }
            }
            else
            {
                var otherName = tokens[1];

                if (result.ContainsKey(otherName))
                {
                    result[name] = new List<int>(result[otherName]);
                }
            }
        }

        foreach (var item in result)
        {
            var key = item.Key;
            var value = item.Value;

            Console.WriteLine($"{key} === {string.Join(", ", value)}");
        }
    }
}

