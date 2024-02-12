using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void Start()
    {
        DisplayStartingMessage();
        PrepareToBegin();
        PerformActivity();
        DisplayEndingMessage();
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"--- {name} ---");
        Console.WriteLine(description);
        Console.WriteLine("Please enter the duration in seconds:");

        int inputDuration;
        while (!int.TryParse(Console.ReadLine(), out inputDuration))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for the duration in seconds:");
        }
        duration = inputDuration;
    }

    protected void PrepareToBegin()
    {
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed {name} for {duration} seconds.");
        Thread.Sleep(3000);
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    protected abstract void PerformActivity();
}

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void PerformActivity()
    {
        int secondsPerPhase = duration / 2;
        int countdown = 3;

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(i == 0 ? "Breathe in..." : "Breathe out...");
            for (int j = secondsPerPhase; j >= 1; j--)
            {
                Console.WriteLine($"{countdown--}...");
                Thread.Sleep(1000);
            }
            countdown = 3;
        }
    }
}

public class ReflectionActivity : Activity
{
    private List<string> prompts;
    private List<string> questions;

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    protected override void PerformActivity()
    {
        int secondsPerQuestion = duration / questions.Count;
        Random random = new Random();

        foreach (string prompt in prompts)
        {
            Console.WriteLine(prompt);
            Thread.Sleep(3000);

            foreach (string question in questions)
            {
                Console.WriteLine(question);
                Thread.Sleep(secondsPerQuestion * 1000);
                Console.WriteLine("Spinner animation...");
                Thread.Sleep(1000);
            }
        }
    }
}

public class ListingActivity : Activity
{
    private List<string> prompts;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    protected override void PerformActivity()
    {
        int countdown = 5;
        Random random = new Random();

        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Thread.Sleep(5000);

        Console.WriteLine("Think about the prompt and start listing items...");
        Thread.Sleep(3000);

        for (int i = 1; i <= duration; i++)
        {
            Console.WriteLine($"Item {i}");
            Thread.Sleep(1000);
        }

        Console.WriteLine($"You have listed {duration} items.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--- Mindfulness App ---");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice:");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Start();
                    break;
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Start();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Start();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
