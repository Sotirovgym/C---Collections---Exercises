using System;
using System.Collections.Generic;
using System.Linq;

class Winecraft
{
    static void Main()
    {
        var grapes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        var rounds = int.Parse(Console.ReadLine());

        var count = 0;

        while (count > rounds)
        {
            for (int n = 0; n < rounds; n++)
            {
                IncrementAllGrapes(grapes);

                for (int i = 0; i < grapes.Count; i++)
                {
                    ProcessGrapes(grapes, i);
                }
            }

            RemoveWeekGrapes(grapes, rounds, count);
        }

        Console.WriteLine(string.Join(" ", grapes));
        
    }

    private static void IncrementAllGrapes(List<int> grapes)
    {
        for (int i = 0; i < grapes.Count; i++)
        {
            if (grapes[i] != 0)
            {
                grapes[i]++;
            }

        }
    }

    private static void ProcessGrapes(List<int> grapes, int i)
    {
        var isFirstElement = i == 0;
        var isLastElement = i == grapes.Count - 1;

        if (!isFirstElement && !isLastElement)
        {
            var previosIndex = i - 1;
            var nextIndex = i + 1;

            var isGreaterThanPrevious = grapes[i] > grapes[previosIndex];
            var isGreaterThanNext = grapes[i] > grapes[nextIndex];
            var isGreaterGrape = isGreaterThanPrevious && isGreaterThanNext;

            if (isGreaterGrape)
            {
                if (grapes[previosIndex] > 0)
                {
                    grapes[i]++;
                    grapes[previosIndex] = Math.Max(grapes[previosIndex] - 2, 0);
                }

                if (grapes[nextIndex] > 0)
                {
                    grapes[i]++;
                    grapes[nextIndex] = Math.Max(grapes[nextIndex] - 2, 0);
                }
            }
        }
    }

    private static void RemoveWeekGrapes(List<int> grapes, int rounds, int count)
    {
        for (int i = 0; i < grapes.Count; i++)
        {
            if (grapes[i] <= rounds)
            {
                grapes[i] = 0;
            }
            else
            {
                count++;
            }
        }
    }
}

