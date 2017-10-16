using System;
using System.Collections.Generic;
using System.Linq;

class RemoveElementsAtOddPositions
{
    static void Main()
    {
        var words = Console.ReadLine().Split(' ').ToList();

        var wordsOnEvenPosition = new List<string>();

        var count = 1;

        for (int i = 0; i < words.Count; i++)
        {
            if (count % 2 == 0)
            {
                wordsOnEvenPosition.Add(words[i]);
            }

            count++;
        }

        Console.WriteLine(string.Join("", wordsOnEvenPosition));
    }
}

