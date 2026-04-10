using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            int remainingTime = (int)(endTime - DateTime.Now).TotalSeconds;

            if (remainingTime <= 0)
            {
                break;
            }

            Console.Write("Breathe in... ");
            ShowCountDown(Math.Min(4, remainingTime));
            Console.WriteLine();

            remainingTime = (int)(endTime - DateTime.Now).TotalSeconds;

            if (remainingTime <= 0)
            {
                break;
            }

            Console.Write("Breathe out... ");
            ShowCountDown(Math.Min(6, remainingTime));
            Console.WriteLine();
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}