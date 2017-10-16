using System;
using System.Collections.Generic;
using System.Linq;

class TearListInHalf
{
    static void Main()
    {
        var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        var upperList = new List<int>();
        var lowerList = new List<int>();

        SeparateListToUpperAndLower(list, upperList, lowerList);

        PrintTearListInHalf(upperList, lowerList);

    }

    private static void PrintTearListInHalf(List<int> upperList, List<int> lowerList)
    {
        var separatedDigits = new List<int>();

        var digits = 0;

        for (int i = 0; i < upperList.Count; i++)
        {
            digits = upperList[i] / 10;
            separatedDigits.Add(digits);

            separatedDigits.Add(lowerList[i]);

            digits = upperList[i] % 10;
            separatedDigits.Add(digits);
        }

        Console.WriteLine(string.Join(" ", separatedDigits));
    }

    private static void SeparateListToUpperAndLower(List<int> list, List<int> upperList, List<int> lowerList)
    {
        var count = 0;

        for (int i = 0; i < list.Count; i++)
        {
            count++;

            if (count <= list.Count / 2)
            {
                lowerList.Add(list[i]);
            }
            else
            {               
                upperList.Add(list[i]);
            }
        }
        
    }
}

