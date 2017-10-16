using System;
using System.Collections.Generic;
using System.Linq;

class Phone
{
    static void Main()
    {
        var phoneNumbers = Console.ReadLine().Split(' ');
        var names = Console.ReadLine().Split(' ');

        var inputLine = Console.ReadLine();

        var sum = 0;

        while (inputLine != "done")
        {
            var tokens = inputLine.Split(' ');
            var command = tokens[0];
            var nameOrNumber = tokens[1];

            CallMethod(phoneNumbers, names, sum, command, nameOrNumber);

            MessageMethod(phoneNumbers, names, sum, command, nameOrNumber);

            inputLine = Console.ReadLine();
        }
    }

    private static int MessageMethod(string[] phoneNumbers, string[] names, int sum, string command, string nameOrNumber)
    {
        if (command == "message")
        {
            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                if (names[i] == nameOrNumber)
                {
                    Console.WriteLine($"sending sms to {phoneNumbers[i]}...");

                    sum = SumOfDigitsOfNumber(phoneNumbers, sum, i);

                    SumIsEvenOrOdd(sum);
                    sum = 0;

                    break;

                }
                else if (phoneNumbers[i] == nameOrNumber)
                {
                    Console.WriteLine($"sending sms to {names[i]}...");

                    sum = SumOfDigitsOfNumber(phoneNumbers, sum, i);

                    SumIsEvenOrOdd(sum);
                    sum = 0;

                    break;
                }
            }
        }

        return sum;
    }

    private static int CallMethod(string[] phoneNumbers, string[] names, int sum, string command, string nameOrNumber)
    {
        if (command == "call")
        {
            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                if (names[i] == nameOrNumber)
                {
                    sum = SumOfDigitsOfNumber(phoneNumbers, sum, i);

                    Console.WriteLine($"calling {phoneNumbers[i]}...");

                    if (sum % 2 == 0)
                    {
                        var minutes = sum / 60;
                        var seconds = sum % 60;
                        Console.WriteLine($"call ended. duration: {minutes:d2}:{seconds:d2}");
                    }
                    else
                    {
                        Console.WriteLine("no answer");
                    }
                    sum = 0;

                    break;
                }
                else if (phoneNumbers[i] == nameOrNumber)
                {
                    sum = SumOfDigitsOfNumber(phoneNumbers, sum, i);

                    Console.WriteLine($"calling {names[i]}...");

                    if (sum % 2 == 0)
                    {
                        var minutes = sum / 60;
                        var seconds = sum % 60;
                        Console.WriteLine($"call ended. duration: {minutes:d2}:{seconds:d2}");
                    }
                    else
                    {
                        Console.WriteLine("no answer");
                    }
                    sum = 0;

                    break;
                }
            }
        }

        return sum;
    }

    static void SumIsEvenOrOdd(int sum)
    {
        if (sum % 2 == 0)
        {
            var minutes = sum / 60;
            var seconds = sum % 60;
            Console.WriteLine($"meet me there");
        }
        else
        {
            Console.WriteLine("busy");
        }
    }

    static int SumOfDigitsOfNumber(string[] phoneNumbers, int sum, int i)
    {
        foreach (var digit in phoneNumbers[i])
        {
            if (digit >= '0' && digit <= '9')
            {
                sum += digit - '0';
            }
        }

        return sum;
    }

}

