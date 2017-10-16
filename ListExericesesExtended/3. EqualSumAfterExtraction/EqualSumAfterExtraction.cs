using System;
using System.Collections.Generic;
using System.Linq;

class EqualSumAfterExtraction
{
    static void Main()
    {
        var list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        var list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        var list1Sum = 0;
        var list2Sum = 0;

        foreach (var num in list1)
        {
            list1Sum += num;
            if (list2.Contains(num))
            {
                list2.Remove(num);
            }
        }

        foreach (var num in list2)
        {
            list2Sum += num;
        }

        if (list1Sum == list2Sum)
        {
            Console.WriteLine($"Yes. Sum: {list1Sum}");
        }
        else
        {
            var difference = Math.Abs(list1Sum - list2Sum);

            Console.WriteLine($"No. Diff: {difference}");
        }
    }
}

