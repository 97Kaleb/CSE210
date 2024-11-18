using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Console.WriteLine("Return value as 1: fraction, or 2: decimal?");
        int select = Convert.ToInt32(Console.ReadLine());
        if (select == 1){
            Console.WriteLine(frac1.GetFrac());
        }else if (select == 2){
            Console.WriteLine(frac1.GetDec());
        }else{
            Console.WriteLine("Invalid selection.");
        }
    }
 
}