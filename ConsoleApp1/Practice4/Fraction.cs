namespace ConsoleApp1;

public class Program
{
    public static void Main()
    {
        Fraction a = new Fraction(1, 2);
        Fraction b = new Fraction(3, 4);
        Fraction c = new Fraction(5, 6);
        Fraction d = new Fraction(7, 8);
        Fraction e = new Fraction(9, 10);
        Fraction f = new Fraction(11, 12);

        // Z = ((a/b + c/d) / (e/f)) * (g/h - k/l)
        Fraction sum = a + b;
        Fraction div = sum / c;
        Fraction diff = d - e;
        Fraction result = div * diff;

        Console.WriteLine($"Unreduced fraction: {result}");
        result.Reduce();
        Console.WriteLine($"Reduced fraction: {result}");
    }
}