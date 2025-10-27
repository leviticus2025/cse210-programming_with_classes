using System;
using System.Collections.Generic;

public class Prompt
{
    private List<string> _prompts;
    private Random _random;
    public Prompt()
    {
        _random = new Random();
        _prompts = new List<string>
        {
            "What made you smile today?",
            "What's something valuable that you learned today?",
            "Who's someone you're grateful for recently?",
            "What was the best part of your day?",
            "How did you see the hand of the Lord in your life today?",
            "What was hard about your day and/or week and what did you do to make it better?",
            "How did you feel blessed today?",
            "How was your stress/anxiety levels today?",
            "Who made your day a little bit better?"
        };
    }
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
