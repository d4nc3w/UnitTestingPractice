namespace SimpleCalclator;

public class Calculator
{
   public int calculate(int x, int y, char sign)
   {
      switch (sign)
      {
         case '+':
            return x + y;
         case '-':
            return x - y;
         case '*':
            return x * y;
         case '/':
            if (y == 0)
            {
               throw new DivideByZeroException();
            }
            return x / y;
         default:
            throw new ArithmeticException();
      }
   }
}