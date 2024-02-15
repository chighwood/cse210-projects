using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }
    public int GetScore()
    {
        return _score; 
    }

    public void Start()
    {
        Console.Write("");
        // Method to start the goal manager, initialize any necessary resources or display initial information
    }
    
    public void ListGoals()
    {
        // Method to list the names of all goals
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Creating a new goal:");
        Console.WriteLine("Select the type of goal you want to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("Enter the name of your goal: ");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter a description of that goal: ");
                string description = Console.ReadLine();
                Console.WriteLine("How many points will this goal be worth: ");
                int.TryParse(Console.ReadLine(), out int points);
                _goals.Add(new SimpleGoal(name, description, points));
                break;

            case "2":
                Console.WriteLine("Enter the name of your goal: ");
                string name2 = Console.ReadLine();
                Console.WriteLine("Please enter a description of that goal: ");
                string description2 = Console.ReadLine();
                Console.WriteLine("How many points will this goal be worth: ");
                int.TryParse(Console.ReadLine(), out int points2);
                _goals.Add(new SimpleGoal(name2, description2, points2));    
                // CreateEternalGoal();
                break;

            case "3":
                Console.WriteLine("Enter the name of your goal: ");
                string name3 = Console.ReadLine();
                Console.WriteLine("Please enter a description of that goal: ");
                string description3 = Console.ReadLine();
                Console.WriteLine("How many points will this goal be worth: ");;
                int.TryParse(Console.ReadLine(), out int points3);
                Console.WriteLine("Please enter the amount of bonus points for completing the goal: ");
                int.TryParse(Console.ReadLine(), out int bonus);
                Console.WriteLine("What is the target amount of times you want to achieve the goal: ");
                int.TryParse(Console.ReadLine(), out int target);
                _goals.Add(new ChecklistGoal(name3, description3, points3, bonus, target));
                // CreateChecklistGoal();
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        Console.WriteLine("Goal created! ");
    }

    public void RecordEvent()
    {
        // Method to record progress or completion of a goal
        // List the goals with numbers for the user to select
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{_goals.IndexOf(goal)}. {goal.GetStringRepresentation()}");
        }
        // Prompt user to select a goal from the list
        Console.WriteLine("\nSelect a goal to record progress or completion: ");
        string choice = Console.ReadLine();
        int i = int.Parse(choice);

        // Call the appropriate method on the selected goal to record progress or completion
        if ( i < 0 || i >= _goals.Count)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }
        if (!_goals[i].IsComplete())
        {
            _goals[i].RecordEvent();
            _score += _goals[i].GetPoints();

            // This second "if" statement checks to see if goal is completed or not. 
            // It then uses the correct statement depending on if it's true or false.
            // It's mainly for the Checklist Goal and Eternal Goal classes.
            // Recording an event doesn't always complete a goal hence why this "if" statement is used.
            if (_goals[i].IsComplete())
            { 
                Console.Write("Congratulations on completing your goal! ");
                
            } else {
                Console.Write("Keep up the good work! ");
            }
        }   
    }

    public void SaveGoals()
    {
        {
            Console.Write("Enter Filename to save to: ");
            string filename = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetType().FullName); // C# type system can output Namespace.ClassName, so will output GoalTracker.EternalGoal, GoalTracker.SimpleGoal, or GoalTracker.ChecklistGoal
                    goal.WriteToStreamWriter(writer);
                }
            }
        }

        // Method to save the list of goals to a file
        // Serialize the list of goals and write it to a file
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load from: ");
           string filename = Console.ReadLine();
           _goals.Clear();

           using (StreamReader reader = new StreamReader(filename))
           {
                while (!reader.EndOfStream)
                {
                    string typeLine = reader.ReadLine(); 
                    switch (typeLine)
                    {
                        case "GoalTracker.SimpleGoal":
                            _goals.Add(new SimpleGoal(reader));
                            break;
                        case "GoalTracker.ChecklistGoal":
                            _goals.Add(new ChecklistGoal(reader));
                            break;
                        case "GoalTracker.EternalGoal":
                            _goals.Add(new EternalGoal(reader));
                            break;
                        default:
                            new Exception("Unknown type found in file");
                            break;
                    }
                }
           }
        }
        // Method to load the list of goals from a file
        // Read the serialized data from the file and deserialize it to reconstruct the list of goals

}
