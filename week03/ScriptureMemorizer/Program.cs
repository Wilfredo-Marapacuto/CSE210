// BYU Pathway Worldwide
// Course: CSE210.002 - Programming with Classes
// Term: 2026 Block 2
// Author: Wilfredo Jose Marapacuto Verastegui
// W03 Project: Scripture Memorizer Program

// Creativity / Exceeding Requirements:
// This program exceeds the core requirements by hiding only one word at a time
// and by providing semantic hints for selected hidden words. These hints help
// the user continue memorizing the scripture without revealing the exact word.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("2 Nephi", 32, 3);

        Dictionary<string, string> hints = new Dictionary<string, string>
        {
            { "angels", "messengers of God" },
            { "power", "divine strength" },
            { "holy", "sacred" },
            { "ghost", "Spirit of God" },
            { "christ", "Savior" },
            { "feast", "nourish yourself deeply" },
            { "words", "divine teachings" },
            { "tell", "guide" },
            { "things", "needed truths" },
            { "do", "act" }
        };

        Scripture scripture = new Scripture(
            reference,
            "Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do.",
            hints
        );

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to exit: ");

            string input = Console.ReadLine() ?? "";

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(1);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Program finished.");
    }
}