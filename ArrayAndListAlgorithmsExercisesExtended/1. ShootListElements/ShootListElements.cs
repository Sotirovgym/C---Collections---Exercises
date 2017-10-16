using System;
using System.Collections.Generic;
using System.Linq;

class ShootListElements
{
    static void Main()
    {
        var shootList = new List<int>();

        var inputLine = Console.ReadLine();

        var lastRemovedElement = 0;

        while (inputLine != "stop")
        {
            var number = 0;

            if (int.TryParse(inputLine, out number))
            {
                shootList.Insert(0, number);
            }
            else
            {               

                if (shootList.Count == 0)
                {
                    Console.WriteLine($"nobody left to shoot! last one was {lastRemovedElement}");
                    return;
                }

                var avarage = shootList.Average();

                for (int i = 0; i < shootList.Count; i++)
                {
                    if (shootList[i] <= avarage)
                    {
                        Console.WriteLine($"shot {shootList[i]}");

                        lastRemovedElement = shootList[i];
                        shootList.RemoveAt(i);
                        i--;

                        for (int j = 0; j < shootList.Count; j++)
                        {
                            shootList[j]--;
                        }

                        break;
                    }
                }
            }
            
            inputLine = Console.ReadLine();
        }

        if (shootList.Count == 0)
        {
            Console.WriteLine($"you shot them all. last one was {lastRemovedElement}");
        }
        else
        {
            Console.WriteLine($"survivors: {string.Join(" ", shootList)}");
        }
    }
}

