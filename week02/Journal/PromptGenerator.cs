using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
    "Which clients need to be called tomorrow first thing in the morning?",
    "Which cases were approved today?",
    "Which cases were denied today?",
    "What correspondence will I leave in the mailbox today?",
    "What problems arose in the office today?"
    };

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);
        return _prompts[index];
    }
}