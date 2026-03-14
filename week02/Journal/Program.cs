// BYU Pathway Worldwide
// Course: CSE210.002 - Programming with Classes
// Term: 2026 Block 2
// Author: Wilfredo Jose Marapacuto Verastegui
// W02 Project: Journal Program
// Creativity and Exceeding Requirements:
// This program exceeds the core requirements by:
// 1) Adding a personalized welcome message for the user.
// 2) Using a custom separator (|) when saving journal entries.
// 3) Displaying confirmation messages when saving and loading files.
// NOTE:
// I initially considered replacing the random prompts with fixed office log questions,
// because random questions are not very efficient for an office reporting system.
// However, I decided to keep the random prompt generator to comply with the
// assignment requirements. Changing it could mean not fully completing the
// "random prompt" requirement of the project and potentially receiving a lower grade.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("==============================================");
        Console.WriteLine("Welcome to the WM Servicios Hispanos Journal Reporting System");
        Console.WriteLine("==============================================");
        Console.WriteLine();

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do?");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                theJournal.AddEntry(newEntry);
                Console.WriteLine("Entry added successfully.");
            }
            else if (choice == "2")
            {
                theJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string file = Console.ReadLine();
                theJournal.LoadFromFile(file);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string file = Console.ReadLine();
                theJournal.SaveToFile(file);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}