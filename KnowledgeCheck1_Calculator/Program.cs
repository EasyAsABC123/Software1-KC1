using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
  class Program
  {
    static bool GetNumbers(string calculatorFunctionToDo, out int num1, out int num2)
    {
      Console.WriteLine("Enter 2 integers to " + calculatorFunctionToDo);
      var number1 = Console.ReadLine();
      var number2 = Console.ReadLine();

      if (int.TryParse(number1, out int number1Temp) && int.TryParse(number2, out int number2Temp))
      {
        num1 = number1Temp;
        num2 = number2Temp;
        return true;
      }
      else
      {
        Console.WriteLine("One or more of the numbers is not an int");
        num1 = 0;
        num2 = 0;
        return false;
      }
    }

    static void Main(string[] args)
    {

      Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

      var input = Console.ReadLine();
      var calculator = new Calculator();

      switch (input)
      {
        case "1":
          var success = GetNumbers("add", out int num1, out int num2);
          if (success == true)
          {
            Console.Write($"{num1} + {num2} = ");
            Console.Write(calculator.Add(num1, num2));
          }
          break;

        case "2":
          success = GetNumbers("subtract", out int subnum1, out int subnum2);
          if (success == true)
          {
            Console.Write($"{subnum1} - {subnum2} = ");
            Console.Write(calculator.Subtract(subnum1, subnum2));
          }
          break;

        case "3":
          Console.WriteLine("Enter 2 integers to multiply");
          var multiplyNumber1 = Console.ReadLine();
          var multiplyNumber2 = Console.ReadLine();

          if (int.TryParse(multiplyNumber1, out int mulNumOne) && int.TryParse(multiplyNumber2, out int mulNumTwo))
          {
            Console.Write($"{multiplyNumber1} * {multiplyNumber2} = ");
            Console.Write(calculator.Multiply(mulNumOne, mulNumTwo));
          }
          else
          {
            Console.WriteLine("One or more of the numbers is not an int");
          }
          break;

        case "4":
          Console.WriteLine("Enter 2 integers to divide");
          var divideNumber1 = Console.ReadLine();
          var divideNumber2 = Console.ReadLine();

          if (double.TryParse(divideNumber1, out double divNumOne) && double.TryParse(divideNumber2, out double divNumTwo))
          {
            Console.Write($"{divideNumber1} / {divideNumber2} = ");
            Console.Write(calculator.Divide(divNumOne, divNumTwo));
          }
          else
          {
            Console.WriteLine("One or more of the numbers is not an int");
          }
          break;

        default:
          Console.WriteLine("Unknown input");
          break;
      }
    }
  }
}