using System;
using System.Collections.Generic;
using System.Linq;

class ArrayElementsEqualToTheirIndex
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var result = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == i)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();        
    }
}

