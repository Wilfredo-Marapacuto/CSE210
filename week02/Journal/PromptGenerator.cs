using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the most important task I completed today for my business?",
        "What challenge did I face today while helping a client, and how did I solve it?",
        "What did I learn today that can help me improve my services?",
        "What opportunity did I notice today to grow my business?",
        "How did I make a positive impact in someone's life today through my work?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}