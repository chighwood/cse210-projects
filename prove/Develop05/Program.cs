using System;

// I have worked on this for a long time so I hope it works the way it is suppose to. 
// I have added a few different extras to make it a little more clean in the code. I 
// first started off by clearing the console every time so that we don't have an on going 
// list of menus and info. I have also allowed for the files saved to be avaliable to
// choose from when loading in the data. I was able to do that by adding .fil to the end
// of each file so when I serached for them, it would only return those that ended that 
// way. I also added in to my eternal goals the number of times you completed that task.
// Since it has an infinite amount, I thought it would be cool to see how many times you 
// completed it. I hope this is what you were looking for or close to it. Thank you for 
// your time of reading through it. 

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        // goalManager.Start();

        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Score: " + goalManager.GetScore());
            Console.WriteLine("\nMenu options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("\nSelect a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    goalManager.ListGoals();
                    break;
                case "3":
                    goalManager.SaveGoals();
                    break;
                case "4":
                    goalManager.LoadGoals();
                    break;
                case "5":
                    goalManager.RecordEvent();
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
