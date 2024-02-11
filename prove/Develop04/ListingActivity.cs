using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading;

class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string> 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "Who are people that you have helped this week?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. ")
    {
        _count = 0;
    }

    public override void Run()
    {
        base.DisplayStartingMessage();
        ListItems();
        base.DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Console.WriteLine(_prompts[new Random().Next(_prompts.Count)]);
    }

    private void ListItems()
    {
        GetRandomPrompt();
        ShowCountDown(5);

        Console.WriteLine("Press Enter when you are ready to start....");
        Console.ReadLine();

        var items = GetListFromUser();


        Console.WriteLine();
        Console.WriteLine($"Number of items entered: {_count}");
    }

    private List<string> GetListFromUser()
    {
        var items = new List<string>();
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();

            items.Add(item);
            _count++;
        }

        return items;
    }
}