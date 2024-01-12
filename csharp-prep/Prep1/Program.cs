using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your given name?");
        string name=Console.ReadLine();
        Console.Write("What's your surname?");
        string surname=Console.ReadLine();
        Console.WriteLine($"Your name is {surname}, {name} {surname}.");
    }
}