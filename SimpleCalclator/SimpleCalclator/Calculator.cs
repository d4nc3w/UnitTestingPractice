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
            return x / y;
         default:
            return 0;
      }
   }
}