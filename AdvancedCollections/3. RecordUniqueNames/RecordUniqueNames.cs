using System;
using System.Collections.Generic;
using System.Linq;

class RecordUniqueNames
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var names = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {
            var inputNames = Console.ReadLine();
            
            names.Add(inputNames);            
        }

        Console.WriteLine(string.Join(Environment.NewLine, names));
    }
}

