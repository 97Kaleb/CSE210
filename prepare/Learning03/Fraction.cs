public class Fraction{
    int dividend;
    int divisor;
    public Fraction(){
        Console.WriteLine("Dividend: ");
        this.dividend = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Divisor: ");
        this.divisor = Convert.ToInt32(Console.ReadLine());
    }
    public string GetFrac(){
        return $"{this.dividend}/{this.divisor}";
    }
    public double GetDec(){
        double decDividend = Convert.ToDouble(dividend);
        double decDivisor = Convert.ToDouble(divisor);
        return decDividend / decDivisor;
    }
}