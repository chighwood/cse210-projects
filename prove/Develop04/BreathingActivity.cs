using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }
    public new void Run()
    {
        base.DisplayStartingMessage();
        BreathingCycle();
        base.DisplayEndingMessage();
    }

    private void BreathingCycle()
    {
        while (_duration > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine("Breathe out...");
            ShowCountDown(5);
            _duration -= 10;
        }
    }
}