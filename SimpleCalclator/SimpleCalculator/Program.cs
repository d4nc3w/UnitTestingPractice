
using SimpleCalclator;

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
