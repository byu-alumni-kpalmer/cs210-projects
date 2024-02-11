

using System;

class Journal
{
    static string journalDirectory = "JournalEntries";

    static void Main()
    {
        if (!Directory.Exists(journalDirectory))
        {
            Directory.CreateDirectory(journalDirectory);
        }

        while (true)
        {
            Console.WriteLine("Journal Application");
            Console.WriteLine("1. Write an entry");
            Console.WriteLine("2. Read entries");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    WriteEntry();
                    break;
                case "2":
                    ReadEntries();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void WriteEntry()
    {
        Console.Write("Write your journal entry:\n");
        string content = Console.ReadLine();
        string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
        string filename = $"Entry_{timestamp}.txt";

        File.WriteAllText(Path.Combine(journalDirectory, filename), content);

        Console.WriteLine("Journal entry saved.\n");
    }

    static void ReadEntries()
    {
        var entries = Directory.GetFiles(journalDirectory);

        foreach (var entry in entries)
        {
            Console.WriteLine($"Reading {Path.GetFileName(entry)}:");
            Console.WriteLine(File.ReadAllText(entry));
            Console.WriteLine("-------------------------\n");
        }

        if (entries.Length == 0)
        {
            Console.WriteLine("No journal entries found.");
        }
    }
}

