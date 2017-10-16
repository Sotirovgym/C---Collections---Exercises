using System;
using System.Collections.Generic;
using System.Linq;

class Phonebook
{
    static void Main()
    {
        var phoneNumbers = Console.ReadLine().Split(' ');

        var names = Console.ReadLine().Split(' ');
                

        while (true)
        {
            var command = Console.ReadLine();

            if (command == "done")
            {
                break;
            }

            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                if (names[i] == command)
                {
                    Console.WriteLine($"{names[i]} -> {phoneNumbers[i]}");
                    break;
                }
            }
        }
    }
}

