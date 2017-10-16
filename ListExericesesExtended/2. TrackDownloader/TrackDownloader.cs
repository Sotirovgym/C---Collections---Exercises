using System;
using System.Collections.Generic;
using System.Linq;

class TrackDownloader
{
    static void Main()
    {
        var blackList = Console.ReadLine().Split(' ').ToList();

        var fileNames = Console.ReadLine();

        var result = new List<string>();

        

        while (fileNames != "end")
        {
            var count = 0;

            for (int i = 0; i < blackList.Count; i++)
            {
                if (fileNames.Contains(blackList[i]))
                {
                    break;
                }
                else
                {
                    count++;
                }
            }

            if (count == blackList.Count)
            {
                result.Add(fileNames);
            }

            fileNames = Console.ReadLine();
        }

        result.Sort();

        foreach (var fileName in result)
        {
            Console.WriteLine(fileName);
        }
    }
}

