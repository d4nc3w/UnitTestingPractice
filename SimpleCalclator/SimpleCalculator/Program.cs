
using SimpleCalclator;

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        Console.WriteLine("Add");
        var val1 = calculator.calculate(5, 6, '+');
        Console.WriteLine(val1);

        Console.WriteLine("Subtract");
        var val2 = calculator.calculate(10, 3, '-');
        Console.WriteLine(val2);

        Console.WriteLine("Multiply");
        var val3 = calculator.calculate(6, 6, '*');
        Console.WriteLine(val3);

        Console.WriteLine("Divide");
        var val4 = calculator.calculate(72, 4, '/');
        Console.WriteLine(val4);

        Console.WriteLine("");
        Console.WriteLine("Please enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter an operator[+, -, /, *]: ");
        char op = char.Parse(Console.ReadLine());
        Console.WriteLine(calculator.calculate(num1, num2, op));
    }
}
