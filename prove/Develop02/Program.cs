using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Show Random Prompt");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal to File");
            Console.WriteLine("4. Load Journal from File");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string number = Console.ReadLine();

            switch (number)
            {
                case "1":
                    journal.RandomPrompt();
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    journal.SaveJournal();
                    break;
                case "4":
                    journal.LoadJournal();
                    break;
                case "5":
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

    
    
