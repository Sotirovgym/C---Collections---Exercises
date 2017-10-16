using System;
using System.Collections.Generic;
using System.Linq;

class CamelsBack
{
    static void Main()
    {
        var buildings = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        var camelsBack = int.Parse(Console.ReadLine());

        var rounds = 0;

        for (int i = 0; i < buildings.Count; i++)
        {

            if (buildings.Count > camelsBack)
            {
                rounds++;

                buildings.RemoveAt(0);
                buildings.RemoveAt(buildings.Count - 1);
            }

        }

        if (rounds > 0)
        {
            Console.WriteLine($"{rounds} rounds");
            Console.WriteLine($"remaining: {string.Join(" ", buildings)}");
        }
        else
        {
            Console.WriteLine($"already stable: {string.Join(" ", buildings)}");
        }
    }
}

