class Program
{
    static void Main(string[] args)
    {
        string[] prompts = { "What did you do today?", "What did you learn today?", "What are you grateful for today?" };
        string[] responses = new string[prompts.Length];
        DateTime date = DateTime.Now;

        for (int i = 0; i < prompts.Length; i++)
        {
            Console.Write(prompts[i] + ": ");
            responses[i] = Console.ReadLine();
        }

        using (StreamWriter writer = new StreamWriter("events.txt", true))
        {
            writer.WriteLine("Date: " + date.ToString());
            for (int i = 0; i < prompts.Length; i++)
            {
                writer.WriteLine(prompts[i] + ": " + responses[i]);
            }
        }
        Console.WriteLine("Event saved successfully!");
    }
}