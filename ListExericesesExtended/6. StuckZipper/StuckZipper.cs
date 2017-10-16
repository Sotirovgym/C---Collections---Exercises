using System;
using System.Collections.Generic;
using System.Linq;

class StuckZipper
{
    static void Main()
    {
        var list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        var list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        var idealNumberOfDigits = CalculateIdealNumberOfDigits(list1, list2);

        RemoveNonIdealNumbers(list1, idealNumberOfDigits);
        RemoveNonIdealNumbers(list2, idealNumberOfDigits);

        var insertIndex = 1;

        for (int i = 0; i < list1.Count; i++)
        {
            list2.Insert(Math.Min(insertIndex, list2.Count), list1[i]);

            insertIndex += 2;
        }

        Console.WriteLine(string.Join(" ", list2));
    }

    static void RemoveNonIdealNumbers(List<int> list, int idealNumberOfDigits)
    {
        for (int i = 0; i < list.Count; i++)
        {
            var currentNumberOfDigits = CalculateNumbersOfDigits(list[i]);

            if (currentNumberOfDigits > idealNumberOfDigits)
            {
                list.RemoveAt(i);
                i--;
            }
        }
    }

    static int CalculateIdealNumberOfDigits(List<int> list1, List<int> list2)
    {
        var idealNumbers = int.MaxValue;

        foreach (var item in list1)
        {
            var numbersOfDigits = CalculateNumbersOfDigits(item);

            if (numbersOfDigits < idealNumbers)
            {
                idealNumbers = numbersOfDigits;
            }
        }

        foreach (var item in list2)
        {
            var numbersOfDigits = CalculateNumbersOfDigits(item);

            if (numbersOfDigits < idealNumbers)
            {
                idealNumbers = numbersOfDigits;
            }
        }

        return idealNumbers;
    }

    private static int CalculateNumbersOfDigits(int number)
    {
        number = Math.Abs(number);

        var numberOfDigits = 0;

        while (number > 0)
        {
            numberOfDigits++;

            number /= 10;
        }

        return numberOfDigits;
    }
}

