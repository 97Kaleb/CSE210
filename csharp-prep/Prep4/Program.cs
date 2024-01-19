using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> n = new List<int>();
        int i;
        int sum = 0;
        float x = 0;
        int g = 0;
        do{
            Console.WriteLine("Enter Number (0 to exit)");
            i = int.Parse(Console.ReadLine());
            if(i!=0){
                n.Add(i);
            }
        }while(i!=0);
        foreach (int I in n){
            sum = sum + I;
            x++;
        }
        float Sum = sum;
        float average= Sum / x;
        foreach(int I in n){
            if (I > g){
                g=I;
            }
        }
        Console.WriteLine($"Sum: {sum}\nAverage: {average}\nGreatest Value: {g}");
    }
}