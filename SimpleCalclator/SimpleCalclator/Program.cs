
using SimpleCalclator;

Calculator calculator = new Calculator();
var val1 = calculator.calculate(5, 6, '+');
Console.WriteLine(val1);
var val2 = calculator.calculate(10, 3, '-');
Console.WriteLine(val2);
var val3 = calculator.calculate(6, 6, '*');
Console.WriteLine(val3);
var val4 = calculator.calculate(72, 4, '/');
Console.WriteLine(val4);
