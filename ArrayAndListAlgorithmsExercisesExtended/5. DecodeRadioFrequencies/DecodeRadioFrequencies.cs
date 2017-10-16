using System;
using System.Collections.Generic;
using System.Linq;

class DecodeRadioFrequencies
{
    static void Main()
    {
        var frequencies = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
        var result = new List<string>();

        for (int i = 0; i < frequencies.Length; i++)
        {
            var tokens = frequencies[i].ToString().Split('.');

            var leftPart = int.Parse(tokens[0]);
            var rightPart = int.Parse(tokens[1]);

            if (leftPart != 0)
            {
                var leftPartAsString = ((char)leftPart).ToString();
                result.Insert(i, leftPartAsString);
            }

            if (rightPart != 0)
            {
                var rightPartAsString = ((char)rightPart).ToString();
                result.Insert(result.Count - i, rightPartAsString);
            }           
        }

        Console.WriteLine(string.Join("", result));
    }
}

