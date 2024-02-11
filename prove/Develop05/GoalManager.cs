using System;
using System.Collections.Generic;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void Start()
    {
        Console.Write("");
        // Method to start the goal manager, initialize any necessary resources or display initial information
    }
    public void DisplayPlayerInfo()
    {

    }
    
    public void ListGoalNames()
    {
        // Method to list the names of all goals
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal._shortName);
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
                CreateSimpleGoal();
                break;
            case "2":
                CreateEternalGoal();
                break;
            case "3":
                CreateChecklistGoal();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        Console.WriteLine("Goal created! ");
        // Method to create a new goal and add it to the list of goals
        // Prompt user for goal details (name, description, points, etc.)
        // Instantiate a new Goal object with the provided details
        // Add the goal to the list of goals
    }

    public void RecordGoal()
    {
        // Method to record progress or completion of a goal
        // Prompt user to select a goal from the list
        // Call the appropriate method on the selected goal to record progress or completion
    }

    public void SaveGoals()
    {
        // Method to save the list of goals to a file
        // Serialize the list of goals and write it to a file
    }

    public void LoadGoals()
    {
        // Method to load the list of goals from a file
        // Read the serialized data from the file and deserialize it to reconstruct the list of goals
    }
}
