using System;
using System.Collections.Generic;
using System.Linq;

class SortArrayOfStrings
{
    static void Main()
    {
        var words = Console.ReadLine().Split(' ').ToList();

        var temp = string.Empty;

        for (int write = 0; write < words.Count; write++)
        {
            for (int sort = 0; sort < words.Count - 1; sort++)
            {
                if (string.Compare(words[sort], words[sort + 1]) < 0)
                {
                    temp = words[sort];
                    words[sort] = words[sort + 1];
                    words[sort + 1] = temp;

                }
            }
        }

        for (int i = 0; i < words.Count / 2; i++)
        {
            temp = words[i];
            words[i] = words[words.Count - i - 1];
            words[words.Count - i - 1] = temp;
        }

        Console.WriteLine(string.Join(" ", words));
    }
}

