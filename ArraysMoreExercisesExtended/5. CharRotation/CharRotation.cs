using System;
using System.Collections.Generic;
using System.Linq;

class CharRotation
{
    static void Main()
    {
        var symbols = Console.ReadLine();
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var result = string.Empty;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                result += (char)(symbols[i] - numbers[i]);
            }
            else
            {
                result += (char)(symbols[i] + numbers[i]);
            }
        }
             
        Console.WriteLine(result);
    }
}

