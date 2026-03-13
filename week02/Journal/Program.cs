using System;
using System.IO;

/* I formatted the choice from the menu to have the selection be on the same line; provided an error if you load a file not found and improved UX by having the inputs on the same line*/

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        promptGenerator._prompts.Add("Who was the most interesting person I interacted with today?");
        promptGenerator._prompts.Add("What was the best part of my day?");
        promptGenerator._prompts.Add("How did I see the hand of the Lord in my life today?");
        promptGenerator._prompts.Add("What was the strongest emotion I felt today?");
        promptGenerator._prompts.Add("If I had one thing I could do over today, what would it be?");

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");

            string userInput = Console.ReadLine();
            choice = int.Parse(userInput);

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("> ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                theJournal._entries.Add(newEntry);
            }
            else if (choice == 2)
            {
                theJournal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter the filename: ");
                string fileName = Console.ReadLine();

                if (File.Exists(fileName))
                {
                    theJournal.LoadFromFile(fileName);
                    Console.WriteLine("Journal loaded.");
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }
            else if (choice == 4)
            {
                Console.Write("Enter the filename: ");
                string fileName = Console.ReadLine();

                theJournal.SaveToFile(fileName);

                Console.WriteLine("Journal saved.");
            }
        }
    }
}