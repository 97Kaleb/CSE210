using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        int n = RandomNumberGenerator.GetInt32(1, 100);
        int g = 0;
        int gnum = 0;
        do{
            Console.WriteLine("Input Guess.\n");
            g = int.Parse(Console.ReadLine());
            if(g>n){
                Console.WriteLine("Lower.");
            }else if(g<n){
                Console.WriteLine("Higher.");
            }
            gnum ++;
        }while (g!=n);
        Console.WriteLine($"Congratulations. You got it in {gnum} guesses.");
    }
}