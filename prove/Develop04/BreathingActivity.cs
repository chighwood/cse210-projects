using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }
    public override void Run()
    {
        base.DisplayStartingMessage();
        BreathingCycle();
        base.DisplayEndingMessage();
    }

    private void BreathingCycle()
    {
        var LocalDuration = _duration;
        while (LocalDuration > 0)
        {
            Console.WriteLine("Breathe in...");
            base.ShowCountDown(5);
            Console.WriteLine("Breathe out...");
            base.ShowCountDown(5);
            LocalDuration -= 10;
        }
    }
}