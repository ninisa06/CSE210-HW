using System;
using System.Runtime.CompilerServices;
public class PromptGenerator
{
    public List <string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one I could do over today, what would it be? ",
        "What am I grateful for today? "
    };

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Length);
        
        string prompt;
        for (int i = index; i < _prompts.Count; i++)
        {
            prompt = (_prompts[i]);
        }
        
        return prompt;
    }
}