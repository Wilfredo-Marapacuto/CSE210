// BYU Pathway Worldwide
// Course: CSE210.002 - Programming with Classes
// Term: 2026 Block 2
// Author: Wilfredo Jose Marapacuto Verastegui
// W03 Activity: Scripture Memorizer Design

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        Scripture scripture = new Scripture(
            reference,
            "Trust in the Lord with all your heart and lean not on your own understanding. In all your ways acknowledge Him and He shall direct your paths."
        );

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to exit: ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Program finished.");
    }
}