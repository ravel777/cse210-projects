using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your firstName: ");
        string fname = Console.ReadLine();
        Console.WriteLine("Enter your lasttName: ");
        string lname = Console.ReadLine();

        Console.WriteLine($"Your full name is: {fname} {lname}");
    }
}