using System;

class Program
{
    static void Main()
    {
        // 1. Create a string variable called patientName
        string patientName;

        // 2. Ask who is being seen today
        Console.WriteLine("Who is being seen today?");

        // 3. Read what the user types
        patientName = Console.ReadLine();

        // 4. Write welcome message
        Console.WriteLine("Welcome: " + patientName);
    }
}
