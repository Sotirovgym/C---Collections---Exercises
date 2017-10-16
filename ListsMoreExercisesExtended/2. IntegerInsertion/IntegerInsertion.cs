using System;
using System.Collections.Generic;
using System.Linq;

class IntegerInsertion
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        var numberAsString = Console.ReadLine();

        while (numberAsString != "end")
        {
            var indexOfNumber = int.Parse(numberAsString.Substring(0, 1));

            var number = int.Parse(numberAsString);
            numbers.Insert(indexOfNumber, number);

            numberAsString = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

