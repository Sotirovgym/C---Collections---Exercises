using System;
using System.Collections.Generic;
using System.Linq;

class Last3ConsecutiveEqualStrings
{
    static void Main()
    {
        var words = Console.ReadLine().Split(' ');

        var reversedWords = words.Reverse().ToArray();

        var currentWord = string.Empty;
        var count = 0;

        for (int i = 0; i < reversedWords.Length; i++)
        {                        

            if (reversedWords[i].Contains(currentWord))
            {
                count++;

                if (count == 3)
                {
                    break;
                }
            }
            else
            {
                count = 1;
            }

            currentWord = reversedWords[i];
        }

        Console.WriteLine($"{currentWord} {currentWord} {currentWord}");
    }
}

