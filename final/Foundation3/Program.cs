using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("1645 E. Thomas RD", "Phoenix", "AZ", "85016");
        Lecture lecture = new Lecture("Palmer Keith", "BYU-Student", "2024-10-25", "11:00 AM", address, "Ermilus", 32);
        Reception reception = new ("Networking Mixer", "Network with professionals", "2024-02-20", "6:00 PM", address, "pal23006@byui.edu");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Rosevelt Row", "First Fridays", "2024-11-26", "1:00 PM", address);

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (Event e in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(e.GetStandardDetails());

            Console.WriteLine("\nShort Description:");
            Console.WriteLine(e.GetShortDescription());

            Console.WriteLine();
        }
    }
}
