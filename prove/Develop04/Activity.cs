using System;
using System.Threading;
class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        this._name = name;
        this._description = description;
        this._duration = 0;
    }

    public void SetDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"{_name} - {_description}");
        SetDuration();
        Console.WriteLine("About to begin...");
        ShowCountDown(4);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good work!");
        ShowCountDown(2);
        Console.WriteLine($"You completed {_name} for {_duration} seconds! ");
        ShowCountDown(2);
        Console.WriteLine("Activity has concluded."); 
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("Done.");
    }

    public virtual void Run()
    {

    }
}