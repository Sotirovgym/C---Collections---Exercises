using System;
using System.Collections.Generic;
using System.Linq;

class ArrayHistogram
{
    static void Main()
    {
        var words = Console.ReadLine().Split(' ').ToArray();

        var uniqueWords = new List<string>();

        var ocuurenses = new List<int>();

        for (int i = 0; i < words.Length; i++)
        {
            var currentWord = words[i];

            if (! uniqueWords.Contains(currentWord))
            {
                uniqueWords.Add(currentWord);
                ocuurenses.Add(1);
            }
            else
            {
                int wordIndex = uniqueWords.IndexOf(currentWord);
                ocuurenses[wordIndex]++;
            }
        }

        var percentage = new List<decimal>();

        for (int i = 0; i < uniqueWords.Count; i++)
        {           
            percentage.Add((decimal)ocuurenses[i] / words.Length * 100.0m);
        }

        for (int write = 0; write < uniqueWords.Count; write++)
        {
            for (int sort = 0; sort < uniqueWords.Count - 1; sort++)
            {
                var temp = 0;

                if (ocuurenses[sort] < ocuurenses[sort + 1])
                {
                    temp = ocuurenses[sort];
                    ocuurenses[sort] = ocuurenses[sort + 1];
                    ocuurenses[sort + 1] = temp;

                    var strTemp = string.Empty;

                    strTemp = uniqueWords[sort];
                    uniqueWords[sort] = uniqueWords[sort + 1];
                    uniqueWords[sort + 1] = strTemp;

                    var percTemp = 0m;

                    percTemp = percentage[sort];
                    percentage[sort] = percentage[sort + 1];
                    percentage[sort + 1] = percTemp;
                }

            }
        }

        for (int i = 0; i < uniqueWords.Count; i++)
        {
            Console.WriteLine($"{uniqueWords[i]} -> {ocuurenses[i]} times ({percentage[i]:f2}%)");
        }

    }
}

