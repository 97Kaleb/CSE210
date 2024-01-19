using System;

class Program
{
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName(){
        Console.WriteLine("Please enter your name.");
        string n = Console.ReadLine();
        return n;
    }
    static int PromptUserNumber(){
        Console.WriteLine("Please enter your favorite number.");
        int n = int.Parse(Console.ReadLine());
        return n;
    }
    static int SquareNumber(int i){
        int n = i * i;
        return n;
    }
    static void DisplayResult(string name, int square){
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
    static void Main(string[] args){
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int N2 = SquareNumber(number);
        DisplayResult(name, N2);
    }
}