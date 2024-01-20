using System;
using System.Collections.Generic;

public class Prompt
{
     private static List<string> _prompts = new List<string>
        {
            "What is one thing that you wish would have happend today that didn't?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "Did you make anyone's life better today or did someone do that for you?",
            "When saying your pray for the night, what thing happend today that you are most grateful for?"
        };

    public static string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);
        return _prompts[randomIndex];
    }
}