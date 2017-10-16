using System;
using System.Collections.Generic;
using System.Linq;

class AverageCharacterDelimiter
{
    static void Main()
    {
        var words = Console.ReadLine().Split(' ').ToArray();

        var count = 0;
        var sum = 0;
        var lettersInString = string.Empty;

        for (int i = 0; i < words.Length; i++)
        {
            lettersInString += words[i];
        }

        for (int i = 0; i < lettersInString.Length; i++)
        {
            count++;
            sum += lettersInString[i];
        }

        var delimiter = (char)(sum / count);
        var delimiterToUpper = (char.ToUpper(delimiter)).ToString();

        Console.WriteLine(string.Join(delimiterToUpper, words));
    }
}
