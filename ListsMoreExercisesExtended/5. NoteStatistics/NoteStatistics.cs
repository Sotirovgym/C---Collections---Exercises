using System;
using System.Collections.Generic;
using System.Linq;

class NoteStatistics
{
    static void Main(string[] args)
    {
        var inputFrequencies = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        var frequencies = new List<double> { 261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88 };

        var musicalNotes = new List<string> { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

        var naturals = new List<string>();
        var sharps = new List<string>();
        var allNotes = new List<string>();

        var naturalsSum = 0d;
        var sharpsSum = 0d;

        foreach (var frequency in inputFrequencies)
        {
            var frequencyIndex = frequencies.IndexOf(frequency);
            var musicalNote = musicalNotes[frequencyIndex];

            if (musicalNote.Contains("#"))
            {
                sharpsSum += frequency;
                sharps.Add(musicalNote);
            }
            else
            {
                naturalsSum += frequency;
                naturals.Add(musicalNote);
            }

            allNotes.Add(musicalNote);
        }

        var isZeroSharps = sharpsSum == 0 ? 0 : Math.Round(sharpsSum, 2);
        var isZeroNaturals = naturalsSum == 0 ? 0 : Math.Round(naturalsSum, 2);

        Console.WriteLine($"Notes: {string.Join(" ", allNotes)}");
        Console.WriteLine($"Naturals: {string.Join(", ", naturals)}");
        Console.WriteLine($"Sharps: {string.Join(", ", sharps)}");
        Console.WriteLine($"Naturals sum: {isZeroNaturals}");
        Console.WriteLine($"Sharps sum: {isZeroSharps}");

    }
}

